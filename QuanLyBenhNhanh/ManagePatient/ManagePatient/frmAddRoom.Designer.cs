namespace ManagePatient
{
    partial class frmAddRoom
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbxIDRoom = new MetroFramework.Controls.MetroTextBox();
            this.tbxNameRoom = new MetroFramework.Controls.MetroTextBox();
            this.tbxCommentRoom = new MetroFramework.Controls.MetroTextBox();
            this.btnAddRoom = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(2, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(433, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Add Room Program";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "ID Room";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Name Room";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Comment Room";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbxIDRoom
            // 
            this.tbxIDRoom.Lines = new string[0];
            this.tbxIDRoom.Location = new System.Drawing.Point(146, 60);
            this.tbxIDRoom.MaxLength = 32767;
            this.tbxIDRoom.Name = "tbxIDRoom";
            this.tbxIDRoom.PasswordChar = '\0';
            this.tbxIDRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxIDRoom.SelectedText = "";
            this.tbxIDRoom.Size = new System.Drawing.Size(268, 23);
            this.tbxIDRoom.TabIndex = 1;
            this.tbxIDRoom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxIDRoom.UseSelectable = true;
            this.tbxIDRoom.Validated += new System.EventHandler(this.CheckIDRoom);
            // 
            // tbxNameRoom
            // 
            this.tbxNameRoom.Lines = new string[0];
            this.tbxNameRoom.Location = new System.Drawing.Point(146, 99);
            this.tbxNameRoom.MaxLength = 32767;
            this.tbxNameRoom.Name = "tbxNameRoom";
            this.tbxNameRoom.PasswordChar = '\0';
            this.tbxNameRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxNameRoom.SelectedText = "";
            this.tbxNameRoom.Size = new System.Drawing.Size(268, 23);
            this.tbxNameRoom.TabIndex = 1;
            this.tbxNameRoom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxNameRoom.UseSelectable = true;
            // 
            // tbxCommentRoom
            // 
            this.tbxCommentRoom.Lines = new string[0];
            this.tbxCommentRoom.Location = new System.Drawing.Point(146, 137);
            this.tbxCommentRoom.MaxLength = 32767;
            this.tbxCommentRoom.Multiline = true;
            this.tbxCommentRoom.Name = "tbxCommentRoom";
            this.tbxCommentRoom.PasswordChar = '\0';
            this.tbxCommentRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCommentRoom.SelectedText = "";
            this.tbxCommentRoom.Size = new System.Drawing.Size(268, 56);
            this.tbxCommentRoom.TabIndex = 1;
            this.tbxCommentRoom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbxCommentRoom.UseSelectable = true;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(24, 209);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(113, 23);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddRoom.UseSelectable = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(301, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 256);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.tbxCommentRoom);
            this.Controls.Add(this.tbxNameRoom);
            this.Controls.Add(this.tbxIDRoom);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRoom";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoom_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbxIDRoom;
        private MetroFramework.Controls.MetroTextBox tbxNameRoom;
        private MetroFramework.Controls.MetroTextBox tbxCommentRoom;
        private MetroFramework.Controls.MetroButton btnAddRoom;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}