﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
//using BitMiracle.LibTiff.Classic;

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

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            // Create a Bitmap object based on a BMP file.
            myBitmap = new Bitmap(bmp, 827, 1169);

            // Get an ImageCodecInfo object that represents the TIFF codec.
            myImageCodecInfo = GetEncoderInfo("image/tiff");

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            myEncoderParameters = new EncoderParameters(2);

            // Save the bitmap as a TIFF file with LZW compression.
            myEncoderParameter = new EncoderParameter(Encoder.Compression, (long)EncoderValue.CompressionLZW);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myEncoderParameter = new EncoderParameter(Encoder.ColorDepth, 24L);
            myEncoderParameter = new EncoderParameter(Encoder.Quality, 30L);
            myEncoderParameters.Param[1] = myEncoderParameter;

            myBitmap.Save(path, myImageCodecInfo, myEncoderParameters);
            //Bitmap tmp = new Bitmap(bmp, 827, 1169);
            //using (Tiff tif = Tiff.Open(path, "w"))
            //{
            //    byte[] raster = getImageRasterBytes(tmp, PixelFormat.Format24bppRgb);
            //    tif.SetField(TiffTag.IMAGEWIDTH, 827);
            //    tif.SetField(TiffTag.IMAGELENGTH, 1169);
            //    tif.SetField(TiffTag.COMPRESSION, Compression.LZW);
            //    tif.SetField(TiffTag.PHOTOMETRIC, Photometric.RGB);

            //    // Compression Level: 100 = No comression, 0 = Maximum 
            //    tif.SetField(TiffTag.JPEGQUALITY, 100);
            //    tif.SetField(TiffTag.ROWSPERSTRIP, bmp.Height);

            //    tif.SetField(TiffTag.XRESOLUTION, 96);
            //    tif.SetField(TiffTag.YRESOLUTION, 96);

            //    tif.SetField(TiffTag.BITSPERSAMPLE, 8);
            //    tif.SetField(TiffTag.SAMPLESPERPIXEL, 3);

            //    tif.SetField(TiffTag.PLANARCONFIG, PlanarConfig.CONTIG);

            //    int stride = raster.Length / tmp.Height;
            //    convertSamples(raster, tmp.Width, tmp.Height);

            //    for (int i = 0, offset = 0; i < tmp.Height; i++)
            //    {
            //        tif.WriteScanline(raster, offset, i, 0);
            //        offset += stride;
            //    }
            //}
            myBitmap.Dispose();
        }

        //TEst
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
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
