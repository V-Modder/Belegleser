namespace Belegleser
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.tmr_screen = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pict_exit = new System.Windows.Forms.PictureBox();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_files = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_screen
            // 
            this.tmr_screen.Interval = 3000;
            this.tmr_screen.Tick += new System.EventHandler(this.tmr_screen_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 248);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "BelegLeser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "© 2016 Sebastian und Jannik. All Rights Reserved.";
            // 
            // pict_exit
            // 
            this.pict_exit.Image = global::Belegleser.Properties.Resources._55x55appbar_door_leave_white;
            this.pict_exit.Location = new System.Drawing.Point(466, -4);
            this.pict_exit.Name = "pict_exit";
            this.pict_exit.Size = new System.Drawing.Size(32, 35);
            this.pict_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_exit.TabIndex = 4;
            this.pict_exit.TabStop = false;
            this.pict_exit.Click += new System.EventHandler(this.pict_exit_Click);
            this.pict_exit.MouseLeave += new System.EventHandler(this.pict_exit_MouseLeave);
            this.pict_exit.MouseHover += new System.EventHandler(this.pict_exit_MouseHover);
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ver.Location = new System.Drawing.Point(51, 110);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(11, 14);
            this.lbl_ver.TabIndex = 5;
            this.lbl_ver.Text = ".";
            // 
            // lbl_files
            // 
            this.lbl_files.AutoSize = true;
            this.lbl_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_files.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_files.Location = new System.Drawing.Point(51, 187);
            this.lbl_files.Name = "lbl_files";
            this.lbl_files.Size = new System.Drawing.Size(66, 16);
            this.lbl_files.TabIndex = 6;
            this.lbl_files.Text = "lbl_datein";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 295);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_files);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.pict_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_screen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pict_exit;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_files;
    }
}