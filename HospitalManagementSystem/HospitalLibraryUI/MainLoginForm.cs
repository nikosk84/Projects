using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;
using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void UserNameTb_TextChanged(object sender, EventArgs e)
        {
            userNameTb.MaxLength = 10;
            userNameTb.CharacterCasing = CharacterCasing.Lower;
            userNameTb.TextAlign = HorizontalAlignment.Center;
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            passwordTb.MaxLength = 20;
            passwordTb.CharacterCasing = CharacterCasing.Lower;
            passwordTb.TextAlign = HorizontalAlignment.Center;
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            //Not working

            SysUserModel sysUser = new SysUserModel
            {
                UserName = userNameTb.Text, Password = passwordTb.Text
            };

            foreach (IDataConnection connect in GlobalConfiguration.Connection)
            {
                connect.LogOn(sysUser);
            }

        }
    }
}
