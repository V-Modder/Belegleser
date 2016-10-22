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
            this.txt_celledit = new System.Windows.Forms.TextBox();
            this.grp_box_edit = new System.Windows.Forms.GroupBox();
            this.grp_box_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_celledit
            // 
            this.txt_celledit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_celledit.Location = new System.Drawing.Point(3, 16);
            this.txt_celledit.Multiline = true;
            this.txt_celledit.Name = "txt_celledit";
            this.txt_celledit.Size = new System.Drawing.Size(668, 252);
            this.txt_celledit.TabIndex = 0;
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
            // CellEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 295);
            this.Controls.Add(this.grp_box_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellEdit";
            this.Text = "CellEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CellEdit_FormClosing);
            this.grp_box_edit.ResumeLayout(false);
            this.grp_box_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_celledit;
        private System.Windows.Forms.GroupBox grp_box_edit;
    }
}