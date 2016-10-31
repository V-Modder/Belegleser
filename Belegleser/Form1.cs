using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using QLicense;
using Belegleser.License;

namespace Belegleser
{
    public partial class Form1 : Form
    {
        Template tmpl;
        public string scan_directory;
        public string sql_host;
        public string sql_instanz;
        public string sql_user;
        public string sql_password;
        public string intervall;

        MyLicense license = null;

        TemplateReader reader;

        private Point m_ClickPos;
        private Point m_WindowPos;

        //const and dll functions for moving form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1(MyLicense license)
        {
            this.license = license;
            InitializeComponent();
            ImageList imageList1 = new ImageList();
            imageList1.ImageSize = new Size(40, 40);
            imageList1.Images.Add("cog", Properties.Resources._55x55appbar_cog);
            imageList1.Images.Add("sql", Properties.Resources._55x55appbar_database_sql);
            imageList1.Images.Add("picture", Properties.Resources._55x55appbar_image);
            tabContr_settings.ImageList = imageList1;
            //ChangeTheme();
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
            btn_stop.Enabled = false;
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
            btn_stop.Enabled = true;
            btn_play.Enabled = false;
            this.reader = new TemplateReader(this.dtg_templates, this.progressBar_status, this.lbl_status_template, this.pict_box_status);
            this.reader.ProgressChanged += Reader_ProgressChanged;
            this.reader.RunWorkerAsync();
        }

        private void Reader_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            WorkerStatusReport report = (WorkerStatusReport)e.UserState;
            if(report.Progress != null)
            {
                this.progressBar_status.Value = (int)report.Progress;
            }
            if(report.Template != null)
            {
                this.lbl_status_template.Text = report.Template;
            }
            if (report.Image != null)
            {
                Image img = this.pict_box_status.BackgroundImage;
                this.pict_box_status.BackgroundImage = report.Image;
                if (img != null)
                {
                    img.Dispose();
                    img = null;
                }
            }
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

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.reader.CancelAsync();
            btn_play.Enabled = true;
            btn_stop.Enabled = false;
        }

        private void btn_move_up_Click(object sender, EventArgs e)
        {
            if (dtg_templates.SelectedCells.Count > 0)
            {
                int idx = dtg_templates.SelectedCells[0].OwningRow.Index;

                if (idx > 0)
                {
                    int col = dtg_templates.SelectedCells[0].OwningColumn.Index;

                    DataGridViewRowCollection rows = dtg_templates.Rows;
                    DataGridViewRow row = rows[idx];

                    rows.Remove(row);
                    rows.Insert(idx - 1, row);

                    dtg_templates.ClearSelection();

                    dtg_templates.Rows[idx - 1].Cells[col].Selected = true;
                }
            }
        }

        private void btn_move_down_Click(object sender, EventArgs e)
        {
            if (dtg_templates.SelectedCells.Count > 0 && dtg_templates.Rows.Count > 1 && (dtg_templates.CurrentRow.Index + 1) != dtg_templates.Rows.Count)
            {
                int idx = dtg_templates.SelectedCells[0].OwningRow.Index;

                if (idx < dtg_templates.Rows.Count)
                {
                    int col = dtg_templates.SelectedCells[0].OwningColumn.Index;

                    DataGridViewRowCollection rows = dtg_templates.Rows;
                    DataGridViewRow row = rows[idx];

                    rows.Remove(row);
                    rows.Insert(idx + 1, row);

                    dtg_templates.ClearSelection();

                    dtg_templates.Rows[idx + 1].Cells[col].Selected = true;
                }
            }
        }

        private void btn_ribbonOrb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ribbon1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            m_ClickPos = PointToScreen(e.Location);
            m_WindowPos = new Point(this.Location.X, this.Location.Y);
        }

        private void ribbon1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            var relativePoint = this.PointToClient(Cursor.Position);
            if (e.Button == MouseButtons.Left && relativePoint.Y < 35)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    double x = (double)this.m_ClickPos.X / (double)this.Width;
                    this.WindowState = FormWindowState.Normal;
                    double xx = Convert.ToInt32(Math.Round((this.Width * x), 0));
                    this.Location = new Point(this.m_ClickPos.X - Convert.ToInt32(Math.Round((this.Width * x), 0)), m_ClickPos.Y);
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pict_box_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Non Client area Buttons zustände
        private void pict_box_resize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                Screen scr = Screen.FromControl(this);
                this.MaximumSize = new Size(scr.WorkingArea.Width, scr.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pict_box_exit_MouseHover(object sender, EventArgs e)
        {
            pict_box_exit.Image = Properties.Resources._55x55_exit_white;
            pict_box_exit.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void pict_box_exit_MouseLeave(object sender, EventArgs e)
        {
            pict_box_exit.Image = Properties.Resources._55x55_exit;
            pict_box_exit.BackColor = Color.FromArgb(190, 208, 232);
        }

        private void pict_box_resize_MouseHover(object sender, EventArgs e)
        {
            pict_box_resize.BackColor = Color.FromArgb(174, 174, 174);
        }

        private void pict_box_resize_MouseLeave(object sender, EventArgs e)
        {
            pict_box_resize.BackColor = Color.FromArgb(190, 208, 232);
        }

        private void ribbon1_DoubleClick(object sender, EventArgs e)
        {
            this.pict_box_resize_Click(sender, e);
        }

        private void ChangeTheme()
        {
            Theme.ColorTable = new RribbonTheme();
            ribbon1.Refresh();
            this.Refresh();
        }

        private void ribbonOrbRecentItem1_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 2;
            licenseInfoControl1.ShowLicenseInfo(license);
        }

    }
}
