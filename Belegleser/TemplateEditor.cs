using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Belegleser
{
    public partial class TemplateEditor : Form
    {
        private List<RectDataSet> rects;
        private int rectangle = 0;

        public TemplateEditor()
        {
            InitializeComponent();
        }

        private void TemplateEditor_Load(object sender, EventArgs e)
        {
            this.rects = new List<RectDataSet>();
            this.splitContainer1.SplitterDistance = 351;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.DefaultExt = "tpl";
            ofd.FileName = "Template_";
            ofd.ShowDialog();

            Template tmpl = new Template();
            tmpl.Reactangles = new List<Area>();
            foreach (RectDataSet set in this.rects)
            {
                Area rect = new Area();
                rect.X = set.Properties.Location.X;
                rect.Y = set.Properties.Location.Y;
                rect.Width = set.Properties.Size.Width;
                rect.Height = set.Properties.Size.Height;
                rect.Name = set.Properties.Name;
                rect.Color = set.Properties.Color.ToArgb();
                rect.IsIdentifying = set.Properties.IsIdentifiying;
                rect.IdentifyingWord = set.Properties.IdentifiyingWord;
                tmpl.Reactangles.Add(rect);
            }
            tmpl.Index = new List<Index>();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Index idx = new Index();
                    idx.Name = row.Cells["col_name"].Value.ToString();
                    idx.Source = row.Cells["col_source"].Value.ToString();
                    if (row.Cells["col_value"].Value != null)
                    {
                        idx.Value = row.Cells["col_value"].Value.ToString();
                    }
                    else
                    {
                        idx.Value = "";
                    }
                    tmpl.Index.Add(idx);
                }
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Template));
            using (StreamWriter writer = new StreamWriter(ofd.FileName))
            {
                serializer.Serialize(writer, tmpl);
            }
        }

        private void btn_plus_rectangle_Click(object sender, EventArgs e)
        {
            rectangle++;
            RectDataSet rec = new RectDataSet(this.listBox1, this.propertyGrid1, this.pic_background, "rechteck_" + rectangle);
            this.rects.Add(rec);
            this.updateColumns();
        }

        private void updateColumns()
        {
            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["col_source"];
            col.Items.Clear();
            col.Items.Add("Statisch");

            foreach (ListBoxItem itm in this.listBox1.Items)
            {
                col.Items.Add(itm.Name);
            }
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

        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            this.grp_list.Width = splitContainer1.Panel1.Width - 2;
            this.grp_list.Height = (splitContainer1.Panel1.Height / 3) - 2;
            this.grp_prop.Width = splitContainer1.Panel1.Width - 2;
            this.grp_prop.Height = (splitContainer1.Panel1.Height / 3) - 2;
            this.grp_dagv.Size  = new Size(splitContainer1.Panel1.Width - 2, (splitContainer1.Panel1.Height / 3) - 2);
        }

        private void btn_minus_rectangle_Click(object sender, EventArgs e)
        {
            ListBoxItem itm = (ListBoxItem)this.listBox1.SelectedItem;
            RectDataSet selected = null;
            foreach (RectDataSet set in this.rects)
            {
                if (set.ListItem == itm)
                {
                    selected = set;
                    break;
                }
            }
            if (selected != null)
            {
                this.propertyGrid1.SelectedObject = null;
                this.pic_background.Controls.Remove(selected.Panel);
                this.listBox1.Items.Remove(selected.ListItem);
                this.rects.Remove(selected);
                this.updateDGV(selected.ListItem.Name);
                DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["col_source"];
                col.Items.Remove(selected.ListItem.Name);
                selected = null;
            }
        }

        private void updateDGV(string name)
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells["col_source"];
                if (cell != null && cell.Value != null && cell.Value.ToString() == name)
                {
                    row.Cells["col_source"].Value = null;
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "tpl";
            ofd.FileName = "Template_";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Template));
            Template tmpl = null;
            using (StreamReader writer = new StreamReader(ofd.FileName))
            {
                tmpl = (Template)serializer.Deserialize(writer);
            }
            rectangle++;
            foreach (Area a in tmpl.Reactangles)
            {
                RectDataSet rec = new RectDataSet(this.listBox1, this.propertyGrid1, this.pic_background, a.Name);
                this.listBox1.SelectedItem = rec.ListItem;
                rec.Properties.Color = Color.FromArgb(a.Color);
                rec.Properties.Location = new Point(a.X, a.Y);
                rec.Properties.Size = new Size(a.Width, a.Height);
                rec.Grid_PropertyValueChanged(this.propertyGrid1, new PropertyValueChangedEventArgs(null, null));
                rec.Properties.IsIdentifiying = a.IsIdentifying;
                rec.Properties.IdentifiyingWord = a.IdentifyingWord;
                this.rects.Add(rec);
            }

            this.updateColumns();

            foreach (Index idx in tmpl.Index)
            {
                dataGridView1.Rows.Add(idx.Name, idx.Source, idx.Value);
            }
        }
    }
}
