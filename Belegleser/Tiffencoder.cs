using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
        public static void Encode(string path, TiffCompressOption compression, PixelFormat format)
        {
            BitmapDecoder decoder = TiffBitmapDecoder.Create(
                new Uri(path),
                BitmapCreateOptions.PreservePixelFormat,
                BitmapCacheOption.OnLoad);

            TiffBitmapEncoder encoder = new TiffBitmapEncoder();
            encoder.Compression = compression;
            encoder.Frames.Add(BitmapFrame.Create(SetPixelFormat(decoder.Frames[0], format)));
            using (var stream = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                encoder.Save(stream);
            }
        }
        /// <summary>
        /// Sets the pixel format for an image.
        /// </summary>
        /// <param name="image">The original image.</param>
        /// <param name="pixelFormat">The desired pixel format.</param>
        /// <returns>The image converted ot the desired pixel format.</returns>
        private static BitmapSource SetPixelFormat(BitmapSource image, PixelFormat format)
        {
            var formatted = new FormatConvertedBitmap();
            formatted.BeginInit();
            formatted.Source = image;
            formatted.DestinationFormat = format;
            formatted.EndInit();
            return formatted;
        }
    }
}
