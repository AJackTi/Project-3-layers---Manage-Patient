using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Text.RegularExpressions;

namespace ManagePatient
{
    public partial class frmAddPatient : MetroForm
    {
        PatientBLL lstPatient = new PatientBLL();
        RoomBLL lstRoom = new RoomBLL();
        public string result = "";

        public frmAddPatient()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.tbxIDPatient.Clear();
            this.tbxNamePatient.Clear();
            this.tbxAddress.Clear();
            this.tbxDiagnoseill.Clear();
            this.tbxEmail.Clear();
            this.tbxPhone.Clear();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PatientInfo patientInfo = new PatientInfo();
            patientInfo.IDPatient = tbxIDPatient.Text;
            patientInfo.NamePatient = tbxNamePatient.Text;
            patientInfo.Phone = tbxPhone.Text;
            patientInfo.Email = tbxEmail.Text;
            patientInfo.Address = tbxAddress.Text;
            patientInfo.Diagnoseill = tbxDiagnoseill.Text;
            patientInfo.IDRoom = result;
            if (this.radMale.Checked)
                patientInfo.Sex = "Man";
            else
                patientInfo.Sex = "Woman";
            patientInfo.DateOfBirth = dtBirthday.Value;
            lstPatient.Add1Patient(patientInfo);
        }

        private void frmAddPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            this.cbxIDRoom.DataSource = lstRoom.GetAllNameRoom();
        }

        private void cbxIDRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in lstRoom.GetAllRoomDic())
            {
                if(item.Value == this.cbxIDRoom.SelectedItem.ToString())
                {
                    result = item.Key;
                    return;
                }
            }
        }

        private void CheckIDPatient(object sender, EventArgs e)
        {
            // Regex
            Regex pattern = new Regex("BN\\d{2}");
            if (pattern.IsMatch(tbxIDPatient.Text))
            {
                // TH Đúng
            }
            else
            {
                MessageBox.Show("Invalid input. ID Patient must begin with a character BN and 01-99");
                tbxIDPatient.Clear();
                return;
            }

            foreach(var item in lstPatient.GetAllPatient())
            {
                if(tbxIDPatient.Text == item.IDPatient)
                {
                    MessageBox.Show("tbxIDPatient and one of Patients exist in Database is coincident. Try again!!!");
                    this.tbxIDPatient.Clear();
                    return;
                }
            }
        }
    }
}
