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
using System.Globalization;

namespace ManagePatient
{
    public partial class frmMain : MetroForm
    {
        PatientBLL lstPatient = new PatientBLL();
        RoomBLL lstRoom = new RoomBLL();
        List<PatientInfo> listPatient = new List<PatientInfo>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Disable Field
            tbxIDPatient.Enabled = false;
            tbxNamePatient.Enabled = false;
            tbxPhone.Enabled = false;
            tbxEmail.Enabled = false;
            tbxAddress.Enabled = false;
            tbxDiagnoseill.Enabled = false;
            tbxIDRoom.Enabled = false;
            dtBirthday.Enabled = false;
            #endregion

            DisplayDataGridView(lstPatient.GetAllPatient().ToList());
            DisplayTreeview();
        }

        private void DisplayDataGridView(List<PatientInfo> lPatient)
        {
            this.dgvListPatient.ClearSelection();
            this.dgvListPatient.DataSource = lPatient;
            this.dgvListPatient.Columns[9].Visible = false;
        }

        private void DisplayTreeview()
        {
            this.tvListRoom.Nodes.Clear();
            foreach(var item in lstRoom.GetAllRoom())
            {
                TreeNode node = new TreeNode(item.NameRoom);
                node.Tag = item;
                this.tvListRoom.Nodes.Add(node);
            }
            this.tvListRoom.ExpandAll();
        }

        private void dgvListPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var item = dgvListPatient.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {
                var item = dgvListPatient.Rows[0].Cells[0].Value;
            }

            if (tbxIDPatient.DataBindings.Count > 0)
                tbxIDPatient.DataBindings.RemoveAt(0);
            if (tbxNamePatient.DataBindings.Count > 0)
                tbxNamePatient.DataBindings.RemoveAt(0);
            if (tbxPhone.DataBindings.Count > 0)
                tbxPhone.DataBindings.RemoveAt(0);
            if (tbxEmail.DataBindings.Count > 0)
                tbxEmail.DataBindings.RemoveAt(0);
            if (tbxAddress.DataBindings.Count > 0)
                tbxAddress.DataBindings.RemoveAt(0);
            if (tbxDiagnoseill.DataBindings.Count > 0)
                tbxDiagnoseill.DataBindings.RemoveAt(0);
            if (tbxIDRoom.DataBindings.Count > 0)
                tbxIDRoom.DataBindings.RemoveAt(0);

            try
            {
                tbxIDPatient.DataBindings.Add(new Binding("Text", dgvListPatient[0, e.RowIndex], "Value", false));
                tbxNamePatient.DataBindings.Add(new Binding("Text", dgvListPatient[1, e.RowIndex], "Value", false));
                tbxPhone.DataBindings.Add(new Binding("Text", dgvListPatient[2, e.RowIndex], "Value", false));
                tbxEmail.DataBindings.Add(new Binding("Text", dgvListPatient[3, e.RowIndex], "Value", false));
                tbxAddress.DataBindings.Add(new Binding("Text", dgvListPatient[4, e.RowIndex], "Value", false));
                tbxDiagnoseill.DataBindings.Add(new Binding("Text", dgvListPatient[5, e.RowIndex], "Value", false));
                tbxIDRoom.DataBindings.Add(new Binding("Text", dgvListPatient[6, e.RowIndex], "Value", false));

                var strDateTime = dgvListPatient.Rows[e.RowIndex].Cells[8].Value.ToString();
                string[] dateFmt = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                     "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                     "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                     "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                     "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};
                var dt = strDateTime.toDate(dateFmt);
                dtBirthday.Format = DateTimePickerFormat.Custom;
                dtBirthday.Value = DateTime.Parse(dt.ToString());

