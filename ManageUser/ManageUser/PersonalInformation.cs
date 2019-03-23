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
    public partial class PersonalInformation : Form
    {
        private UserLogin userLogin;
        private DaoUser daoUser;
        public PersonalInformation(UserLogin userLogin)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.userLogin = userLogin;
            daoUser = new DaoUser();
            this.btnChangePassword.Click += BtnChangePassword_Click;
            this.txtMatKhauHienTai.Properties.PasswordChar = '*';
            this.txtMatKhauMoi.Properties.PasswordChar = '*';
            this.txtMatKhauMoiNhapLai.Properties.PasswordChar = '*';
            ShowListRolesToGrid();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            string taiKhoan = userLogin.UserName;
            string matKhauHienTai = txtMatKhauHienTai.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string matKhauMoiNhapLai = txtMatKhauMoiNhapLai.Text;
            if(matKhauMoi==matKhauMoiNhapLai)
            {
                if (ChangePassword(taiKhoan, matKhauHienTai, matKhauMoi))
                {

                }
                else
                {
                    MessageBox.Show("Thay đổi không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới nhập lại không trùng");
            }
        }

        private void ShowUserInformation(UserLogin userLogin)
        {
            lblTaiKhoan.Text = userLogin.UserName;
        }
        private bool ChangePassword(string userName,string matKhau, string matKhauMoi)
        {
           return daoUser.ChangePass(userName, matKhau, matKhauMoi);
        }
        private void ShowListRolesToGrid()
        {
            string idUser = daoUser.GetIdByUserName(userLogin.UserName);
            gridRoles.DataSource = daoUser.GetListRolesByIdUser(idUser);
        }
    }
}
