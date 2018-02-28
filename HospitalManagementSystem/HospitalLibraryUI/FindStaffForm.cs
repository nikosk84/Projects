using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;

namespace HospitalSystemUI
{
    public partial class FindStaffForm : Form
    {
        List<EmployeeModel> employee = new List<EmployeeModel>();

        public FindStaffForm()
        {
            InitializeComponent();
        }

        private void UpdateBindingEmployee()
        {
            EmployeesFoundListBox.DataSource = employee;
            EmployeesFoundListBox.DisplayMember = "FullEmployeeInfo";
        }

        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();

            if (String.IsNullOrEmpty(LastNameText.Text))
            {
                MessageBox.Show("Please enter a last name to search for","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                employee = sql.GetEmployee(LastNameText.Text);
                UpdateBindingEmployee();
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
