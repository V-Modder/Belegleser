using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tessnet2;
using System.Drawing;

namespace Belegleser
{
    class OcrTessarect
    {
        private Tesseract ocr;

        public OcrTessarect(bool isNumeric)
        {
            this.ocr = new Tesseract();
            //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
            this.ocr.Init(null, "deu", isNumeric); // To use correct tessdata
        }

        ~OcrTessarect()
        {
            this.Dispose();
        }

        public string readFile(Bitmap image, Rectangle rect)
        {
            Bitmap img = (Bitmap)image.Clone();
            if (checkPicture(img, rect) == false)
            {
                throw new ArgumentException("Das Rechteck passt nicht in das Bild!");
            }
                List<Word> res = this.ocr.DoOCR(img, rect);
                img.Dispose();
                img = null;
                return this.getValue(res);
        }

        private bool checkPicture(Bitmap image, Rectangle rect)
        {
            if (image.Width >= (rect.X + rect.Width) && image.Height >= (rect.Y + rect.Height))
            {
                return true;
            }
           return false;
        }

        private string getValue(List<Word> words)
        {
            int lines = 0;
            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            foreach (Word wrd in words)
            {
                if (wrd.LineIndex > lines)
                {
                    sb.Append("\n");
                    isFirst = true;
                    lines++;
                }
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    sb.Append(" ");
                }
                sb.Append(wrd.Text);
            }

            return sb.ToString();
        }

        public void Dispose()
        {
            if (this.ocr != null)
            {
                ocr.Clear();
                ocr.Dispose();
                ocr = null;
                GC.Collect();
            }
        }
    }
}
