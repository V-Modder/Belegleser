namespace Belegleser
{
    partial class CellEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellEdit));
            this.grp_box_edit = new System.Windows.Forms.GroupBox();
            this.txt_celledit = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grp_box_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_celledit)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_box_edit
            // 
            this.grp_box_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_box_edit.Controls.Add(this.txt_celledit);
            this.grp_box_edit.Location = new System.Drawing.Point(12, 12);
            this.grp_box_edit.Name = "grp_box_edit";
            this.grp_box_edit.Size = new System.Drawing.Size(674, 271);
            this.grp_box_edit.TabIndex = 1;
            this.grp_box_edit.TabStop = false;
            this.grp_box_edit.Text = "Zelle editieren";
            // 
            // txt_celledit
            // 
            this.txt_celledit.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txt_celledit.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.txt_celledit.BackBrush = null;
            this.txt_celledit.CharHeight = 14;
            this.txt_celledit.CharWidth = 8;
            this.txt_celledit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_celledit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_celledit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_celledit.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txt_celledit.IsReplaceMode = false;
            this.txt_celledit.Location = new System.Drawing.Point(3, 16);
            this.txt_celledit.Name = "txt_celledit";
            this.txt_celledit.Paddings = new System.Windows.Forms.Padding(0);
            this.txt_celledit.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txt_celledit.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txt_celledit.ServiceColors")));
            this.txt_celledit.Size = new System.Drawing.Size(668, 252);
            this.txt_celledit.TabIndex = 0;
            this.txt_celledit.Text = "fastColoredTextBox1";
            this.txt_celledit.Zoom = 100;
            // 
            // CellEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 295);
            this.Controls.Add(this.grp_box_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellEdit";
            this.ShowIcon = false;
            this.Text = "Zelle bearbeiten";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.CellEdit_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CellEdit_FormClosing);
            this.Load += new System.EventHandler(this.CellEdit_Load);
            this.grp_box_edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_celledit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_box_edit;
        private FastColoredTextBoxNS.FastColoredTextBox txt_celledit;
    }
}