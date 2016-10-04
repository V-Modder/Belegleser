namespace Belegleser
{
    partial class TemplateEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_load = new System.Windows.Forms.ToolStripButton();
            this.btn_load_picture = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.btn_plus_rectangle = new System.Windows.Forms.ToolStripButton();
            this.btn_minus_rectangle = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_background = new System.Windows.Forms.PictureBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grp_list = new System.Windows.Forms.GroupBox();
            this.grp_prop = new System.Windows.Forms.GroupBox();
            this.grp_dagv = new System.Windows.Forms.GroupBox();
            this.btn_habel_fields = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_source = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grp_list.SuspendLayout();
            this.grp_prop.SuspendLayout();
            this.grp_dagv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_load,
            this.btn_load_picture,
            this.btn_Save,
            this.btn_plus_rectangle,
            this.btn_minus_rectangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1207, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_load
            // 
            this.btn_load.Image = global::Belegleser.Properties.Resources.load;
            this.btn_load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(92, 35);
            this.btn_load.Text = "Template laden";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_load_picture
            // 
            this.btn_load_picture.Image = global::Belegleser.Properties.Resources.load_graphic;
            this.btn_load_picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_load_picture.Name = "btn_load_picture";
            this.btn_load_picture.Size = new System.Drawing.Size(74, 35);
            this.btn_load_picture.Text = "Grafik laden";
            this.btn_load_picture.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_load_picture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_load_picture.Click += new System.EventHandler(this.btn_load_picture_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Image = global::Belegleser.Properties.Resources.save;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(63, 35);
            this.btn_Save.Text = "Speichern";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_plus_rectangle
            // 
            this.btn_plus_rectangle.Image = global::Belegleser.Properties.Resources.plus;
            this.btn_plus_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_plus_rectangle.Name = "btn_plus_rectangle";
            this.btn_plus_rectangle.Size = new System.Drawing.Size(113, 35);
            this.btn_plus_rectangle.Text = "Bereich hinzufügen";
            this.btn_plus_rectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_plus_rectangle.Click += new System.EventHandler(this.btn_plus_rectangle_Click);
            // 
            // btn_minus_rectangle
            // 
            this.btn_minus_rectangle.Image = global::Belegleser.Properties.Resources.minus;
            this.btn_minus_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_minus_rectangle.Name = "btn_minus_rectangle";
            this.btn_minus_rectangle.Size = new System.Drawing.Size(104, 35);
            this.btn_minus_rectangle.Text = "Bereich entfernen";
            this.btn_minus_rectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_minus_rectangle.Click += new System.EventHandler(this.btn_minus_rectangle_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pic_background);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 850);
            this.panel1.TabIndex = 1;
            // 
            // pic_background
            // 
            this.pic_background.Location = new System.Drawing.Point(1, 1);
            this.pic_background.Name = "pic_background";
            this.pic_background.Size = new System.Drawing.Size(404, 456);
            this.pic_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_background.TabIndex = 0;
            this.pic_background.TabStop = false;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(336, 210);
            this.propertyGrid1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 209);
            this.listBox1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 852);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.grp_list);
            this.flowLayoutPanel1.Controls.Add(this.grp_prop);
            this.flowLayoutPanel1.Controls.Add(this.grp_dagv);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 850);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // grp_list
            // 
            this.grp_list.Controls.Add(this.listBox1);
            this.grp_list.Location = new System.Drawing.Point(3, 3);
            this.grp_list.Name = "grp_list";
            this.grp_list.Size = new System.Drawing.Size(316, 228);
            this.grp_list.TabIndex = 0;
            this.grp_list.TabStop = false;
            this.grp_list.Text = "Bereiche";
            // 
            // grp_prop
            // 
            this.grp_prop.Controls.Add(this.propertyGrid1);
            this.grp_prop.Location = new System.Drawing.Point(3, 237);
            this.grp_prop.Name = "grp_prop";
            this.grp_prop.Size = new System.Drawing.Size(342, 229);
            this.grp_prop.TabIndex = 1;
            this.grp_prop.TabStop = false;
            this.grp_prop.Text = "Eigenschaften";
            // 
            // grp_dagv
            // 
            this.grp_dagv.Controls.Add(this.btn_habel_fields);
            this.grp_dagv.Controls.Add(this.dataGridView1);
            this.grp_dagv.Location = new System.Drawing.Point(3, 472);
            this.grp_dagv.Name = "grp_dagv";
            this.grp_dagv.Size = new System.Drawing.Size(342, 349);
            this.grp_dagv.TabIndex = 2;
            this.grp_dagv.TabStop = false;
            this.grp_dagv.Text = "Index Datei";
            // 
            // btn_habel_fields
            // 
            this.btn_habel_fields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_habel_fields.Location = new System.Drawing.Point(3, 295);
            this.btn_habel_fields.Name = "btn_habel_fields";
            this.btn_habel_fields.Size = new System.Drawing.Size(336, 51);
            this.btn_habel_fields.TabIndex = 5;
            this.btn_habel_fields.Text = "Verfügbare Felder";
            this.btn_habel_fields.UseVisualStyleBackColor = true;
            this.btn_habel_fields.Click += new System.EventHandler(this.btn_habel_fields_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_source,
            this.col_value});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(336, 273);
            this.dataGridView1.TabIndex = 4;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            // 
            // col_source
            // 
            this.col_source.HeaderText = "Herkunft";
            this.col_source.Items.AddRange(new object[] {
            "Statisch"});
            this.col_source.Name = "col_source";
            this.col_source.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_source.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_value
            // 
            this.col_value.HeaderText = "Wert";
            this.col_value.Name = "col_value";
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 890);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateEditor";
            this.Text = "TemplateEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TemplateEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grp_list.ResumeLayout(false);
            this.grp_prop.ResumeLayout(false);
            this.grp_dagv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_load_picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ToolStripButton btn_plus_rectangle;
        private System.Windows.Forms.ToolStripButton btn_minus_rectangle;
        private System.Windows.Forms.PictureBox pic_background;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_source;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
        private System.Windows.Forms.GroupBox grp_list;
        private System.Windows.Forms.GroupBox grp_prop;
        private System.Windows.Forms.GroupBox grp_dagv;
        private System.Windows.Forms.ToolStripButton btn_load;
        private System.Windows.Forms.Button btn_habel_fields;
    }
}