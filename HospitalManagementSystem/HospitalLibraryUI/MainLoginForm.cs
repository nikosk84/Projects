using HospitalLibrary.DataAccess;
using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void UserNameTb_TextChanged(object sender, EventArgs e)
        {
            UserNameText.MaxLength = 10;
            UserNameText.CharacterCasing = CharacterCasing.Lower;
            UserNameText.TextAlign = HorizontalAlignment.Center;
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            PasswordText.MaxLength = 20;
            PasswordText.CharacterCasing = CharacterCasing.Lower;
            PasswordText.TextAlign = HorizontalAlignment.Center;
        }

        private void MainLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();

            if (String.IsNullOrEmpty(UserNameText.Text))
            {
                MessageBox.Show("Please enter credentials", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sql.LogOn(UserNameText.Text, PasswordText.Text);
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                Hide();
            }
        }
    }
}
