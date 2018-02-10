using HospitalLibrary.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        //TODO - REDO LOGIN

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (IDbConnection login = new System.Data.SqlClient.SqlConnection(GlobalConfiguration.ConnVal("HospitalStaffModelDB")))
            //    {
            //        {
            //            var result = login.QueryFirstOrDefault<SysUser>("spLogin", new { UserName = userNameTb.Text, Password = passwordTb.Text }, commandType: CommandType.StoredProcedure);
            //            if (result.UserName == userNameTb.Text && result.Password == passwordTb.Text)
            //            {
            //                login.Open();
            //                Hide();
            //                MainMenu mainLogin = new MainMenu();
            //                mainLogin.Show();
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Check username and password", "Login Error", MessageBoxButtons.OK);
            //}
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
    }
}
