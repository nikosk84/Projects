using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;
using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class CreateEmployee : Form
    {
        private string errorMsg = "Check field";

        public CreateEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears windows form
        /// </summary>
        private void ClearAllFields()
        {
            foreach (int i in PositionsCheckedBox.CheckedIndices)
            {
                PositionsCheckedBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            firstName.Text = String.Empty;
            lastName.Text = String.Empty;
            address.Text = String.Empty;
            email.Text = String.Empty;
            cellNo.Text = String.Empty;
            position.Text = String.Empty;
            PositionsCheckedBox.SelectedIndex = -1;
            firstName.Focus();
        }

        /// <summary>
        /// Saves employee to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveRecordBtn_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = new EmployeeModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                HomeAddress = address.Text,
                EmailAddress = email.Text,
                CellNumber = cellNo.Text,
                Position = position.Text
            };

            foreach (IDataConnection connect in GlobalConfiguration.Connection)
            {
                connect.InsertEmployee(employee);
            }
        }

        /// <summary>
        /// Monitors ListBox selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PositionsCheckedLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositionsCheckedBox.CheckedItems.Count == 1)
            {
                position.Text = PositionsCheckedBox.SelectedItem.ToString();
            }
            else
            {
                position.Text = String.Empty;
            }
        }

        /// <summary>
        /// Text field validations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(firstName.Text))
            {
                e.Cancel = true;
                employeeFormValidator.SetError(firstName, errorMsg);
            }
        }

        private void LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lastName.Text))
            {
                e.Cancel = true;
                employeeFormValidator.SetError(lastName, errorMsg);
            }
        }

        /// <summary>
        /// Clear fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Exit this window and return to main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToMainBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
