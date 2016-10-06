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

        public TemplateReader(DataGridView data)
        {
            this.templData = data;
            this.WorkerReportsProgress = true;
            this.DoWork += doWork;
        }

        private void doWork(object sender, DoWorkEventArgs e)
        {
            while (!this.CancellationPending)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (string file in Directory.GetFiles(Config.getInstance().ScanDirectory))
                {
                    if (Regex.Match(file, searchPattern, RegexOptions.IgnoreCase).Success)
                    {
                        IndexCreator idx = null;
                        bool abgemischt = false;
                        for (int i = 0; i < this.templData.Rows.Count && idx == null; i++)
                        {
                            if ((bool)this.templData.Rows[i].Cells["active"].Value)
                            {
                                int rnd = new Random().Next(000000001, 999999999);
                                Bitmap img = (Bitmap)Bitmap.FromFile(file);
                                if (this.readFile(img, i) != null)
                                {
                                    idx = this.readFile(img, i);
                                    idx.write(this.templData.Rows[i].Cells["output_directory"].Value.ToString(), rnd);
                                    TiffEncoder.Encode(idx.getFileName(rnd) + ".tiff", img);
                                    img.Dispose();
                                    abgemischt = true;
                                    break;
                                }
                            }
                        }
                        if (abgemischt)
                        {
                            File.Delete(file);
                        }
                        else
                        { 
                            if (Directory.Exists(Path.Combine(Config.getInstance().ScanDirectory,"nicht_abgemischt")))
                            {
                                File.Move(file, Path.Combine(Config.getInstance().ScanDirectory,"nicht_abgemischt"));
                            }
                            else 
                            {
                                Directory.CreateDirectory(Path.Combine(Config.getInstance().ScanDirectory,"nicht_abgemischt"));

                                File.Move(file, Path.Combine(Config.getInstance().ScanDirectory, "nicht_abgemischt") + Path.GetFileName(file));
                            }
                        }
                    }
                }
                sw.Stop();
                string interval = Config.getInstance().Interval;
                int hour = Convert.ToInt32(interval.Substring(0, interval.IndexOf(":")));
                int minute = Convert.ToInt32(interval.Substring(interval.IndexOf(":") + 1));
                int sleep = (((hour * 60) + minute) * 600);
                sleep -= (int)sw.ElapsedMilliseconds;
                Thread.Sleep(sleep);
            }
        }

        private IndexCreator readFile(Bitmap image, int rowIndex)
        {
            //Bitmap image = (Bitmap)Bitmap.FromFile(fileName);
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
            //ocr.ProgressEvent += Ocr_ProgressEvent;
            //ocr.OcrDone += Ocr_Done;
            Template tmpl = Template.getFromFile(this.getFileName(rowIndex));

            IndexCreator idxCreator = new IndexCreator();
            foreach (Index idx in tmpl.Index)
            {
                if (idx.Source.Equals("Statisch"))
                {
                    idxCreator.addValue(idx.Name, idx.Value);
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
                return idxCreator;
            }
            return null;
        }

        private string getSQLValue(string sql, IndexCreator idxCreator, DBType type)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            foreach (Match mat in Regex.Matches(sql, @"\§§\w+"))
            {
                string paramName = mat.Value.Replace("§§", "@");
                parameters.Add(paramName, this.getValueFromRect(idxCreator, paramName));
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
