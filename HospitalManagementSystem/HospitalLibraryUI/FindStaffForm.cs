using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;

namespace HospitalSystemUI
{
    public partial class FindStaff : Form
    {
        List<EmployeeModel> employee = new List<EmployeeModel>();

        public FindStaff()
        {
            InitializeComponent();
        }

        private void UpdateBindingEmployee()
        {
            employeesFoundLb.DataSource = employee;
            employeesFoundLb.DisplayMember = "FullEmployeeInfo";
        }

        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();

            if (String.IsNullOrEmpty(lastNameTb.Text))
            {
                MessageBox.Show("Please enter a last name to search for","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                employee = sql.GetEmployee(lastNameTb.Text);
                UpdateBindingEmployee();
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
