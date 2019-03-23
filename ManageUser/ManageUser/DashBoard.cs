using ManageUser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageUser
{
    public partial class DashBoard : Form
    {
        private Form1 MainWindow = new Form1();
        private PersonalInformation PersonalInformation;
        private ManageGroups ManageRoles;
        public DashBoard(Form1 MainWindow,UserLogin userLogin)
        {
            InitializeComponent();
            PersonalInformation = new PersonalInformation(userLogin);
            this.MainWindow = MainWindow;
            ManageRoles = new ManageGroups();
            this.btnCacLoaiNguoiDung.Click += BtnCacLoaiNguoiDung_Click;
            this.btnThongTinCaNhan.Click += BtnThongTinCaNhan_Click;
            BtnThongTinCaNhan_Click(null, null);
            this.FormClosed += DashBoard_FormClosed;
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.Close();
        }

        private void BtnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(PersonalInformation);
            ManageRoles.Hide();
            PersonalInformation.Show();
        }

        private void BtnCacLoaiNguoiDung_Click(object sender, EventArgs e)
        {
            PersonalInformation.Hide();
            pnlMain.Controls.Add(ManageRoles);
            ManageRoles.Show();
        }
    }
}