                if (dgvListPatient.Rows[e.RowIndex].Cells[7].Value.ToString() == "Man")
                {
                    radMale.Checked = true;
                    radFemale.Checked = false;
                }
                else
                {
                    radFemale.Checked = true;
                    radMale.Checked = false;
                }
            }
            catch {
            }
        }

        private void btnDelPatient_Click(object sender, EventArgs e)
        {
            lstPatient.Del1Patient(this.dgvListPatient.SelectedRows[0].Cells[0].Value.ToString());
            this.dgvListPatient.DataSource = lstPatient.GetAllPatient();
            frmMain_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            // If have change infomation
            try
            {
                if(this.tbxIDPatient.Enabled)
                {
                    PatientInfo patientInfo = new PatientInfo();
                    patientInfo.IDPatient = tbxIDPatient.Text;
                    patientInfo.NamePatient = tbxNamePatient.Text;
                    patientInfo.Phone = tbxPhone.Text;
                    patientInfo.Email = tbxEmail.Text;
                    patientInfo.Address = tbxAddress.Text;
                    patientInfo.Diagnoseill = tbxDiagnoseill.Text;
                    patientInfo.IDRoom = tbxIDRoom.Text;
                    if (this.radMale.Checked)
                        patientInfo.Sex = "Man";
                    else
                        patientInfo.Sex = "Woman";

                    patientInfo.DateOfBirth = this.dtBirthday.Value;

                    lstPatient.ChangeInfoPatient(patientInfo);
                }
                else
                {
                }
            }
            catch {
                
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if(tbxIDPatient.Text != "")
            {
                tbxIDPatient.Enabled = true;
                tbxNamePatient.Enabled = true;
                tbxPhone.Enabled = true;
                tbxEmail.Enabled = true;
                tbxAddress.Enabled = true;
                tbxDiagnoseill.Enabled = true;
                tbxIDRoom.Enabled = true;
                dtBirthday.Enabled = true;
            }
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa phòng sẽ xóa hết CSDL bệnh nhân trong phòng đó. Bạn có muốn tiếp tục?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                RoomInfo room = (RoomInfo)this.tvListRoom.SelectedNode.Tag;
                List<PatientInfo> lPatient = new List<PatientInfo>();
                lPatient = lstPatient.GetPatientById(room.IDRoom).ToList();
                foreach(var item in lPatient)
                {
                    lstPatient.Del1Patient(item.IDPatient);
                }
                lstRoom.Del1Room(room);
                if(lstRoom.GetAllRoom().Contains(room))
                {
                    MessageBox.Show("Failed");
                }
                else
                {
                    MessageBox.Show("Success");
                }
                frmMain_Load(sender, e);
            }
        }

        private void tvListRoom_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvListRoom.SelectedNode != null && this.tvListRoom.SelectedNode.Level >= 0)
            {
                try
                {
                    RoomInfo room = (RoomInfo)this.tvListRoom.SelectedNode.Tag;
                    List<PatientInfo> listPatient = new List<PatientInfo>();
                    listPatient = lstPatient.GetPatientById(room.IDRoom).ToList();
                    DisplayDataGridView(listPatient);
                }
                catch
                {
                }
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient frmAddPatient = new frmAddPatient();
            frmAddPatient.Show();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddRoom frmAddRoom = new frmAddRoom();
            frmAddRoom.Show();
        }
    }
    public static class Extensions
    {
        public static DateTime? toDate(this string dateTimeStr, string[] dateFmt)
        {
            // example: var dt = "2011-03-21 13:26".toDate(new string[]{"yyyy-MM-dd HH:mm", 
            //                                                  "M/d/yyyy h:mm:ss tt"});
            const DateTimeStyles style = DateTimeStyles.AllowWhiteSpaces;
            if (dateFmt == null)
            {
                var dateInfo = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat;
                dateFmt = dateInfo.GetAllDateTimePatterns();
            }
            DateTime? result = null;
            DateTime dt;
            if (DateTime.TryParseExact(dateTimeStr, dateFmt,
                CultureInfo.InvariantCulture, style, out dt)) result = dt;
            return result;
        }
        public static DateTime? toDate(this string dateTimeStr, string dateFmt = null)
        {
            // example: var dt="2011-03-21 13:26".toDate("yyyy-MM-dd HH:mm");
            // call overloaded function with string array param
            string[] dateFmtArr = dateFmt == null ? null : new string[] { dateFmt };
            return toDate(dateTimeStr, dateFmtArr);
        }
    }

}
