using ManageUser.DAO;
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
    public partial class Form1 : Form
    {
        private DaoLogin daoLogin;
        public Form1()
        {
            InitializeComponent();
            txtMatKhau.Properties.PasswordChar = '*';
            daoLogin = new DaoLogin();
            UserLogin = new UserLogin();
        }
        public static UserLogin UserLogin { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if(daoLogin.CheckLogin(taiKhoan,matKhau))
            {
                UserLogin.UserName = taiKhoan;
                UserLogin.PassWord = matKhau;
                DashBoard dashBoard = new DashBoard(this,UserLogin);
                dashBoard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai thông tin", "Cảnh báo", MessageBoxButtons.OK);
            }
        }
    }
}
