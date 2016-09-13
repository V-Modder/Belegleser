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
            this.btn_load_picture = new System.Windows.Forms.ToolStripButton();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.btn_plus_rectangle = new System.Windows.Forms.ToolStripButton();
            this.btn_minus_rectangle = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pic_background = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_load_picture,
            this.btn_Save,
            this.btn_plus_rectangle,
            this.btn_minus_rectangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1207, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_load_picture
            // 
            this.btn_load_picture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_load_picture.Image = ((System.Drawing.Image)(resources.GetObject("btn_load_picture.Image")));
            this.btn_load_picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_load_picture.Name = "btn_load_picture";
            this.btn_load_picture.Size = new System.Drawing.Size(23, 22);
            this.btn_load_picture.Text = "toolStripButton1";
            this.btn_load_picture.Click += new System.EventHandler(this.btn_load_picture_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(23, 22);
            this.btn_Save.Text = "toolStripButton2";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_plus_rectangle
            // 
            this.btn_plus_rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_plus_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_plus_rectangle.Image")));
            this.btn_plus_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_plus_rectangle.Name = "btn_plus_rectangle";
            this.btn_plus_rectangle.Size = new System.Drawing.Size(23, 22);
            this.btn_plus_rectangle.Text = "toolStripButton2";
            this.btn_plus_rectangle.Click += new System.EventHandler(this.btn_plus_rectangle_Click);
            // 
            // btn_minus_rectangle
            // 
            this.btn_minus_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_minus_rectangle.Image")));
            this.btn_minus_rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_minus_rectangle.Name = "btn_minus_rectangle";
            this.btn_minus_rectangle.Size = new System.Drawing.Size(114, 22);
            this.btn_minus_rectangle.Text = "toolStripButton2";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pic_background);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 865);
            this.panel1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 545);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(402, 320);
            this.propertyGrid1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 186);
            this.listBox1.TabIndex = 3;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 865);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 4;
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 890);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "TemplateEditor";
            this.Text = "TemplateEditor";
            this.Load += new System.EventHandler(this.TemplateEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_background)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
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
    }
}