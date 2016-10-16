using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Belegleser
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            lbl_files.Text = "DLL's werden überprüft...";
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(29, 31, 28);
            lbl_ver.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Opacity = 0;
            for (double cont = 0; cont <= 1; cont += 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                Thread.Sleep(40);
            }
            string error = "";
            //Überprüfen ob alle Dll's vorhanden sind
            List<string> checkfiles = new List<string>();
                checkfiles.Add("tessnet2_32.dll");
                checkfiles.Add("System.Windows.Forms.Ribbon35.dll");
                checkfiles.Add("MySql.Data.dll");
                checkfiles.Add("BitMiracle.LibTiff.NET.dll");
                checkfiles.Add("BitMiracle.LibTiff.NET.xml");
            Thread.Sleep(500);
            lbl_files.Text = "Sprachdateien werden überprüft...";
            //Tessdata Lang
                checkfiles.Add(@"tessdata\deu.DangAmbigs");
                checkfiles.Add(@"tessdata\deu.freq-dawg");
                checkfiles.Add(@"tessdata\deu.inttemp");
                checkfiles.Add(@"tessdata\deu.normproto");
                checkfiles.Add(@"tessdata\deu.pffmtable");
                checkfiles.Add(@"tessdata\deu.unicharset");
                checkfiles.Add(@"tessdata\deu.user-words");
                checkfiles.Add(@"tessdata\deu.word-dawg");
            foreach (string file in checkfiles)
            {
                if (!File.Exists(file))
                {
                    error += file.ToString() + Environment.NewLine;
                }
            }
            if (error.Length > 0)
            {
                MessageBox.Show("Es wurden benötigte Dateien nicht gefunden:\n\n" + error, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            tmr_screen.Start();
        }

        private void tmr_screen_Tick(object sender, EventArgs e)
        {
            this.Hide();
            tmr_screen.Stop();
            Form frm = new Form1();
            frm.Show();
        }

        private void pict_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pict_exit_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pict_exit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
