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
using Belegleser.License;
using QLicense;
using DemoWinFormApp;

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
                checkfiles.Add("DotLiquid.dll");
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
            MyLicense license = License();
            if (license != null)
            {
                Form frm = new Form1(license);
                frm.Show();
            }
            
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

        private MyLicense License()
        {
            //Initialize variables with default values
            MyLicense _lic = null;
            string _msg = string.Empty;
            LicenseStatus _status = LicenseStatus.UNDEFINED;

            byte[] _certPubicKeyData;
            //Read public key from assembly
            Assembly _assembly = Assembly.GetExecutingAssembly();
            using (MemoryStream _mem = new MemoryStream())
            {
                Stream stream = _assembly.GetManifestResourceStream("Belegleser.LicenseVerify.cer");
                if (stream != null)
                {
                    stream.CopyTo(_mem);
                }

                _certPubicKeyData = _mem.ToArray();
            }

            //Check if the XML license file exists
            if (File.Exists("license.lic"))
            {
                _lic = (MyLicense)LicenseHandler.ParseLicenseFromBASE64String(
                    typeof(MyLicense),
                    File.ReadAllText("license.lic"),
                    _certPubicKeyData,
                    out _status,
                    out _msg);
            }
            else
            {
                _status = LicenseStatus.INVALID;
                _msg = "Ihre Version ist nicht lizensiert";
            }

            switch (_status)
            {
                case LicenseStatus.VALID:

                    //TODO: If license is valid, you can do extra checking here
                    //TODO: E.g., check license expiry date if you have added expiry date property to your license entity
                    //TODO: Also, you can set feature switch here based on the different properties you added to your license entity 

                    //Here for demo, just show the license information and RETURN without additional checking       
                    //licInfo.ShowLicenseInfo(_lic);

                    return _lic;

                default:
                    //for the other status of license file, show the warning message
                    //and also popup the activation form for user to activate your application
                    MessageBox.Show(_msg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    using (frmActivation frm = new frmActivation())
                    {
                        frm.CertificatePublicKeyData = _certPubicKeyData;
                        frm.ShowDialog();

                        //Exit the application after activation to reload the license file 
                        //Actually it is not nessessary, you may just call the API to reload the license file
                        //Here just simplied the demo process
                        
                        Application.Exit();
                    }
                    break;
            }
            return null;
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
