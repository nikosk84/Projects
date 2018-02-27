using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;
using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    //TODO - Check for nulls
    //TODO - Text field validation

    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

        private string errorMessage = "Check Fields";

        /// <summary>
        /// Clears all fields on form
        /// </summary>
        private void ClearAllFields()
        {
            firstName.Text = "";
            lastName.Text = "";
            address.Text = "";
            genderComboBox.SelectedIndex = -1;
            consultingDoctor.Text = "";
            ward.Text = "";
            roomNo.Text = "";
            bedNo.Text = "";
            yesCheckBox.Checked = false;
            firstName.Focus();
        }

        /// <summary>
        /// CheckBox validation
        /// </summary>
        /// <returns></returns>
        private bool ValidateCheckBox()
        {
            if (yesCheckBox.CheckState == CheckState.Checked)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// ComboBox validation for gender
        /// </summary>
        /// <returns></returns>
        private bool ValidateComboBox()
        {
            if (genderComboBox.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Save record button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePatientBtn_Click(object sender, EventArgs e)
        {
            PatientModel patient = new PatientModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                HomeAddress = address.Text,
                Gender = genderComboBox.Text,
                ConsultingDoctor = consultingDoctor.Text,
                Ward = ward.Text,
                RoomNumber = roomNo.Text,
                BedNumber = bedNo.Text,
                HasHealthCard = yesCheckBox.Text 
            };

            if (ValidateCheckBox() && ValidateComboBox())
            {
                foreach (IDataConnection connect in GlobalConfiguration.Connection)
                {
                    connect.InsertPatient(patient);
                }
            }
            else
            {
                MessageBox.Show("Please check fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Form text field validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePatient_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(firstName.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(firstName, errorMessage);
            }
            else if (String.IsNullOrEmpty(lastName.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(lastName, errorMessage);
            }
            else if (String.IsNullOrEmpty(address.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(address, errorMessage);
            }
            else if (String.IsNullOrEmpty(consultingDoctor.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(consultingDoctor, errorMessage);
            }
            else if (String.IsNullOrEmpty(ward.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(ward, errorMessage);
            }
            else if (String.IsNullOrEmpty(bedNo.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(bedNo, errorMessage);
            }
            else if (String.IsNullOrEmpty(roomNo.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(roomNo, errorMessage);
            }
        }

        /// <summary>
        /// Return to previous windows form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Clear all fields button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
