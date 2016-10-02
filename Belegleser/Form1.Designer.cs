namespace Belegleser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab_general = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel_general = new System.Windows.Forms.RibbonPanel();
            this.btn_play = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_template = new System.Windows.Forms.RibbonPanel();
            this.template_save = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.template_plus = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab_properties = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_template = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_einstellungen = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_save = new System.Windows.Forms.RibbonButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_templates = new System.Windows.Forms.DataGridView();
            this.Template = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_box_sql = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sql_password = new System.Windows.Forms.TextBox();
            this.txt_sql_user = new System.Windows.Forms.TextBox();
            this.txt_sql_instanz = new System.Windows.Forms.TextBox();
            this.lbl_sql_host = new System.Windows.Forms.Label();
            this.lbl_sql_password = new System.Windows.Forms.Label();
            this.lbl_sql_instanz = new System.Windows.Forms.Label();
            this.lbl_sql_Benutzer = new System.Windows.Forms.Label();
            this.txt_sql_host = new System.Windows.Forms.TextBox();
            this.grp_box_intervall = new System.Windows.Forms.GroupBox();
            this.lbl_intervall_expl = new System.Windows.Forms.Label();
            this.mtxt_intervall = new System.Windows.Forms.MaskedTextBox();
            this.lbl_intervall = new System.Windows.Forms.Label();
            this.grp_box_directory = new System.Windows.Forms.GroupBox();
            this.btn_directory = new System.Windows.Forms.Button();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.lbl_directory = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_templates)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grp_box_sql.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_box_intervall.SuspendLayout();
            this.grp_box_directory.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\V-Modder\\Documents\\visual studio 2015\\Projects\\WindowsFormsApplication3\\" +
    "WindowsFormsApplication3";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::Belegleser.Properties.Resources.hardware_scanner1;
            this.ribbon1.OrbText = "";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1051, 162);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab_general);
            this.ribbon1.Tabs.Add(this.ribbonTab_properties);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab_general
            // 
            this.ribbonTab_general.Panels.Add(this.ribbonPanel_general);
            this.ribbonTab_general.Panels.Add(this.ribbonPanel_template);
            this.ribbonTab_general.Text = "Allgemein";
            this.ribbonTab_general.ActiveChanged += new System.EventHandler(this.ribbonTab_general_ActiveChanged);
            // 
            // ribbonPanel_general
            // 
            this.ribbonPanel_general.ButtonMoreEnabled = false;
            this.ribbonPanel_general.ButtonMoreVisible = false;
            this.ribbonPanel_general.Items.Add(this.btn_play);
            this.ribbonPanel_general.Items.Add(this.ribbonButton1);
            this.ribbonPanel_general.Text = "Steuerung";
            // 
            // btn_play
            // 
            this.btn_play.Image = global::Belegleser.Properties.Resources.play;
            this.btn_play.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_play.SmallImage")));
            this.btn_play.Text = "Start";
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::Belegleser.Properties.Resources.stop;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Stopp";
            // 
            // ribbonPanel_template
            // 
            this.ribbonPanel_template.ButtonMoreVisible = false;
            this.ribbonPanel_template.Items.Add(this.template_save);
            this.ribbonPanel_template.Items.Add(this.ribbonSeparator3);
            this.ribbonPanel_template.Items.Add(this.template_plus);
            this.ribbonPanel_template.Items.Add(this.ribbonButton3);
            this.ribbonPanel_template.Text = "Template";
            // 
            // template_save
            // 
            this.template_save.DropDownItems.Add(this.ribbonSeparator1);
            this.template_save.DropDownItems.Add(this.ribbonSeparator2);
            this.template_save.Image = global::Belegleser.Properties.Resources.save;
            this.template_save.SmallImage = ((System.Drawing.Image)(resources.GetObject("template_save.SmallImage")));
            this.template_save.Text = "Speichern";
            // 
            // template_plus
            // 
            this.template_plus.Image = global::Belegleser.Properties.Resources.plus;
            this.template_plus.SmallImage = ((System.Drawing.Image)(resources.GetObject("template_plus.SmallImage")));
            this.template_plus.Text = "Hinzufügen";
            this.template_plus.Click += new System.EventHandler(this.template_plus_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::Belegleser.Properties.Resources.minus;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Löschen";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // ribbonTab_properties
            // 
            this.ribbonTab_properties.Panels.Add(this.ribbonPanel2);
            this.ribbonTab_properties.Panels.Add(this.ribbonPanel_einstellungen);
            this.ribbonTab_properties.Text = "Einstellungen";
            this.ribbonTab_properties.ActiveChanged += new System.EventHandler(this.ribbonTab_properties_ActiveChanged);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.ribbonButton_template);
            this.ribbonPanel2.Text = "Template";
            // 
            // ribbonButton_template
            // 
            this.ribbonButton_template.Image = global::Belegleser.Properties.Resources.template;
            this.ribbonButton_template.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_template.SmallImage")));
            this.ribbonButton_template.Text = "Editor";
            this.ribbonButton_template.Click += new System.EventHandler(this.ribbonButton_template_Click);
            // 
            // ribbonPanel_einstellungen
            // 
            this.ribbonPanel_einstellungen.Items.Add(this.ribbonButton_save);
            this.ribbonPanel_einstellungen.Text = "Einstellungen";
            // 
            // ribbonButton_save
            // 
            this.ribbonButton_save.Image = global::Belegleser.Properties.Resources.save;
            this.ribbonButton_save.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_save.SmallImage")));
            this.ribbonButton_save.Text = "Speichern";
            this.ribbonButton_save.Click += new System.EventHandler(this.ribbonButton_save_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 141);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1051, 713);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_templates);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtg_templates
            // 
            this.dtg_templates.AllowUserToAddRows = false;
            this.dtg_templates.AllowUserToDeleteRows = false;
            this.dtg_templates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_templates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Template,
            this.output_directory,
            this.active});
            this.dtg_templates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_templates.Location = new System.Drawing.Point(6, 19);
            this.dtg_templates.Name = "dtg_templates";
            this.dtg_templates.RowHeadersVisible = false;
            this.dtg_templates.Size = new System.Drawing.Size(367, 269);
            this.dtg_templates.TabIndex = 0;
            // 
            // Template
            // 
            this.Template.HeaderText = "Template";
            this.Template.Name = "Template";
            // 
            // output_directory
            // 
            this.output_directory.HeaderText = "Ziel-Ordner";
            this.output_directory.Name = "output_directory";
            // 
            // active
            // 
            this.active.HeaderText = "Aktiv";
            this.active.Name = "active";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grp_box_sql);
            this.tabPage2.Controls.Add(this.grp_box_intervall);
            this.tabPage2.Controls.Add(this.grp_box_directory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grp_box_sql
            // 
            this.grp_box_sql.Controls.Add(this.tableLayoutPanel1);
            this.grp_box_sql.Location = new System.Drawing.Point(9, 223);
            this.grp_box_sql.Name = "grp_box_sql";
            this.grp_box_sql.Size = new System.Drawing.Size(460, 188);
            this.grp_box_sql.TabIndex = 2;
            this.grp_box_sql.TabStop = false;
            this.grp_box_sql.Text = "MS -SQL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_sql_password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_sql_user, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_sql_instanz, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sql_host, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sql_password, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sql_instanz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_sql_Benutzer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_sql_host, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 118);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txt_sql_password
            // 
            this.txt_sql_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sql_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sql_password.Location = new System.Drawing.Point(201, 93);
            this.txt_sql_password.Name = "txt_sql_password";
            this.txt_sql_password.PasswordChar = '•';
            this.txt_sql_password.Size = new System.Drawing.Size(192, 22);
            this.txt_sql_password.TabIndex = 7;
            this.txt_sql_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sql_user
            // 
            this.txt_sql_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sql_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sql_user.Location = new System.Drawing.Point(201, 63);
            this.txt_sql_user.Name = "txt_sql_user";
            this.txt_sql_user.Size = new System.Drawing.Size(192, 22);
            this.txt_sql_user.TabIndex = 6;
            this.txt_sql_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sql_instanz
            // 
            this.txt_sql_instanz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sql_instanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sql_instanz.Location = new System.Drawing.Point(201, 33);
            this.txt_sql_instanz.Name = "txt_sql_instanz";
            this.txt_sql_instanz.Size = new System.Drawing.Size(192, 22);
            this.txt_sql_instanz.TabIndex = 5;
            this.txt_sql_instanz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_sql_host
            // 
            this.lbl_sql_host.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sql_host.AutoSize = true;
            this.lbl_sql_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sql_host.Location = new System.Drawing.Point(3, 0);
            this.lbl_sql_host.Name = "lbl_sql_host";
            this.lbl_sql_host.Size = new System.Drawing.Size(192, 30);
            this.lbl_sql_host.TabIndex = 0;
            this.lbl_sql_host.Text = "Host:";
            this.lbl_sql_host.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sql_password
            // 
            this.lbl_sql_password.AutoSize = true;
            this.lbl_sql_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sql_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sql_password.Location = new System.Drawing.Point(3, 90);
            this.lbl_sql_password.Name = "lbl_sql_password";
            this.lbl_sql_password.Size = new System.Drawing.Size(192, 30);
            this.lbl_sql_password.TabIndex = 3;
            this.lbl_sql_password.Text = "Passwort:";
            this.lbl_sql_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sql_instanz
            // 
            this.lbl_sql_instanz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sql_instanz.AutoSize = true;
            this.lbl_sql_instanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sql_instanz.Location = new System.Drawing.Point(3, 30);
            this.lbl_sql_instanz.Name = "lbl_sql_instanz";
            this.lbl_sql_instanz.Size = new System.Drawing.Size(192, 30);
            this.lbl_sql_instanz.TabIndex = 1;
            this.lbl_sql_instanz.Text = "Instanz:";
            this.lbl_sql_instanz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sql_Benutzer
            // 
            this.lbl_sql_Benutzer.AutoSize = true;
            this.lbl_sql_Benutzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sql_Benutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sql_Benutzer.Location = new System.Drawing.Point(3, 60);
            this.lbl_sql_Benutzer.Name = "lbl_sql_Benutzer";
            this.lbl_sql_Benutzer.Size = new System.Drawing.Size(192, 30);
            this.lbl_sql_Benutzer.TabIndex = 2;
            this.lbl_sql_Benutzer.Text = "Benutzer:";
            this.lbl_sql_Benutzer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sql_host
            // 
            this.txt_sql_host.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sql_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sql_host.Location = new System.Drawing.Point(201, 3);
            this.txt_sql_host.Name = "txt_sql_host";
            this.txt_sql_host.Size = new System.Drawing.Size(192, 22);
            this.txt_sql_host.TabIndex = 4;
            this.txt_sql_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grp_box_intervall
            // 
            this.grp_box_intervall.Controls.Add(this.lbl_intervall_expl);
            this.grp_box_intervall.Controls.Add(this.mtxt_intervall);
            this.grp_box_intervall.Controls.Add(this.lbl_intervall);
            this.grp_box_intervall.Location = new System.Drawing.Point(9, 117);
            this.grp_box_intervall.Name = "grp_box_intervall";
            this.grp_box_intervall.Size = new System.Drawing.Size(460, 100);
            this.grp_box_intervall.TabIndex = 1;
            this.grp_box_intervall.TabStop = false;
            this.grp_box_intervall.Text = "Intervall";
            // 
            // lbl_intervall_expl
            // 
            this.lbl_intervall_expl.AutoSize = true;
            this.lbl_intervall_expl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervall_expl.Location = new System.Drawing.Point(339, 45);
            this.lbl_intervall_expl.Name = "lbl_intervall_expl";
            this.lbl_intervall_expl.Size = new System.Drawing.Size(55, 16);
            this.lbl_intervall_expl.TabIndex = 2;
            this.lbl_intervall_expl.Text = "(hh:mm)";
            // 
            // mtxt_intervall
            // 
            this.mtxt_intervall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_intervall.Location = new System.Drawing.Point(107, 42);
            this.mtxt_intervall.Mask = "90:00";
            this.mtxt_intervall.Name = "mtxt_intervall";
            this.mtxt_intervall.Size = new System.Drawing.Size(226, 22);
            this.mtxt_intervall.TabIndex = 1;
            this.mtxt_intervall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxt_intervall.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_intervall
            // 
            this.lbl_intervall.AutoSize = true;
            this.lbl_intervall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervall.Location = new System.Drawing.Point(15, 45);
            this.lbl_intervall.Name = "lbl_intervall";
            this.lbl_intervall.Size = new System.Drawing.Size(54, 16);
            this.lbl_intervall.TabIndex = 0;
            this.lbl_intervall.Text = "Intervall";
            // 
            // grp_box_directory
            // 
            this.grp_box_directory.Controls.Add(this.btn_directory);
            this.grp_box_directory.Controls.Add(this.txt_directory);
            this.grp_box_directory.Controls.Add(this.lbl_directory);
            this.grp_box_directory.Location = new System.Drawing.Point(9, 20);
            this.grp_box_directory.Name = "grp_box_directory";
            this.grp_box_directory.Size = new System.Drawing.Size(460, 91);
            this.grp_box_directory.TabIndex = 0;
            this.grp_box_directory.TabStop = false;
            this.grp_box_directory.Text = "Scan Ordner";
            // 
            // btn_directory
            // 
            this.btn_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_directory.Location = new System.Drawing.Point(339, 37);
            this.btn_directory.Name = "btn_directory";
            this.btn_directory.Size = new System.Drawing.Size(75, 23);
            this.btn_directory.TabIndex = 2;
            this.btn_directory.Text = "---";
            this.btn_directory.UseVisualStyleBackColor = true;
            this.btn_directory.Click += new System.EventHandler(this.btn_directory_Click);
            // 
            // txt_directory
            // 
            this.txt_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_directory.Location = new System.Drawing.Point(107, 37);
            this.txt_directory.Name = "txt_directory";
            this.txt_directory.Size = new System.Drawing.Size(226, 22);
            this.txt_directory.TabIndex = 1;
            // 
            // lbl_directory
            // 
            this.lbl_directory.AutoSize = true;
            this.lbl_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directory.Location = new System.Drawing.Point(15, 40);
            this.lbl_directory.Name = "lbl_directory";
            this.lbl_directory.Size = new System.Drawing.Size(86, 16);
            this.lbl_directory.TabIndex = 0;
            this.lbl_directory.Text = "Scan Ordner:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 856);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Belegleser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_templates)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.grp_box_sql.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grp_box_intervall.ResumeLayout(false);
            this.grp_box_intervall.PerformLayout();
            this.grp_box_directory.ResumeLayout(false);
            this.grp_box_directory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab_general;
        private System.Windows.Forms.RibbonPanel ribbonPanel_general;
        private System.Windows.Forms.RibbonButton btn_play;
        private System.Windows.Forms.RibbonTab ribbonTab_properties;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RibbonButton ribbonButton_template;
        private System.Windows.Forms.GroupBox grp_box_directory;
        private System.Windows.Forms.Button btn_directory;
        private System.Windows.Forms.TextBox txt_directory;
        private System.Windows.Forms.Label lbl_directory;
        private System.Windows.Forms.RibbonPanel ribbonPanel_einstellungen;
        private System.Windows.Forms.RibbonButton ribbonButton_save;
        private System.Windows.Forms.GroupBox grp_box_sql;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_sql_password;
        private System.Windows.Forms.TextBox txt_sql_user;
        private System.Windows.Forms.TextBox txt_sql_instanz;
        private System.Windows.Forms.Label lbl_sql_host;
        private System.Windows.Forms.Label lbl_sql_password;
        private System.Windows.Forms.Label lbl_sql_instanz;
        private System.Windows.Forms.Label lbl_sql_Benutzer;
        private System.Windows.Forms.TextBox txt_sql_host;
        private System.Windows.Forms.GroupBox grp_box_intervall;
        private System.Windows.Forms.MaskedTextBox mtxt_intervall;
        private System.Windows.Forms.Label lbl_intervall;
        private System.Windows.Forms.Label lbl_intervall_expl;
        private System.Windows.Forms.RibbonPanel ribbonPanel_template;
        private System.Windows.Forms.RibbonButton template_save;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
        private System.Windows.Forms.RibbonButton template_plus;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_templates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Template;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_directory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
    }
}

