using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Belegleser
{
    public partial class TemplateEditor : Form
    {
        private List<RectDataSet> rects;

        public TemplateEditor()
        {
            InitializeComponent();
        }

        private void TemplateEditor_Load(object sender, EventArgs e)
        {
            this.rects = new List<RectDataSet>();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private int rectangle = 0;

        private void btn_plus_rectangle_Click(object sender, EventArgs e)
        {
            rectangle ++;
            //SizeablePictureBox pb = new SizeablePictureBox();
            //pb.Click += new EventHandler(this.test);
            //pb.Height = 100;
            //pb.Width = 100;
            //pb.Top = 30;
            //pb.Left = 30;
            //pb.BackColor = Color.Transparent;
            //pb.Name = "rechteck_" + rectangle;
            //pic_background.Controls.Add(pb);
            RectDataSet rec = new RectDataSet(this.listBox1, this.propertyGrid1, this.pic_background, "rechteck_" + rectangle);
            this.rects.Add(rec);
        }

        protected void test(object sender, EventArgs e)
        {
        }

        private void btn_load_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image img = null;
                try
                {
                     img = Image.FromFile(dlg.FileName);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Die Datei konnte nicht gelesen werden\n" + ee.Message);
                }
                if (img != null)
                {
                    this.pic_background.Image = img;
                    this.pic_background.Size = img.Size;
                }
            }
        }
    }
}
