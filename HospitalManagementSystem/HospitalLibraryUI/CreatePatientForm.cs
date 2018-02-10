using HospitalLibrary.Models;
using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    //TODO - REQUIRES TESTING
    //TODO - ADD INSERT CONNECTION
    //TODO - CHECK FIELD VALIDATIONS

    public partial class CreatePatient : Form
    {
        public CreatePatient()
        {
            InitializeComponent();
        }

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
            noCheckBox.Checked = false;
            firstName.Focus();
        }

        private bool ValidateCheckBox()
        {
            if (yesCheckBox.CheckState == CheckState.Checked)
            {
                return true;
            }
            else if (noCheckBox.CheckState == CheckState.Checked)
            {
                return true;
            }
            return false;
        }

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

        private void ReturnBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void SavePatientBtn_Click(object sender, System.EventArgs e)
        {
            PatientModel patient = new PatientModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                HomeAddress = address.Text,
                ConsultingDoctor = consultingDoctor.Text,
                Ward = ward.Text,
                RoomNumber = roomNo.Text,
                BedNumber = bedNo.Text
            };
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
