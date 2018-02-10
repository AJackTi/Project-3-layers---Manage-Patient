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
    public partial class frmAddRoom : MetroForm
    {
        RoomBLL lstRoom = new RoomBLL();
        public frmAddRoom()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            RoomInfo roomInfo = new RoomInfo();
            roomInfo.IDRoom = tbxIDRoom.Text;
            roomInfo.NameRoom = tbxNameRoom.Text;
            roomInfo.CommentRoom = tbxCommentRoom.Text;
            lstRoom.Add1Room(roomInfo);
        }

        private void CheckIDRoom(object sender, EventArgs e)
        {
            Regex pattern = new Regex("[ABCD]\\d{1}");
            if (pattern.IsMatch(tbxIDRoom.Text))
            {
                // TH Đúng
            }
            else
            {
                MessageBox.Show("Invalid input. ID Room must begin with a character ABCD and 1-9");
                tbxIDRoom.Clear();
                return;
            }
            
            foreach(var item in lstRoom.GetAllRoom())
            {
                if(item.IDRoom == tbxIDRoom.Text)
                {
                    MessageBox.Show("tbxIDRoom and one of Rooms exist in Database is coincident. Try again!!!");
                    this.tbxIDRoom.Clear();
                    return;
                }
            }
        }
    }
}
