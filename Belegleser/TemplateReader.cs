using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using tessnet2;

namespace Belegleser
{
    class TemplateReader : BackgroundWorker
    {
        private string searchPattern = @"^.*\.(jpg|JPG|jpeg|JPEG)$";
        private DataGridView templData;
        private ProgressBar progressbar;
        private Label lbl_template;
        private PictureBox pict_box_status;

        public TemplateReader(DataGridView data, ProgressBar progressbar, Label lbl_template, PictureBox pict_box_status)
        {
            this.pict_box_status = pict_box_status;
            this.lbl_template = lbl_template;
            this.progressbar = progressbar;
            this.templData = data;
            this.WorkerReportsProgress = true;
            this.DoWork += doWork;
            this.WorkerSupportsCancellation = true;
        }

        private void doWork(object sender, DoWorkEventArgs e)
        {
            while (!this.CancellationPending)
            {
                this.progressbar.BeginInvoke(new Action(() =>
                    {
                    progressbar.Refresh();
                    progressbar.Value = 0;
                    string[] ext = { ".jpg", ".JPG", ".jpeg", ".JPEG" };
                    string[] countfile = Directory.GetFiles(Config.getInstance().ScanDirectory, "*.*")
                        .Where(f => ext.Contains(new FileInfo(f).Extension.ToLower())).ToArray();
                    progressbar.Maximum = countfile.Count();
                }));
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int fileCounter = 0;
                foreach (string file in Directory.GetFiles(Config.getInstance().ScanDirectory))
                {
                    if (this.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    if (Regex.Match(file, searchPattern, RegexOptions.IgnoreCase).Success)
                    {
                        IndexCreator idx = null;
                        bool abgemischt = false;
                        for (int i = 0; i < this.templData.Rows.Count && idx == null && !this.CancellationPending; i++)
                        {
                            bool tmp = this.templateWorker(idx, file, i);
                            if(tmp)
                            {
                                abgemischt = true;
                                break;
                            }
                        }
                        if (abgemischt)
                        {
                            try
                            {
                                //File.Delete(file);
                            }
                            catch
                            {
                                MessageBox.Show("Datei kann nicht gelöscht werden!");
                            }
                        }
                        else
                        {
                            continue;
                            //if (Directory.Exists(Path.Combine(Config.getInstance().ScanDirectory,"nicht_abgemischt")))
                            //{
                            //    File.Move(file, Path.Combine(Config.getInstance().ScanDirectory,"nicht_abgemischt"));
                            //}
                            //else 
                            //{
                            //    Directory.CreateDirectory(Path.Combine(Config.getInstance().ScanDirectory,"nicht_abgemischt"));

                            //    File.Move(file, Path.Combine(Config.getInstance().ScanDirectory, "nicht_abgemischt") + Path.GetFileName(file));
                            //}
                        }
                        this.ReportProgress(0, new WorkerStatusReport(++fileCounter, null, null));
                    }
                }
                GC.Collect();
                this.ReportProgress(0, new WorkerStatusReport(0, "", Properties.Resources.hardware_scanner_2));
                sw.Stop();
                string interval = Config.getInstance().Interval;
                int hour = Convert.ToInt32(interval.Substring(0, interval.IndexOf(":")));
                int minute = Convert.ToInt32(interval.Substring(interval.IndexOf(":") + 1));
                int sleep = (((hour * 60) + minute) * 60000);
                sleep -= (int)sw.ElapsedMilliseconds;
                Thread.Sleep(sleep);
            }
        }

        private bool templateWorker(IndexCreator idx, string file, int index)
        {
            bool abgemischt = false;

            if ((bool)this.templData.Rows[index].Cells["active"].Value)
            {
                this.ReportProgress(0, new WorkerStatusReport(null, this.templData.Rows[index].Cells[0].Value.ToString(), null));
                int rnd = new Random().Next(000000001, 999999999);
                Bitmap img = (Bitmap)Bitmap.FromFile(file);
                Bitmap img2 = new Bitmap(img);
                this.ReportProgress(0, new WorkerStatusReport(null, null, img2));
                if (this.readFile(img, index) != null)
                {
                    idx = this.readFile(img, index);
                    idx.write(this.templData.Rows[index].Cells["output_directory"].Value.ToString(), rnd);
                    TiffEncoder.Encode(idx.getFileName(rnd) + ".tiff", img);
                    img.Dispose();
                    abgemischt = true;
                }
                img.Dispose();
            }

            return abgemischt;
        }

        private IndexCreator readFile(Bitmap image, int rowIndex)
        {
            Tesseract ocr = new Tesseract();
            //ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only

            try
            {
                ocr.Init(null, "deu", false); // To use correct tessdata
            }
            catch (Exception ee)
            {
                throw ee;
            }
            Template tmpl = Template.getFromFile(this.getFileName(rowIndex));

            IndexCreator idxCreator = new IndexCreator();
            foreach (Index idx in tmpl.Index)
            {
                if (idx.Source.Equals("Statisch"))
                {
                    if (idx.Value.Contains("§§datenow"))
                    {
                        idxCreator.addValue(idx.Name, idx.Value.Replace("§§datenow", DateTime.Now.ToShortDateString()));
                    }
                    //else if (idx.Value == "")
                    //{
                    //    //Throw ne exeption when value == ""
                    //}
                    else
                    {
                        idxCreator.addValue(idx.Name, idx.Value);
                    }
                }
            }
            Area a = this.getIdentifyingRect(tmpl);
            Rectangle r = new Rectangle(a.X, a.Y, a.Width, a.Height);
            List<Word> result;
            result = ocr.DoOCR(image, r);
            bool found = false;
            foreach (Word word in result)
            {
                if (word.Text.Contains(a.IdentifyingWord))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                foreach (Area aa in tmpl.Reactangles)
                {
                    if (aa.IsIdentifying)
                    {
                        continue;
                    }
                    result = null;
                    result = ocr.DoOCR(image, this.getRect(aa));
                    aa.Value = this.getValue(result);
                }

                foreach (Index idx in tmpl.Index)
                {
                    if (!idx.Source.Equals("Statisch") && !(idx.Source.Equals("MsSQL") || idx.Source.Equals("MySQL")))
                    {
                        this.addValues(tmpl, idxCreator, idx);
                    }
                }
               
                foreach (Index idx in tmpl.Index)
                {
                    if (idx.Source.Equals("MsSQL"))
                    {
                        idxCreator.addValue(idx.Name, getSQLValue(idx.Value, idxCreator, DBType.MsSQL));
                    }
                    else if(idx.Source.Equals("MySQL"))
                    {
                        idxCreator.addValue(idx.Name, getSQLValue(idx.Value, idxCreator, DBType.MySQL));
                    }
                }
                ocr.Dispose();
                GC.Collect();
                return idxCreator;

            }
            ocr.Dispose();
            return null;
            
        }

        private string getSQLValue(string sql, IndexCreator idxCreator, DBType type)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            foreach (Match mat in Regex.Matches(sql, @"\§§\w+"))
            {
                string paramName = mat.Value.Replace("§§", "@");
                parameters.Add(paramName, this.getValueFromRect(idxCreator, paramName).Trim());
            }

            return Database.ExecuteQuery(sql.Replace("§§", "@"), parameters, type);
        }

        private string getValueFromRect(IndexCreator idxCreator, string name)
        {
            if(name.StartsWith("@"))
            {
                name = name.Substring(1);
            }

            return idxCreator.getValueByKey(name);
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


        private string getFileName(int index)
        {
            return this.templData.Rows[index].Cells["Template"].Value.ToString();
        }

        private void addValues(Template tmpl, IndexCreator idxc, Index idx)
        {
            string input = "";
            foreach (Area a in tmpl.Reactangles)
            {
                if (a.Name.Equals(idx.Source))
                {
                    input = a.Value;
                }
            }
            string value = "";
            Match mat = Regex.Match(input, idx.Value);
            if (mat.Success)
            {
                value = mat.Groups[1].Value;
            }
            idxc.addValue(idx.Name, value);
            return;
        }

        public void killworker()
        {
            this.CancelAsync();
            this.Dispose();
            GC.Collect();
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
                if(isFirst)
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

    }
}
