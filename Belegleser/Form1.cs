using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Belegleser
{
    public partial class Form1 : RibbonForm
    {
        Template tmpl;
        public string scan_directory;
        public string sql_host;
        public string sql_instanz;
        public string sql_user;
        public string sql_password;
        public string intervall;

        TemplateReader reader;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txt_directory.Clear();
            this.result = null;
            //this.progressBar1.Value = 0;
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
        }

        object result;

        private void ribbonTab_general_ActiveChanged(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 0;
        }

        private void ribbonTab_properties_ActiveChanged(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;
        }

        private void ribbonButton_template_Click(object sender, EventArgs e)
        {
            Form frm_template = new TemplateEditor();
            frm_template.ShowDialog();
        }

        private void btn_directory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();
            op.Description = "Scan ordner";
            DialogResult opresult = op.ShowDialog(this);
            if (opresult == DialogResult.OK)
            {
                this.txt_directory.Text = op.SelectedPath;
            }
        }

        private void ribbonButton_save_Click(object sender, EventArgs e)
        {
            Config.getInstance().ScanDirectory = txt_directory.Text;
            Config.getInstance().SQLHost = txt_sql_host.Text;
            Config.getInstance().SQLInstance = txt_sql_instanz.Text;
            Config.getInstance().SQLUser = txt_sql_user.Text;
            Config.getInstance().SQLPassword = txt_sql_password.Text;
            Config.getInstance().Interval = mtxt_intervall.Text;
            //MySQL
            Config.getInstance().MySQLHost = txt_mysql_habel_host.Text;
            Config.getInstance().MySQLDatabase = txt_mysql_habel_database.Text;
            Config.getInstance().MySQLUser = txt_mysql_habel_user.Text;
            Config.getInstance().MySQLPassword = txt_mysql_habel_pass.Text;
            //Bildqualität
            Config.getInstance().pic_width = txt_pic_x.Text;
            Config.getInstance().pic_height = txt_pic_y.Text;
            Config.getInstance().pic_dpi = txt_pic_dpi.Text;
            Config.getInstance().pic_quality = txt_pic_compression.Text;
            Config.getInstance().Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_directory.Text = Config.getInstance().ScanDirectory;
            txt_sql_host.Text = Config.getInstance().SQLHost;
            txt_sql_instanz.Text = Config.getInstance().SQLInstance;
            txt_sql_user.Text = Config.getInstance().SQLUser;
            txt_sql_password.Text = Config.getInstance().SQLPassword; //Verschlüsseln nur mit Base64
            mtxt_intervall.Text = Config.getInstance().Interval;
            //MySQL
            txt_mysql_habel_host.Text = Config.getInstance().MySQLHost;
            txt_mysql_habel_database.Text = Config.getInstance().MySQLDatabase;
            txt_mysql_habel_user.Text = Config.getInstance().MySQLUser;
            txt_mysql_habel_pass.Text = Config.getInstance().MySQLPassword;
            //
            //Bildqualiät
            txt_pic_x.Text = Config.getInstance().pic_width;
            txt_pic_y.Text = Config.getInstance().pic_height;
            txt_pic_dpi.Text = Config.getInstance().pic_dpi;
            txt_pic_compression.Text = Config.getInstance().pic_quality;
            //
            if (Config.getInstance().Templates != null)
            {
                foreach (SaveTemplateWork tmp in Config.getInstance().Templates)
                {
                    this.dtg_templates.Rows.Add(tmp.TemplatePath, tmp.OutputPath, tmp.Active);
                }
            }
            trackBar_pic.Maximum = 100;
            trackBar_pic.Minimum = 0;
            trackBar_pic.LargeChange = 5;
            trackBar_pic.SmallChange = 5;
        }

        private void template_plus_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.DefaultExt = "tpl";
            op.Title = "Bitte ein Template auswählen";
            if (op.ShowDialog() == DialogResult.OK)
            {
                dtg_templates.Rows.Add(op.FileName, "", false);
            }
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            dtg_templates.Rows.Remove(dtg_templates.CurrentRow);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            this.reader = new TemplateReader(this.dtg_templates);
            this.reader.RunWorkerAsync();
        }

        private void template_save_Click(object sender, EventArgs e)
        {
            dtg_templates.EndEdit();
            dtg_templates.Refresh();
            Config cfg = Config.getInstance();
            cfg.Templates = new List<SaveTemplateWork>();
            foreach (DataGridViewRow row in this.dtg_templates.Rows)
            {
                SaveTemplateWork tmp = new SaveTemplateWork();
                tmp.TemplatePath = row.Cells["Template"].Value.ToString();
                tmp.OutputPath = row.Cells["output_directory"].Value.ToString();
                tmp.Active = (bool)row.Cells["active"].Value;
                cfg.Templates.Add(tmp);
            }
            cfg.Save();
        }

        private void trackBar_pic_Scroll(object sender, EventArgs e)
        {
            txt_pic_compression.Text = trackBar_pic.Value.ToString();
        }

        private void txt_pic_compression_TextChanged(object sender, EventArgs e)
        {
            if (txt_pic_compression.Text != "")
            {
                trackBar_pic.Value = Convert.ToInt32(txt_pic_compression.Text);
            }
            else
            {
                trackBar_pic.Value = 0;
            }
        }
    }
}
