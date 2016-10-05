using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using BitMiracle.LibTiff.Classic;

namespace Belegleser
{
    class TiffEncoder
    {
        /// <summary>
        /// Encodes the provided TIFF file with new compression and pixel format.
        /// </summary>
        /// <param name="path">The source TIFF image file.</param>
        /// <param name="compression">Desired TIFF compression.</param>
        /// <param name="format">Desired pixel format.</param>
        /// <remarks>
        /// The original file is overwritten with the result.
        /// </remarks>
        public static void Encode(string path, Bitmap bmp)
        {
            Bitmap tmp = new Bitmap(bmp);
            using (Tiff tif = Tiff.Open(path, "w"))
            {
                byte[] raster = getImageRasterBytes(tmp, PixelFormat.Format24bppRgb);
                tif.SetField(TiffTag.IMAGEWIDTH, 2480);
                tif.SetField(TiffTag.IMAGELENGTH, 3507);
                tif.SetField(TiffTag.COMPRESSION, Compression.JPEG);
                tif.SetField(TiffTag.PHOTOMETRIC, Photometric.RGB);

                // Compression Level: 100 = No comression, 0 = Maximum 
                tif.SetField(TiffTag.JPEGQUALITY, 10);
                tif.SetField(TiffTag.ROWSPERSTRIP, bmp.Height);

                tif.SetField(TiffTag.XRESOLUTION, 300);
                tif.SetField(TiffTag.YRESOLUTION, 300);

                tif.SetField(TiffTag.BITSPERSAMPLE, 8);
                tif.SetField(TiffTag.SAMPLESPERPIXEL, 3);

                tif.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG);

                int stride = raster.Length / tmp.Height;
                convertSamples(raster, tmp.Width, tmp.Height);

                for (int i = 0, offset = 0; i < tmp.Height; i++)
                {
                    tif.WriteScanline(raster, offset, i, 0);
                    offset += stride;
                }
            }
        }
       

        private static byte[] getImageRasterBytes(Bitmap bmp, PixelFormat format)
        {
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            byte[] bits = null;

            try
            {
                // Lock the managed memory
                BitmapData bmpdata = bmp.LockBits(rect, ImageLockMode.ReadWrite, format);

                // Declare an array to hold the bytes of the bitmap.
                bits = new byte[bmpdata.Stride * bmpdata.Height];

                // Copy the values into the array.
                System.Runtime.InteropServices.Marshal.Copy(bmpdata.Scan0, bits, 0, bits.Length);

                // Release managed memory
                bmp.UnlockBits(bmpdata);
            }
            catch
            {
                return null;
            }

            return bits;
        }

        private static void convertSamples(byte[] data, int width, int height)
        {
            int stride = data.Length / height;
            const int samplesPerPixel = 3;

            for (int y = 0; y < height; y++)
            {
                int offset = stride * y;
                int strideEnd = offset + width * samplesPerPixel;

                for (int i = offset; i < strideEnd; i += samplesPerPixel)
                {
                    byte temp = data[i + 2];
                    data[i + 2] = data[i];
                    data[i] = temp;
                }
            }
        }
    }
}
