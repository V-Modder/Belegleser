using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Belegleser
{
    class RectDataSet
    {

        private ListBoxItem listItem;
        private SizeablePictureBox rect;
        private Rechteckeigenschaften properties;

        public RectDataSet(ListBox listBox, PropertyGrid grid, PictureBox pict, string name)
        {
            // Create listboxitem
            this.listItem = new ListBoxItem(name);
            listBox.Items.Add(this.listItem);
            listBox.SelectedIndexChanged += new EventHandler((sender, e) => ListBox_SelectedIndexChanged(sender, e, grid));

            // Create panel
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
            this.rect = new SizeablePictureBox(randomColor);
            this.rect.Click += new EventHandler((sender, e) => Rect_Click(sender, e, listBox, grid, pict));
            this.rect.Height = 100;
            this.rect.Width = 100;
            this.rect.Top = 30;
            this.rect.Left = 30;
            this.rect.BackColor = Color.Transparent;
            this.rect.Name = name;
            pict.Controls.Add(this.rect);
            this.rect.SizeChanged += Rect_SizeChanged;
            this.rect.LocationChanged += Rect_LocationChanged;

            // Create propertygrid
            this.properties = new Rechteckeigenschaften();
            this.properties.Name = name;
            this.properties.Location = this.rect.Location;
            this.properties.Size = this.rect.Size;
            this.properties.Color = this.rect.BorderColor;
            grid.SelectedObject = this.properties;
            grid.PropertyValueChanged += Grid_PropertyValueChanged;
        }

        private void Rect_Click(object sender, EventArgs e, ListBox listBox, PropertyGrid grid, PictureBox pict)
        {
            // Highlight the other controls
            grid.SelectedObject = this.properties;
            listBox.SelectedItem = this.listItem;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e, PropertyGrid grid)
        {
            ListBox box = (ListBox)sender;
            if (box.SelectedItem == this.listItem)
            {
                grid.SelectedObject = this.properties;
            }
        }

        private void Rect_LocationChanged(object sender, EventArgs e)
        {
            this.properties.Location = this.rect.Location;
        }

        private void Rect_SizeChanged(object sender, EventArgs e)
        {
            this.properties.Size = this.rect.Size;
        }

        public void Grid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.rect.Size = this.properties.Size;
            this.rect.Location = this.properties.Location;
            this.rect.BorderColor = this.properties.Color;
            this.rect.DrawBorder();
            this.listItem.Name = this.properties.Name;
        }

        public SizeablePictureBox Panel
        {
            get { return rect; }
            set { rect = value; }
        }

        public ListBoxItem ListItem
        {
            get { return listItem; }
            set { listItem = value; }
        }

        public Rechteckeigenschaften Properties
        {
            get { return properties; }
            set { properties = value; }
        }
    }
}
