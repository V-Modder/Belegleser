using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Belegleser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.result = null;
            this.progressBar1.Value = 0;
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
            Bitmap image = (Bitmap)this.pictureBox1.Image.Clone();
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
            ocr.ProgressEvent += Ocr_ProgressEvent;
            ocr.OcrDone += Ocr_Done;
            Rectangle rect = new Rectangle(1455, 40, 625, 170);
            ocr.DoOCR(image, Rectangle.Empty);
            while (this.result == null)
            {
                Thread.Sleep(100);
            }
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
