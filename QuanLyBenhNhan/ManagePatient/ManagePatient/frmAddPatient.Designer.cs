namespace ManagePatient
{
    partial class frmAddPatient
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxIDPatient = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbxNamePatient = new MetroFramework.Controls.MetroTextBox();
            this.tbxPhone = new MetroFramework.Controls.MetroTextBox();
            this.tbxEmail = new MetroFramework.Controls.MetroTextBox();
            this.tbxAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbxDiagnoseill = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.radMale = new MetroFramework.Controls.MetroRadioButton();
            this.radFemale = new MetroFramework.Controls.MetroRadioButton();
            this.dtBirthday = new MetroFramework.Controls.MetroDateTime();
            this.btnAddPatient = new MetroFramework.Controls.MetroButton();
            this.btnClearText = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.cbxIDRoom = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(440, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Add patient to Database";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbxIDPatient
            // 
            this.tbxIDPatient.Lines = new string[0];
            this.tbxIDPatient.Location = new System.Drawing.Point(156, 56);
            this.tbxIDPatient.MaxLength = 32767;
            this.tbxIDPatient.Name = "tbxIDPatient";
            this.tbxIDPatient.PasswordChar = '\0';
            this.tbxIDPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxIDPatient.SelectedText = "";
            this.tbxIDPatient.Size = new System.Drawing.Size(258, 23);
            this.tbxIDPatient.TabIndex = 1;
            this.tbxIDPatient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxIDPatient.UseSelectable = true;
            this.tbxIDPatient.Validated += new System.EventHandler(this.CheckIDPatient);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "ID Patient";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Name Patient";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 134);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Phone";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 171);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Email";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Address";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 245);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Diagnoseill";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbxNamePatient
            // 
            this.tbxNamePatient.Lines = new string[0];
            this.tbxNamePatient.Location = new System.Drawing.Point(156, 93);
            this.tbxNamePatient.MaxLength = 32767;
            this.tbxNamePatient.Name = "tbxNamePatient";
            this.tbxNamePatient.PasswordChar = '\0';
            this.tbxNamePatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxNamePatient.SelectedText = "";
            this.tbxNamePatient.Size = new System.Drawing.Size(258, 23);
            this.tbxNamePatient.TabIndex = 1;
            this.tbxNamePatient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxNamePatient.UseSelectable = true;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Lines = new string[0];
            this.tbxPhone.Location = new System.Drawing.Point(156, 130);
            this.tbxPhone.MaxLength = 32767;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.PasswordChar = '\0';
            this.tbxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPhone.SelectedText = "";
            this.tbxPhone.Size = new System.Drawing.Size(258, 23);
            this.tbxPhone.TabIndex = 1;
            this.tbxPhone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxPhone.UseSelectable = true;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Lines = new string[0];
            this.tbxEmail.Location = new System.Drawing.Point(156, 167);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.Size = new System.Drawing.Size(258, 23);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxEmail.UseSelectable = true;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Lines = new string[0];
            this.tbxAddress.Location = new System.Drawing.Point(156, 204);
            this.tbxAddress.MaxLength = 32767;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PasswordChar = '\0';
            this.tbxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxAddress.SelectedText = "";
            this.tbxAddress.Size = new System.Drawing.Size(258, 23);
            this.tbxAddress.TabIndex = 1;
            this.tbxAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxAddress.UseSelectable = true;
            // 
            // tbxDiagnoseill
            // 
            this.tbxDiagnoseill.Lines = new string[0];
            this.tbxDiagnoseill.Location = new System.Drawing.Point(156, 241);
            this.tbxDiagnoseill.MaxLength = 32767;
            this.tbxDiagnoseill.Name = "tbxDiagnoseill";
            this.tbxDiagnoseill.PasswordChar = '\0';
            this.tbxDiagnoseill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxDiagnoseill.SelectedText = "";
            this.tbxDiagnoseill.Size = new System.Drawing.Size(258, 23);
            this.tbxDiagnoseill.TabIndex = 1;
            this.tbxDiagnoseill.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxDiagnoseill.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 282);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Name Room";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 319);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(29, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Sex";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 356);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(115, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Datetime Birthday";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(156, 323);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 15);
            this.radMale.TabIndex = 2;
            this.radMale.TabStop = true;
            this.radMale.Text = "Man";
            this.radMale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radMale.UseSelectable = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(240, 323);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(65, 15);
            this.radFemale.TabIndex = 3;
            this.radFemale.Text = "Woman";
            this.radFemale.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radFemale.UseSelectable = true;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(156, 346);
            this.dtBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(258, 29);
            this.dtBirthday.TabIndex = 4;
            this.dtBirthday.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(23, 392);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(102, 23);
            this.btnAddPatient.TabIndex = 5;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseSelectable = true;
            this.btnAddPatient.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(169, 392);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(102, 23);
            this.btnClearText.TabIndex = 5;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.UseSelectable = true;
            this.btnClearText.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(315, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // cbxIDRoom
            // 
            this.cbxIDRoom.FormattingEnabled = true;
            this.cbxIDRoom.ItemHeight = 23;
            this.cbxIDRoom.Location = new System.Drawing.Point(156, 272);
            this.cbxIDRoom.Name = "cbxIDRoom";
            this.cbxIDRoom.Size = new System.Drawing.Size(258, 29);
            this.cbxIDRoom.TabIndex = 6;
            this.cbxIDRoom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxIDRoom.UseSelectable = true;
            this.cbxIDRoom.SelectedIndexChanged += new System.EventHandler(this.cbxIDRoom_SelectedIndexChanged);
            // 
            // frmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 438);
            this.Controls.Add(this.cbxIDRoom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.tbxDiagnoseill);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxNamePatient);
            this.Controls.Add(this.tbxIDPatient);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPatient";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddPatient_FormClosing);
            this.Load += new System.EventHandler(this.frmAddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxIDPatient;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbxNamePatient;
        private MetroFramework.Controls.MetroTextBox tbxPhone;
        private MetroFramework.Controls.MetroTextBox tbxEmail;
        private MetroFramework.Controls.MetroTextBox tbxAddress;
        private MetroFramework.Controls.MetroTextBox tbxDiagnoseill;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroRadioButton radMale;
        private MetroFramework.Controls.MetroRadioButton radFemale;
        private MetroFramework.Controls.MetroDateTime dtBirthday;
        private MetroFramework.Controls.MetroButton btnAddPatient;
        private MetroFramework.Controls.MetroButton btnClearText;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroComboBox cbxIDRoom;
    }
}