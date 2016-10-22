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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_load = new System.Windows.Forms.ToolStripButton();
            this.btn_load_picture = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_plus_rectangle = new System.Windows.Forms.ToolStripButton();
            this.btn_minus_rectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_test_rectangle = new System.Windows.Forms.ToolStripButton();
            this.lbl_regex = new System.Windows.Forms.ToolStripLabel();
            this.txt_regex = new System.Windows.Forms.ToolStripTextBox();
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
            this.col_dotliquid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu_dtg_fields = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu_deleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu_editRow = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenu_dtg_fields.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_load,
            this.btn_load_picture,
            this.btn_Save,
            this.toolStripSeparator1,
            this.btn_plus_rectangle,
            this.btn_minus_rectangle,
            this.toolStripSeparator2,
            this.btn_test_rectangle,
            this.lbl_regex,
            this.txt_regex});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1207, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_load
            // 
            this.btn_load.Image = global::Belegleser.Properties.Resources._55x55appbar_folder_open;
            this.btn_load.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(92, 74);
            this.btn_load.Text = "Template laden";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_load_picture
            // 
            this.btn_load_picture.Image = global::Belegleser.Properties.Resources._55x55appbar_image;
            this.btn_load_picture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_load_picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_load_picture.Name = "btn_load_picture";
            this.btn_load_picture.Size = new System.Drawing.Size(74, 74);
            this.btn_load_picture.Text = "Grafik laden";
            this.btn_load_picture.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_load_picture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_load_picture.Click += new System.EventHandler(this.btn_load_picture_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Image = global::Belegleser.Properties.Resources._55x55appbar_disk;
            this.btn_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(63, 74);
            this.btn_Save.Text = "Speichern";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 77);
            // 
            // btn_plus_rectangle
            // 
            this.btn_plus_rectangle.Image = global::Belegleser.Properties.Resources._55x55appbar_app_plus;
            this.btn_plus_rectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_plus_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_plus_rectangle.Name = "btn_plus_rectangle";
            this.btn_plus_rectangle.Size = new System.Drawing.Size(113, 74);
            this.btn_plus_rectangle.Text = "Bereich hinzufügen";
            this.btn_plus_rectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_plus_rectangle.Click += new System.EventHandler(this.btn_plus_rectangle_Click);
            // 
            // btn_minus_rectangle
            // 
            this.btn_minus_rectangle.Image = global::Belegleser.Properties.Resources._55x55appbar_app_minus;
            this.btn_minus_rectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_minus_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_minus_rectangle.Name = "btn_minus_rectangle";
            this.btn_minus_rectangle.Size = new System.Drawing.Size(104, 74);
            this.btn_minus_rectangle.Text = "Bereich entfernen";
            this.btn_minus_rectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_minus_rectangle.Click += new System.EventHandler(this.btn_minus_rectangle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 77);
            // 
            // btn_test_rectangle
            // 
            this.btn_test_rectangle.Image = global::Belegleser.Properties.Resources._55x55appbar_bug;
            this.btn_test_rectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_test_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_test_rectangle.Name = "btn_test_rectangle";
            this.btn_test_rectangle.Size = new System.Drawing.Size(85, 74);
            this.btn_test_rectangle.Text = "Bereich testen";
            this.btn_test_rectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_test_rectangle.Click += new System.EventHandler(this.btn_test_rectangle_Click);
            // 
            // lbl_regex
            // 
            this.lbl_regex.Name = "lbl_regex";
            this.lbl_regex.Size = new System.Drawing.Size(41, 74);
            this.lbl_regex.Text = "Regex:";
            // 
            // txt_regex
            // 
            this.txt_regex.BackColor = System.Drawing.Color.Orange;
            this.txt_regex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regex.Name = "txt_regex";
            this.txt_regex.Size = new System.Drawing.Size(200, 77);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pic_background);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 811);
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 77);
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
            this.splitContainer1.Size = new System.Drawing.Size(1207, 813);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 811);
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
            this.col_value,
            this.col_dotliquid});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(336, 242);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // col_dotliquid
            // 
            this.col_dotliquid.HeaderText = "Dotliquid";
            this.col_dotliquid.Name = "col_dotliquid";
            // 
            // contextMenu_dtg_fields
            // 
            this.contextMenu_dtg_fields.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.toolStripSeparator3,
            this.toolStripMenu_deleteRow,
            this.toolStripMenu_editRow});
            this.contextMenu_dtg_fields.Name = "contextMenu_dtg_fields";
            this.contextMenu_dtg_fields.Size = new System.Drawing.Size(159, 98);
            this.contextMenu_dtg_fields.Text = "Index Felder ";
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(158, 22);
            this.edit.Text = "Bearbeiten:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripMenu_deleteRow
            // 
            this.toolStripMenu_deleteRow.Name = "toolStripMenu_deleteRow";
            this.toolStripMenu_deleteRow.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenu_deleteRow.Text = "Zeile löschen";
            this.toolStripMenu_deleteRow.Click += new System.EventHandler(this.toolStripMenu_deleteRow_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripMenu_editRow
            // 
            this.toolStripMenu_editRow.Name = "toolStripMenu_editRow";
            this.toolStripMenu_editRow.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenu_editRow.Text = "Zeile bearbeiten";
            this.toolStripMenu_editRow.Click += new System.EventHandler(this.toolStripMenu_editRow_Click);
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
            this.contextMenu_dtg_fields.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grp_list;
        private System.Windows.Forms.GroupBox grp_prop;
        private System.Windows.Forms.GroupBox grp_dagv;
        private System.Windows.Forms.ToolStripButton btn_load;
        private System.Windows.Forms.Button btn_habel_fields;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_test_rectangle;
        private System.Windows.Forms.ToolStripLabel lbl_regex;
        private System.Windows.Forms.ToolStripTextBox txt_regex;
        private System.Windows.Forms.ContextMenuStrip contextMenu_dtg_fields;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_deleteRow;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_source;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dotliquid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu_editRow;
    }
}