using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;
using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class CreateEmployeeForm : Form
    {
        private string errorMsg = "Check field";

        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears windows form
        /// </summary>
        private void ClearAllFields()
        {
            foreach (int i in PositionsCheckedListBox.CheckedIndices)
            {
                PositionsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            FirstNameText.Text = String.Empty;
            LastNameText.Text = String.Empty;
            AddressText.Text = String.Empty;
            EmailText.Text = String.Empty;
            CellNoText.Text = String.Empty;
            PositionText.Text = String.Empty;
            PositionsCheckedListBox.SelectedIndex = -1;
            EmployeeFormValidator.Clear();
            FirstNameText.Focus();
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
                FirstName = FirstNameText.Text,
                LastName = LastNameText.Text,
                HomeAddress = AddressText.Text,
                EmailAddress = EmailText.Text,
                CellNumber = CellNoText.Text,
                Position = PositionText.Text
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
            if (PositionsCheckedListBox.CheckedItems.Count == 1)
            {
                PositionText.Text = PositionsCheckedListBox.SelectedItem.ToString();
            }
            else
            {
                PositionText.Text = String.Empty;
            }
        }

        /// <summary>
        /// Text field validations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameText.Text))
            {
                e.Cancel = true;
                EmployeeFormValidator.SetError(FirstNameText, errorMsg);
            }
        }

        private void LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastNameText.Text))
            {
                e.Cancel = true;
                EmployeeFormValidator.SetError(LastNameText, errorMsg);
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
            //To be fixed
        }
    }
}
