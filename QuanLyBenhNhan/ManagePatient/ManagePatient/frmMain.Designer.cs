namespace ManagePatient
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvListRoom = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListPatient = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radFemale = new MetroFramework.Controls.MetroRadioButton();
            this.radMale = new MetroFramework.Controls.MetroRadioButton();
            this.dtBirthday = new MetroFramework.Controls.MetroDateTime();
            this.tbxPhone = new MetroFramework.Controls.MetroTextBox();
            this.tbxAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbxEmail = new MetroFramework.Controls.MetroTextBox();
            this.tbxIDRoom = new MetroFramework.Controls.MetroTextBox();
            this.tbxNamePatient = new MetroFramework.Controls.MetroTextBox();
            this.tbxDiagnoseill = new MetroFramework.Controls.MetroTextBox();
            this.tbxIDPatient = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnChangeInfo = new MetroFramework.Controls.MetroButton();
            this.btnDelPatient = new MetroFramework.Controls.MetroButton();
            this.btnAddPatient = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDelRoom = new MetroFramework.Controls.MetroButton();
            this.btnAddRoom = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatient)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvListRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Room";
            // 
            // tvListRoom
            // 
            this.tvListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvListRoom.ForeColor = System.Drawing.Color.Black;
            this.tvListRoom.Location = new System.Drawing.Point(3, 19);
            this.tvListRoom.Name = "tvListRoom";
            this.tvListRoom.Size = new System.Drawing.Size(201, 385);
            this.tvListRoom.TabIndex = 2;
            this.tvListRoom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvListRoom_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListPatient);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(213, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Patient";
            // 
            // dgvListPatient
            // 
            this.dgvListPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPatient.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListPatient.GridColor = System.Drawing.Color.Silver;
            this.dgvListPatient.Location = new System.Drawing.Point(3, 19);
            this.dgvListPatient.Name = "dgvListPatient";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPatient.Size = new System.Drawing.Size(779, 182);
            this.dgvListPatient.TabIndex = 0;
            this.dgvListPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPatient_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radFemale);
            this.groupBox3.Controls.Add(this.radMale);
            this.groupBox3.Controls.Add(this.dtBirthday);
            this.groupBox3.Controls.Add(this.tbxPhone);
            this.groupBox3.Controls.Add(this.tbxAddress);
            this.groupBox3.Controls.Add(this.tbxEmail);
            this.groupBox3.Controls.Add(this.tbxIDRoom);
            this.groupBox3.Controls.Add(this.tbxNamePatient);
            this.groupBox3.Controls.Add(this.tbxDiagnoseill);
            this.groupBox3.Controls.Add(this.tbxIDPatient);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(213, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 194);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail Information";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(572, 167);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(61, 15);
            this.radFemale.TabIndex = 3;
            this.radFemale.Text = "Female";
            this.radFemale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radFemale.UseSelectable = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(488, 167);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(49, 15);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radMale.UseSelectable = true;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(488, 125);
            this.dtBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(260, 29);
            this.dtBirthday.TabIndex = 2;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Lines = new string[0];
            this.tbxPhone.Location = new System.Drawing.Point(104, 137);
            this.tbxPhone.MaxLength = 32767;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.PasswordChar = '\0';
            this.tbxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPhone.SelectedText = "";
            this.tbxPhone.Size = new System.Drawing.Size(232, 23);
            this.tbxPhone.TabIndex = 1;
            this.tbxPhone.UseSelectable = true;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Lines = new string[0];
            this.tbxAddress.Location = new System.Drawing.Point(104, 100);
            this.tbxAddress.MaxLength = 32767;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PasswordChar = '\0';
            this.tbxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxAddress.SelectedText = "";
            this.tbxAddress.Size = new System.Drawing.Size(232, 23);
            this.tbxAddress.TabIndex = 1;
            this.tbxAddress.UseSelectable = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Lines = new string[0];
            this.tbxEmail.Location = new System.Drawing.Point(488, 88);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.Size = new System.Drawing.Size(260, 23);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.UseSelectable = true;
            // 
            // tbxIDRoom
            // 
            this.tbxIDRoom.Lines = new string[0];
            this.tbxIDRoom.Location = new System.Drawing.Point(488, 54);
            this.tbxIDRoom.MaxLength = 32767;
            this.tbxIDRoom.Name = "tbxIDRoom";
            this.tbxIDRoom.PasswordChar = '\0';
            this.tbxIDRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxIDRoom.SelectedText = "";
            this.tbxIDRoom.Size = new System.Drawing.Size(260, 23);
            this.tbxIDRoom.TabIndex = 1;
            this.tbxIDRoom.UseSelectable = true;
            // 
            // tbxNamePatient
            // 
            this.tbxNamePatient.Lines = new string[0];
            this.tbxNamePatient.Location = new System.Drawing.Point(104, 63);
            this.tbxNamePatient.MaxLength = 32767;
            this.tbxNamePatient.Name = "tbxNamePatient";
            this.tbxNamePatient.PasswordChar = '\0';
            this.tbxNamePatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxNamePatient.SelectedText = "";
            this.tbxNamePatient.Size = new System.Drawing.Size(232, 23);
            this.tbxNamePatient.TabIndex = 1;
            this.tbxNamePatient.UseSelectable = true;
            // 
            // tbxDiagnoseill
            // 
            this.tbxDiagnoseill.Lines = new string[0];
            this.tbxDiagnoseill.Location = new System.Drawing.Point(488, 20);
            this.tbxDiagnoseill.MaxLength = 32767;
            this.tbxDiagnoseill.Name = "tbxDiagnoseill";
            this.tbxDiagnoseill.PasswordChar = '\0';
            this.tbxDiagnoseill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxDiagnoseill.SelectedText = "";
            this.tbxDiagnoseill.Size = new System.Drawing.Size(260, 23);
            this.tbxDiagnoseill.TabIndex = 1;
            this.tbxDiagnoseill.UseSelectable = true;
            // 
            // tbxIDPatient
            // 
            this.tbxIDPatient.Lines = new string[0];
            this.tbxIDPatient.Location = new System.Drawing.Point(104, 26);
            this.tbxIDPatient.MaxLength = 32767;
            this.tbxIDPatient.Name = "tbxIDPatient";
            this.tbxIDPatient.PasswordChar = '\0';
            this.tbxIDPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxIDPatient.SelectedText = "";
            this.tbxIDPatient.Size = new System.Drawing.Size(232, 23);
            this.tbxIDPatient.TabIndex = 1;
            this.tbxIDPatient.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 141);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Phone";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Address";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(390, 92);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Email";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(390, 160);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(29, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Sex";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(390, 58);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "ID Room";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 67);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Name Patient";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(390, 126);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Birthday";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(390, 24);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Diagnoseill";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "ID Patient";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExit);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnChangeInfo);
            this.groupBox4.Controls.Add(this.btnDelPatient);
            this.groupBox4.Controls.Add(this.btnAddPatient);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(213, 491);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 55);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Function";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(642, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(483, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.BackColor = System.Drawing.Color.Silver;
            this.btnChangeInfo.Location = new System.Drawing.Point(324, 22);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(137, 23);
            this.btnChangeInfo.TabIndex = 0;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.UseSelectable = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // btnDelPatient
            // 
            this.btnDelPatient.BackColor = System.Drawing.Color.Silver;
            this.btnDelPatient.Location = new System.Drawing.Point(165, 22);
            this.btnDelPatient.Name = "btnDelPatient";
            this.btnDelPatient.Size = new System.Drawing.Size(137, 23);
            this.btnDelPatient.TabIndex = 0;
            this.btnDelPatient.Text = "Delete Patient";
            this.btnDelPatient.UseSelectable = true;
            this.btnDelPatient.Click += new System.EventHandler(this.btnDelPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.Silver;
            this.btnAddPatient.Location = new System.Drawing.Point(6, 22);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(137, 23);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseSelectable = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 31);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(971, 44);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(971, 44);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Manage Hospital Program";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelRoom);
            this.groupBox5.Controls.Add(this.btnAddRoom);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 491);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 55);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Function";
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.BackColor = System.Drawing.Color.Silver;
            this.btnDelRoom.Location = new System.Drawing.Point(109, 22);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(92, 23);
            this.btnDelRoom.TabIndex = 0;
            this.btnDelRoom.Text = "Delete Room";
            this.btnDelRoom.UseSelectable = true;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Silver;
            this.btnAddRoom.Location = new System.Drawing.Point(6, 22);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(92, 23);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseSelectable = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 553);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatient)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvListRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListPatient;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox tbxPhone;
        private MetroFramework.Controls.MetroTextBox tbxAddress;
        private MetroFramework.Controls.MetroTextBox tbxNamePatient;
        private MetroFramework.Controls.MetroTextBox tbxIDPatient;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbxIDRoom;
        private MetroFramework.Controls.MetroTextBox tbxDiagnoseill;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroRadioButton radFemale;
        private MetroFramework.Controls.MetroRadioButton radMale;
        private MetroFramework.Controls.MetroDateTime dtBirthday;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroButton btnDelRoom;
        private MetroFramework.Controls.MetroButton btnAddRoom;
        private MetroFramework.Controls.MetroTextBox tbxEmail;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnChangeInfo;
        private MetroFramework.Controls.MetroButton btnDelPatient;
        private MetroFramework.Controls.MetroButton btnAddPatient;
    }
}

