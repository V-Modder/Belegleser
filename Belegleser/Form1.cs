using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using tessnet2;

namespace Belegleser
{
    public partial class Form1 : Form
    {
        Template tmpl;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.result = null;
            this.progressBar1.Value = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "tpl";
            ofd.FileName = "Template_";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Template));
          
            using (StreamReader writer = new StreamReader(ofd.FileName))
            {
                this.tmpl = (Template)serializer.Deserialize(writer);
            }

            this.backgroundWorker1.RunWorkerAsync();
        }

        private void Ocr_ProgressEvent(int percent)
        {
            backgroundWorker1.ReportProgress(percent);
        }

        private void Ocr_Done(List<tessnet2.Word> words)
        {
            this.result = words;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form edit = new TemplateEditor();
            edit.ShowDialog();
            //if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
            //}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Bitmap image = (Bitmap)Bitmap.FromFile("Scan1018.jpg");
            tessnet2.Tesseract ocr = new tessnet2.Tesseract();
            //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
           
            try
            {
                ocr.Init(null, "deu", false); // To use correct tessdata
            }
            catch (Exception ee)
            {
                throw ee;
            }
            //ocr.ProgressEvent += Ocr_ProgressEvent;
            //ocr.OcrDone += Ocr_Done;

            IndexCreator idxCreator = new IndexCreator();
            foreach (Index idx in this.tmpl.Index)
            {
                if (idx.Source.Equals("Statisch"))
                {
                    idxCreator.addValue(idx.Name, idx.Value);
                }
            }
            Area a = this.getIdentifyingRect(this.tmpl);
            Rectangle r = new Rectangle(a.X, a.Y, a.Width, a.Height);
            this.result = ocr.DoOCR(image, r);
            bool found = false;
            foreach (Word word in (List<Word>)this.result)
            {
                if (word.Text.Contains(a.IdentifyingWord))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                foreach (Area aa in this.tmpl.Reactangles)
                {
                    if (aa.IsIdentifying)
                    {
                        continue;
                    }
                    this.result = null;
                    this.result = ocr.DoOCR(image, this.getRect(aa));
                    this.addValues(idxCreator, aa.Name, this.getValue((List<Word>)this.result));
                }

                //foreach (Index idx in this.tmpl.Index)
                //{
                //    if (idx.Source.Equals("SQL"))
                //    {
                //        idxCreator.addValue(idx.Name, getSQLValue());
                //    }
                //}

                idxCreator.write(Directory.GetCurrentDirectory());
                TiffEncoder.convert(image, idxCreator.getFileName() + ".tiff");
            }
        }

        private string getValue(List<Word> words)
        {
            int lines = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Word wrd in words)
            {
                if(wrd.LineIndex > lines)
                {
                    sb.Append(Environment.NewLine);
                    lines++;
                }
                sb.Append(wrd.Text);
            }

            return sb.ToString();
        } 

        private void addValues(IndexCreator idxc, string name, string input)
        {
            foreach (Index idx in this.tmpl.Index)
            {
                if (idx.Source.Equals(name))
                {
                    string value = Regex.Match(input, idx.Value).Value;
                    idxc.addValue(idx.Name, value);
                    return;
                }
            }
        }

        private Area getIdentifyingRect(Template tmpl)
        {
            foreach (Area a in tmpl.Reactangles)
            {
                if (a.IsIdentifying)
                {
                    return a;
                }
            }
            return null;
        }

        private Rectangle getRect(Area a)
        {
            return new Rectangle(a.X, a.Y, a.Width, a.Height);
        }

        object result;

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar1.Value = 100;
            foreach (tessnet2.Word word in (List <tessnet2.Word> )this.result)
            {
                this.textBox1.Text += string.Format("{0} : {1}", word.LineIndex, word.Text) + Environment.NewLine;
            }
        }
    }
}
