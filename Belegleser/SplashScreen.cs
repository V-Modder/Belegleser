using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belegleser
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
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
                System.Threading.Thread.Sleep(30);
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
