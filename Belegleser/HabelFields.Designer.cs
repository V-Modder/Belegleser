namespace Belegleser
{
    partial class HabelFields
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
            this.dtg_habel_fields = new System.Windows.Forms.DataGridView();
            this.habel_fields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_habel_fields)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_habel_fields
            // 
            this.dtg_habel_fields.AllowUserToAddRows = false;
            this.dtg_habel_fields.AllowUserToDeleteRows = false;
            this.dtg_habel_fields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_habel_fields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_habel_fields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_habel_fields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.habel_fields});
            this.dtg_habel_fields.Location = new System.Drawing.Point(12, 6);
            this.dtg_habel_fields.Name = "dtg_habel_fields";
            this.dtg_habel_fields.ReadOnly = true;
            this.dtg_habel_fields.RowHeadersVisible = false;
            this.dtg_habel_fields.Size = new System.Drawing.Size(340, 451);
            this.dtg_habel_fields.TabIndex = 0;
            this.dtg_habel_fields.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_habel_fields_CellDoubleClick);
            // 
            // habel_fields
            // 
            this.habel_fields.HeaderText = "Verfügbare Habel Felder";
            this.habel_fields.Name = "habel_fields";
            this.habel_fields.ReadOnly = true;
            // 
            // HabelFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 469);
            this.Controls.Add(this.dtg_habel_fields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HabelFields";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verfügbare Felder";
            this.Load += new System.EventHandler(this.HabelFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_habel_fields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_habel_fields;
        private System.Windows.Forms.DataGridViewTextBoxColumn habel_fields;
    }
}