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
            this.btn_ribbonOrb_exit = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab_general = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel_general = new System.Windows.Forms.RibbonPanel();
            this.btn_play = new System.Windows.Forms.RibbonButton();
            this.btn_stop = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_template = new System.Windows.Forms.RibbonPanel();
            this.template_save = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.template_plus = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.btn_move_up = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.btn_move_down = new System.Windows.Forms.RibbonButton();
            this.ribbonTab_properties = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_template = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_einstellungen = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton_save = new System.Windows.Forms.RibbonButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grp_box_status = new System.Windows.Forms.GroupBox();
            this.lbl_status_preview = new System.Windows.Forms.Label();
            this.pict_box_status = new System.Windows.Forms.PictureBox();
            this.lbl_status_template = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_templates = new System.Windows.Forms.DataGridView();
            this.Template = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_directory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabContr_settings = new System.Windows.Forms.TabControl();
            this.tabPage_generalSettings = new System.Windows.Forms.TabPage();
            this.grp_box_directory = new System.Windows.Forms.GroupBox();
            this.btn_directory = new System.Windows.Forms.Button();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.lbl_directory = new System.Windows.Forms.Label();
            this.grp_box_intervall = new System.Windows.Forms.GroupBox();
            this.lbl_intervall_expl = new System.Windows.Forms.Label();
            this.mtxt_intervall = new System.Windows.Forms.MaskedTextBox();
            this.lbl_intervall = new System.Windows.Forms.Label();
            this.tabPage_database = new System.Windows.Forms.TabPage();
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
            this.grp_mysql_habel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_mysql_habel_pass = new System.Windows.Forms.TextBox();
            this.txt_mysql_habel_user = new System.Windows.Forms.TextBox();
            this.txt_mysql_habel_database = new System.Windows.Forms.TextBox();
            this.lbl_mysql_habel_host = new System.Windows.Forms.Label();
            this.lbl_mysql_habel_pass = new System.Windows.Forms.Label();
            this.lbl_mysql_habel_database = new System.Windows.Forms.Label();
            this.lbl_mysql_habel_user = new System.Windows.Forms.Label();
            this.txt_mysql_habel_host = new System.Windows.Forms.TextBox();
            this.tabPage_pictureQuality = new System.Windows.Forms.TabPage();
            this.grp_pic_compression = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pic_dpi = new System.Windows.Forms.Label();
            this.trackBar_pic = new System.Windows.Forms.TrackBar();
            this.txt_pic_compression = new System.Windows.Forms.TextBox();
            this.grp_pic_res = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pic_dpi = new System.Windows.Forms.TextBox();
            this.grp_pic_resolution = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_pic_y = new System.Windows.Forms.TextBox();
            this.lbl_pix_x = new System.Windows.Forms.Label();
            this.lbl_piy_y = new System.Windows.Forms.Label();
            this.txt_pic_x = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pict_box_resize = new System.Windows.Forms.PictureBox();
            this.pict_box_exit = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grp_box_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box_status)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_templates)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabContr_settings.SuspendLayout();
            this.tabPage_generalSettings.SuspendLayout();
            this.grp_box_directory.SuspendLayout();
            this.grp_box_intervall.SuspendLayout();
            this.tabPage_database.SuspendLayout();
            this.grp_box_sql.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_mysql_habel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage_pictureQuality.SuspendLayout();
            this.grp_pic_compression.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pic)).BeginInit();
            this.grp_pic_res.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grp_pic_resolution.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box_resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\V-Modder\\Documents\\visual studio 2015\\Projects\\WindowsFormsApplication3\\" +
    "WindowsFormsApplication3";
            // 
            // ribbon1
            // 
            this.ribbon1.BorderMode = System.Windows.Forms.RibbonWindowMode.InsideWindow;
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
            this.ribbon1.OrbDropDown.OptionItems.Add(this.btn_ribbonOrb_exit);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = global::Belegleser.Properties.Resources.hardware_scanner1;
            this.ribbon1.OrbText = "";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.ribbonButton4);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1051, 162);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab_general);
            this.ribbon1.Tabs.Add(this.ribbonTab_properties);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Purple;
            this.ribbon1.DoubleClick += new System.EventHandler(this.ribbon1_DoubleClick);
            this.ribbon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ribbon1_MouseDown);
            this.ribbon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ribbon1_MouseMove);
            // 
            // btn_ribbonOrb_exit
            // 
            this.btn_ribbonOrb_exit.Image = global::Belegleser.Properties.Resources._20x2055x55appbar_door_leave;
            this.btn_ribbonOrb_exit.MaximumSize = new System.Drawing.Size(5, 5);
            this.btn_ribbonOrb_exit.SmallImage = global::Belegleser.Properties.Resources._20x2055x55appbar_door_leave;
            this.btn_ribbonOrb_exit.Text = "Beenden";
            this.btn_ribbonOrb_exit.Click += new System.EventHandler(this.btn_ribbonOrb_exit_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton4.Image = global::Belegleser.Properties.Resources._55x55appbar_app_plus;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Value = "test";
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
            this.ribbonPanel_general.Items.Add(this.btn_stop);
            this.ribbonPanel_general.Text = "Steuerung";
            // 
            // btn_play
            // 
            this.btn_play.Image = global::Belegleser.Properties.Resources._55x55appbar_control_play;
            this.btn_play.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_play.SmallImage")));
            this.btn_play.Text = "Start";
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = global::Belegleser.Properties.Resources._55x55appbar_control_stop;
            this.btn_stop.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.SmallImage")));
            this.btn_stop.Text = "Stopp";
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // ribbonPanel_template
            // 
            this.ribbonPanel_template.ButtonMoreVisible = false;
            this.ribbonPanel_template.Items.Add(this.template_save);
            this.ribbonPanel_template.Items.Add(this.ribbonSeparator3);
            this.ribbonPanel_template.Items.Add(this.template_plus);
            this.ribbonPanel_template.Items.Add(this.ribbonButton3);
            this.ribbonPanel_template.Items.Add(this.btn_move_up);
            this.ribbonPanel_template.Items.Add(this.btn_move_down);
            this.ribbonPanel_template.Text = "Template";
            // 
            // template_save
            // 
            this.template_save.DropDownItems.Add(this.ribbonSeparator1);
            this.template_save.DropDownItems.Add(this.ribbonSeparator2);
            this.template_save.Image = global::Belegleser.Properties.Resources._55x55appbar_disk;
            this.template_save.SmallImage = ((System.Drawing.Image)(resources.GetObject("template_save.SmallImage")));
            this.template_save.Text = "Speichern";
            this.template_save.Click += new System.EventHandler(this.template_save_Click);
            // 
            // template_plus
            // 
            this.template_plus.Image = global::Belegleser.Properties.Resources._55x55appbar_cell_insert_below;
            this.template_plus.SmallImage = ((System.Drawing.Image)(resources.GetObject("template_plus.SmallImage")));
            this.template_plus.Text = "Hinzufügen";
            this.template_plus.Click += new System.EventHandler(this.template_plus_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::Belegleser.Properties.Resources._55x55appbar_cell_row_delete;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Löschen";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // btn_move_up
            // 
            this.btn_move_up.DropDownItems.Add(this.ribbonButton1);
            this.btn_move_up.Image = global::Belegleser.Properties.Resources._55x55appbar_cell_up;
            this.btn_move_up.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_move_up.SmallImage")));
            this.btn_move_up.Text = "Nach oben";
            this.btn_move_up.Click += new System.EventHandler(this.btn_move_up_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // btn_move_down
            // 
            this.btn_move_down.Image = global::Belegleser.Properties.Resources._55x55appbar_cell_down;
            this.btn_move_down.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_move_down.SmallImage")));
            this.btn_move_down.Text = "Nach unten";
            this.btn_move_down.Click += new System.EventHandler(this.btn_move_down_Click);
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
            this.ribbonButton_template.Image = global::Belegleser.Properties.Resources._55x55appbar_page_edit;
            this.ribbonButton_template.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton_template.SmallImage")));
            this.ribbonButton_template.Text = "Editor";
            this.ribbonButton_template.Click += new System.EventHandler(this.ribbonButton_template_Click);
            // 
            // ribbonPanel_einstellungen
            // 
            this.ribbonPanel_einstellungen.ButtonMoreVisible = false;
            this.ribbonPanel_einstellungen.Items.Add(this.ribbonButton_save);
            this.ribbonPanel_einstellungen.Text = "Einstellungen";
            // 
            // ribbonButton_save
            // 
            this.ribbonButton_save.Image = global::Belegleser.Properties.Resources._55x55appbar_disk;
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
            this.tabPage1.Controls.Add(this.grp_box_status);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grp_box_status
            // 
            this.grp_box_status.Controls.Add(this.lbl_status_preview);
            this.grp_box_status.Controls.Add(this.pict_box_status);
            this.grp_box_status.Controls.Add(this.lbl_status_template);
            this.grp_box_status.Controls.Add(this.label2);
            this.grp_box_status.Controls.Add(this.progressBar_status);
            this.grp_box_status.Location = new System.Drawing.Point(6, 333);
            this.grp_box_status.Name = "grp_box_status";
            this.grp_box_status.Size = new System.Drawing.Size(1031, 328);
            this.grp_box_status.TabIndex = 3;
            this.grp_box_status.TabStop = false;
            this.grp_box_status.Text = "Status";
            // 
            // lbl_status_preview
            // 
            this.lbl_status_preview.AutoSize = true;
            this.lbl_status_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_preview.Location = new System.Drawing.Point(813, 40);
            this.lbl_status_preview.Name = "lbl_status_preview";
            this.lbl_status_preview.Size = new System.Drawing.Size(87, 16);
            this.lbl_status_preview.TabIndex = 6;
            this.lbl_status_preview.Text = "Vorschaubild";
            // 
            // pict_box_status
            // 
            this.pict_box_status.BackgroundImage = global::Belegleser.Properties.Resources.hardware_scanner_2;
            this.pict_box_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pict_box_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pict_box_status.InitialImage = global::Belegleser.Properties.Resources.load_graphic;
            this.pict_box_status.Location = new System.Drawing.Point(816, 66);
            this.pict_box_status.Name = "pict_box_status";
            this.pict_box_status.Size = new System.Drawing.Size(196, 244);
            this.pict_box_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pict_box_status.TabIndex = 5;
            this.pict_box_status.TabStop = false;
            // 
            // lbl_status_template
            // 
            this.lbl_status_template.AutoSize = true;
            this.lbl_status_template.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_template.Location = new System.Drawing.Point(142, 37);
            this.lbl_status_template.Name = "lbl_status_template";
            this.lbl_status_template.Size = new System.Drawing.Size(0, 16);
            this.lbl_status_template.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verarbeite gerade:";
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(18, 287);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(785, 23);
            this.progressBar_status.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtg_templates);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Templates";
            // 
            // dtg_templates
            // 
            this.dtg_templates.AllowUserToAddRows = false;
            this.dtg_templates.AllowUserToDeleteRows = false;
            this.dtg_templates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_templates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_templates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_templates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Template,
            this.output_directory,
            this.active});
            this.dtg_templates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_templates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtg_templates.Location = new System.Drawing.Point(6, 19);
            this.dtg_templates.MultiSelect = false;
            this.dtg_templates.Name = "dtg_templates";
            this.dtg_templates.RowHeadersVisible = false;
            this.dtg_templates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_templates.Size = new System.Drawing.Size(1019, 269);
            this.dtg_templates.TabIndex = 0;
            // 
            // Template
            // 
            this.Template.HeaderText = "Template";
            this.Template.Name = "Template";
            this.Template.Width = 76;
            // 
            // output_directory
            // 
            this.output_directory.HeaderText = "Ziel-Ordner";
            this.output_directory.Name = "output_directory";
            this.output_directory.Width = 84;
            // 
            // active
            // 
            this.active.HeaderText = "Aktiv";
            this.active.Name = "active";
            this.active.Width = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabContr_settings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabContr_settings
            // 
            this.tabContr_settings.Controls.Add(this.tabPage_generalSettings);
            this.tabContr_settings.Controls.Add(this.tabPage_database);
            this.tabContr_settings.Controls.Add(this.tabPage_pictureQuality);
            this.tabContr_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContr_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContr_settings.Location = new System.Drawing.Point(3, 3);
            this.tabContr_settings.Name = "tabContr_settings";
            this.tabContr_settings.SelectedIndex = 0;
            this.tabContr_settings.Size = new System.Drawing.Size(1037, 681);
            this.tabContr_settings.TabIndex = 6;
            // 
            // tabPage_generalSettings
            // 
            this.tabPage_generalSettings.Controls.Add(this.grp_box_directory);
            this.tabPage_generalSettings.Controls.Add(this.grp_box_intervall);
            this.tabPage_generalSettings.ImageKey = "cog";
            this.tabPage_generalSettings.Location = new System.Drawing.Point(4, 24);
            this.tabPage_generalSettings.Name = "tabPage_generalSettings";
            this.tabPage_generalSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_generalSettings.Size = new System.Drawing.Size(1029, 653);
            this.tabPage_generalSettings.TabIndex = 0;
            this.tabPage_generalSettings.Text = "Allgemeine Einstellungen";
            this.tabPage_generalSettings.UseVisualStyleBackColor = true;
            // 
            // grp_box_directory
            // 
            this.grp_box_directory.Controls.Add(this.btn_directory);
            this.grp_box_directory.Controls.Add(this.txt_directory);
            this.grp_box_directory.Controls.Add(this.lbl_directory);
            this.grp_box_directory.Location = new System.Drawing.Point(7, 6);
            this.grp_box_directory.Name = "grp_box_directory";
            this.grp_box_directory.Size = new System.Drawing.Size(566, 91);
            this.grp_box_directory.TabIndex = 0;
            this.grp_box_directory.TabStop = false;
            this.grp_box_directory.Text = "Scan Ordner (Polling)";
            // 
            // btn_directory
            // 
            this.btn_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_directory.Location = new System.Drawing.Point(473, 36);
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
            this.txt_directory.Size = new System.Drawing.Size(348, 22);
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
            // grp_box_intervall
            // 
            this.grp_box_intervall.Controls.Add(this.lbl_intervall_expl);
            this.grp_box_intervall.Controls.Add(this.mtxt_intervall);
            this.grp_box_intervall.Controls.Add(this.lbl_intervall);
            this.grp_box_intervall.Location = new System.Drawing.Point(6, 103);
            this.grp_box_intervall.Name = "grp_box_intervall";
            this.grp_box_intervall.Size = new System.Drawing.Size(567, 100);
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
            // tabPage_database
            // 
            this.tabPage_database.Controls.Add(this.grp_box_sql);
            this.tabPage_database.Controls.Add(this.grp_mysql_habel);
            this.tabPage_database.ImageKey = "sql";
            this.tabPage_database.Location = new System.Drawing.Point(4, 24);
            this.tabPage_database.Name = "tabPage_database";
            this.tabPage_database.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_database.Size = new System.Drawing.Size(1029, 653);
            this.tabPage_database.TabIndex = 1;
            this.tabPage_database.Text = "Datenbanken";
            this.tabPage_database.UseVisualStyleBackColor = true;
            // 
            // grp_box_sql
            // 
            this.grp_box_sql.Controls.Add(this.tableLayoutPanel1);
            this.grp_box_sql.Location = new System.Drawing.Point(6, 17);
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
            // grp_mysql_habel
            // 
            this.grp_mysql_habel.Controls.Add(this.tableLayoutPanel2);
            this.grp_mysql_habel.Location = new System.Drawing.Point(512, 17);
            this.grp_mysql_habel.Name = "grp_mysql_habel";
            this.grp_mysql_habel.Size = new System.Drawing.Size(460, 188);
            this.grp_mysql_habel.TabIndex = 5;
            this.grp_mysql_habel.TabStop = false;
            this.grp_mysql_habel.Text = "My -SQL-HABEL";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_mysql_habel_pass, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_mysql_habel_user, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_mysql_habel_database, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_mysql_habel_host, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_mysql_habel_pass, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_mysql_habel_database, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_mysql_habel_user, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_mysql_habel_host, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 118);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txt_mysql_habel_pass
            // 
            this.txt_mysql_habel_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mysql_habel_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysql_habel_pass.Location = new System.Drawing.Point(201, 93);
            this.txt_mysql_habel_pass.Name = "txt_mysql_habel_pass";
            this.txt_mysql_habel_pass.PasswordChar = '•';
            this.txt_mysql_habel_pass.Size = new System.Drawing.Size(192, 22);
            this.txt_mysql_habel_pass.TabIndex = 7;
            this.txt_mysql_habel_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_mysql_habel_user
            // 
            this.txt_mysql_habel_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mysql_habel_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysql_habel_user.Location = new System.Drawing.Point(201, 63);
            this.txt_mysql_habel_user.Name = "txt_mysql_habel_user";
            this.txt_mysql_habel_user.Size = new System.Drawing.Size(192, 22);
            this.txt_mysql_habel_user.TabIndex = 6;
            this.txt_mysql_habel_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_mysql_habel_database
            // 
            this.txt_mysql_habel_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mysql_habel_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysql_habel_database.Location = new System.Drawing.Point(201, 33);
            this.txt_mysql_habel_database.Name = "txt_mysql_habel_database";
            this.txt_mysql_habel_database.Size = new System.Drawing.Size(192, 22);
            this.txt_mysql_habel_database.TabIndex = 5;
            this.txt_mysql_habel_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_mysql_habel_host
            // 
            this.lbl_mysql_habel_host.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mysql_habel_host.AutoSize = true;
            this.lbl_mysql_habel_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mysql_habel_host.Location = new System.Drawing.Point(3, 0);
            this.lbl_mysql_habel_host.Name = "lbl_mysql_habel_host";
            this.lbl_mysql_habel_host.Size = new System.Drawing.Size(192, 30);
            this.lbl_mysql_habel_host.TabIndex = 0;
            this.lbl_mysql_habel_host.Text = "Host:";
            this.lbl_mysql_habel_host.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mysql_habel_pass
            // 
            this.lbl_mysql_habel_pass.AutoSize = true;
            this.lbl_mysql_habel_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_mysql_habel_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mysql_habel_pass.Location = new System.Drawing.Point(3, 90);
            this.lbl_mysql_habel_pass.Name = "lbl_mysql_habel_pass";
            this.lbl_mysql_habel_pass.Size = new System.Drawing.Size(192, 30);
            this.lbl_mysql_habel_pass.TabIndex = 3;
            this.lbl_mysql_habel_pass.Text = "Passwort:";
            this.lbl_mysql_habel_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mysql_habel_database
            // 
            this.lbl_mysql_habel_database.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mysql_habel_database.AutoSize = true;
            this.lbl_mysql_habel_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mysql_habel_database.Location = new System.Drawing.Point(3, 30);
            this.lbl_mysql_habel_database.Name = "lbl_mysql_habel_database";
            this.lbl_mysql_habel_database.Size = new System.Drawing.Size(192, 30);
            this.lbl_mysql_habel_database.TabIndex = 1;
            this.lbl_mysql_habel_database.Text = "Datenbank:";
            this.lbl_mysql_habel_database.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mysql_habel_user
            // 
            this.lbl_mysql_habel_user.AutoSize = true;
            this.lbl_mysql_habel_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_mysql_habel_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mysql_habel_user.Location = new System.Drawing.Point(3, 60);
            this.lbl_mysql_habel_user.Name = "lbl_mysql_habel_user";
            this.lbl_mysql_habel_user.Size = new System.Drawing.Size(192, 30);
            this.lbl_mysql_habel_user.TabIndex = 2;
            this.lbl_mysql_habel_user.Text = "Benutzer:";
            this.lbl_mysql_habel_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mysql_habel_host
            // 
            this.txt_mysql_habel_host.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mysql_habel_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mysql_habel_host.Location = new System.Drawing.Point(201, 3);
            this.txt_mysql_habel_host.Name = "txt_mysql_habel_host";
            this.txt_mysql_habel_host.Size = new System.Drawing.Size(192, 22);
            this.txt_mysql_habel_host.TabIndex = 4;
            this.txt_mysql_habel_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage_pictureQuality
            // 
            this.tabPage_pictureQuality.Controls.Add(this.grp_pic_compression);
            this.tabPage_pictureQuality.Controls.Add(this.grp_pic_res);
            this.tabPage_pictureQuality.Controls.Add(this.grp_pic_resolution);
            this.tabPage_pictureQuality.ImageKey = "picture";
            this.tabPage_pictureQuality.Location = new System.Drawing.Point(4, 24);
            this.tabPage_pictureQuality.Name = "tabPage_pictureQuality";
            this.tabPage_pictureQuality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_pictureQuality.Size = new System.Drawing.Size(1029, 653);
            this.tabPage_pictureQuality.TabIndex = 2;
            this.tabPage_pictureQuality.Text = "Bildqualität";
            this.tabPage_pictureQuality.UseVisualStyleBackColor = true;
            // 
            // grp_pic_compression
            // 
            this.grp_pic_compression.Controls.Add(this.tableLayoutPanel5);
            this.grp_pic_compression.Location = new System.Drawing.Point(6, 212);
            this.grp_pic_compression.Name = "grp_pic_compression";
            this.grp_pic_compression.Size = new System.Drawing.Size(486, 86);
            this.grp_pic_compression.TabIndex = 7;
            this.grp_pic_compression.TabStop = false;
            this.grp_pic_compression.Text = "Bild Auflösung";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.10227F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.89773F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_pic_dpi, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_pic, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_pic_compression, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(17, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 28);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // lbl_pic_dpi
            // 
            this.lbl_pic_dpi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pic_dpi.AutoSize = true;
            this.lbl_pic_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pic_dpi.Location = new System.Drawing.Point(3, 0);
            this.lbl_pic_dpi.Name = "lbl_pic_dpi";
            this.lbl_pic_dpi.Size = new System.Drawing.Size(170, 28);
            this.lbl_pic_dpi.TabIndex = 0;
            this.lbl_pic_dpi.Text = "JPEG Komprimierung:";
            this.lbl_pic_dpi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar_pic
            // 
            this.trackBar_pic.Location = new System.Drawing.Point(179, 3);
            this.trackBar_pic.Name = "trackBar_pic";
            this.trackBar_pic.Size = new System.Drawing.Size(126, 22);
            this.trackBar_pic.TabIndex = 1;
            this.trackBar_pic.TickFrequency = 5;
            this.trackBar_pic.Scroll += new System.EventHandler(this.trackBar_pic_Scroll);
            // 
            // txt_pic_compression
            // 
            this.txt_pic_compression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pic_compression.Location = new System.Drawing.Point(311, 3);
            this.txt_pic_compression.Name = "txt_pic_compression";
            this.txt_pic_compression.Size = new System.Drawing.Size(35, 22);
            this.txt_pic_compression.TabIndex = 2;
            this.txt_pic_compression.TextChanged += new System.EventHandler(this.txt_pic_compression_TextChanged);
            // 
            // grp_pic_res
            // 
            this.grp_pic_res.Controls.Add(this.tableLayoutPanel4);
            this.grp_pic_res.Location = new System.Drawing.Point(6, 108);
            this.grp_pic_res.Name = "grp_pic_res";
            this.grp_pic_res.Size = new System.Drawing.Size(486, 86);
            this.grp_pic_res.TabIndex = 6;
            this.grp_pic_res.TabStop = false;
            this.grp_pic_res.Text = "Bild Auflösung";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_pic_dpi, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(17, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(396, 28);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auflösung (DPI):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_pic_dpi
            // 
            this.txt_pic_dpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pic_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pic_dpi.Location = new System.Drawing.Point(201, 3);
            this.txt_pic_dpi.Name = "txt_pic_dpi";
            this.txt_pic_dpi.Size = new System.Drawing.Size(192, 22);
            this.txt_pic_dpi.TabIndex = 4;
            this.txt_pic_dpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grp_pic_resolution
            // 
            this.grp_pic_resolution.Controls.Add(this.tableLayoutPanel3);
            this.grp_pic_resolution.Location = new System.Drawing.Point(6, 6);
            this.grp_pic_resolution.Name = "grp_pic_resolution";
            this.grp_pic_resolution.Size = new System.Drawing.Size(486, 86);
            this.grp_pic_resolution.TabIndex = 0;
            this.grp_pic_resolution.TabStop = false;
            this.grp_pic_resolution.Text = "Bild Größe";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txt_pic_y, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_pix_x, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_piy_y, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_pic_x, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(396, 52);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txt_pic_y
            // 
            this.txt_pic_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pic_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pic_y.Location = new System.Drawing.Point(201, 29);
            this.txt_pic_y.Name = "txt_pic_y";
            this.txt_pic_y.Size = new System.Drawing.Size(192, 22);
            this.txt_pic_y.TabIndex = 5;
            this.txt_pic_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_pix_x
            // 
            this.lbl_pix_x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pix_x.AutoSize = true;
            this.lbl_pix_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pix_x.Location = new System.Drawing.Point(3, 0);
            this.lbl_pix_x.Name = "lbl_pix_x";
            this.lbl_pix_x.Size = new System.Drawing.Size(192, 26);
            this.lbl_pix_x.TabIndex = 0;
            this.lbl_pix_x.Text = "Breite:";
            this.lbl_pix_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_piy_y
            // 
            this.lbl_piy_y.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_piy_y.AutoSize = true;
            this.lbl_piy_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piy_y.Location = new System.Drawing.Point(3, 26);
            this.lbl_piy_y.Name = "lbl_piy_y";
            this.lbl_piy_y.Size = new System.Drawing.Size(192, 26);
            this.lbl_piy_y.TabIndex = 1;
            this.lbl_piy_y.Text = "Höhe:";
            this.lbl_piy_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_pic_x
            // 
            this.txt_pic_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pic_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pic_x.Location = new System.Drawing.Point(201, 3);
            this.txt_pic_x.Name = "txt_pic_x";
            this.txt_pic_x.Size = new System.Drawing.Size(192, 22);
            this.txt_pic_x.TabIndex = 4;
            this.txt_pic_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(489, 2);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 18);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "BelegLeser";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.DoubleClick += new System.EventHandler(this.ribbon1_DoubleClick);
            this.lbl_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ribbon1_MouseDown);
            this.lbl_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ribbon1_MouseMove);
            // 
            // pict_box_resize
            // 
            this.pict_box_resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pict_box_resize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pict_box_resize.Image = global::Belegleser.Properties.Resources._55x55appbar_app;
            this.pict_box_resize.Location = new System.Drawing.Point(968, 0);
            this.pict_box_resize.Margin = new System.Windows.Forms.Padding(0);
            this.pict_box_resize.Name = "pict_box_resize";
            this.pict_box_resize.Size = new System.Drawing.Size(38, 30);
            this.pict_box_resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_box_resize.TabIndex = 3;
            this.pict_box_resize.TabStop = false;
            this.pict_box_resize.Click += new System.EventHandler(this.pict_box_resize_Click);
            this.pict_box_resize.MouseEnter += new System.EventHandler(this.pict_box_resize_MouseHover);
            this.pict_box_resize.MouseLeave += new System.EventHandler(this.pict_box_resize_MouseLeave);
            // 
            // pict_box_exit
            // 
            this.pict_box_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pict_box_exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pict_box_exit.Image = global::Belegleser.Properties.Resources._55x55_exit;
            this.pict_box_exit.Location = new System.Drawing.Point(1006, 0);
            this.pict_box_exit.Margin = new System.Windows.Forms.Padding(0);
            this.pict_box_exit.Name = "pict_box_exit";
            this.pict_box_exit.Size = new System.Drawing.Size(45, 30);
            this.pict_box_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pict_box_exit.TabIndex = 4;
            this.pict_box_exit.TabStop = false;
            this.pict_box_exit.Click += new System.EventHandler(this.pict_box_exit_Click);
            this.pict_box_exit.MouseEnter += new System.EventHandler(this.pict_box_exit_MouseHover);
            this.pict_box_exit.MouseLeave += new System.EventHandler(this.pict_box_exit_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 856);
            this.Controls.Add(this.pict_box_exit);
            this.Controls.Add(this.pict_box_resize);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Belegleser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grp_box_status.ResumeLayout(false);
            this.grp_box_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box_status)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_templates)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabContr_settings.ResumeLayout(false);
            this.tabPage_generalSettings.ResumeLayout(false);
            this.grp_box_directory.ResumeLayout(false);
            this.grp_box_directory.PerformLayout();
            this.grp_box_intervall.ResumeLayout(false);
            this.grp_box_intervall.PerformLayout();
            this.tabPage_database.ResumeLayout(false);
            this.grp_box_sql.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grp_mysql_habel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage_pictureQuality.ResumeLayout(false);
            this.grp_pic_compression.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pic)).EndInit();
            this.grp_pic_res.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grp_pic_resolution.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box_resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_box_exit)).EndInit();
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
        private System.Windows.Forms.RibbonButton btn_stop;
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
        private System.Windows.Forms.GroupBox grp_mysql_habel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_mysql_habel_pass;
        private System.Windows.Forms.TextBox txt_mysql_habel_user;
        private System.Windows.Forms.TextBox txt_mysql_habel_database;
        private System.Windows.Forms.Label lbl_mysql_habel_host;
        private System.Windows.Forms.Label lbl_mysql_habel_pass;
        private System.Windows.Forms.Label lbl_mysql_habel_database;
        private System.Windows.Forms.Label lbl_mysql_habel_user;
        private System.Windows.Forms.TextBox txt_mysql_habel_host;
        private System.Windows.Forms.TabControl tabContr_settings;
        private System.Windows.Forms.TabPage tabPage_generalSettings;
        private System.Windows.Forms.TabPage tabPage_database;
        private System.Windows.Forms.TabPage tabPage_pictureQuality;
        private System.Windows.Forms.GroupBox grp_pic_resolution;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_pic_y;
        private System.Windows.Forms.Label lbl_pix_x;
        private System.Windows.Forms.Label lbl_piy_y;
        private System.Windows.Forms.TextBox txt_pic_x;
        private System.Windows.Forms.GroupBox grp_pic_compression;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_pic_dpi;
        private System.Windows.Forms.TrackBar trackBar_pic;
        private System.Windows.Forms.GroupBox grp_pic_res;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pic_dpi;
        private System.Windows.Forms.TextBox txt_pic_compression;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.GroupBox grp_box_status;
        private System.Windows.Forms.Label lbl_status_template;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pict_box_status;
        private System.Windows.Forms.Label lbl_status_preview;
        private System.Windows.Forms.RibbonButton btn_move_up;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton btn_move_down;
        private System.Windows.Forms.RibbonOrbOptionButton btn_ribbonOrb_exit;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pict_box_resize;
        private System.Windows.Forms.PictureBox pict_box_exit;
    }
}

