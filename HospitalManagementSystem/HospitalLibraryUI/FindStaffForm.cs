using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class FindStaff : Form
    {
        //Under construction

        public FindStaff()
        {
            InitializeComponent();
            UpdateBindingEmployee();
        }

        private void UpdateBindingEmployee()
        {
            employeesFoundLb.DisplayMember = "FullEmployeeInfo";
        }

        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTb.Text))
            {
                MessageBox.Show("Please enter a last name to search for","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UpdateBindingEmployee();
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
