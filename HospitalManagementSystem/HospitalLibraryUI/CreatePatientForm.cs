using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    //TODO - Text field validation recheck

    public partial class CreatePatientForm : Form
    {
        private string errorMsg = "Check field";

        public CreatePatientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all fields on form
        /// </summary>
        private void ClearAllFields()
        {
            FirstNameText.Text = "";
            LastNameText.Text = "";
            AddressText.Text = "";
            GenderComboBox.SelectedIndex = -1;
            ConsultingDoctorText.Text = "";
            WardText.Text = "";
            RoomNoText.Text = "";
            BedNoText.Text = "";
            YesCheckBox.Checked = false;
            PatientFormValidator.Clear();
            HealthCardLabel.Text = "-";

            FirstNameText.Focus();
        }

        /// <summary>
        /// Monitors Health Card selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (YesCheckBox.Checked)
            {
                HealthCardLabel.Text = YesCheckBox.Text;
            }
            else
            {
                HealthCardLabel.Text = "-";
            }
        }

        /// <summary>
        /// Monitors combo box selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenderComboBox.SelectedIndex > -1)
            {
                PatientFormValidator.Clear();
            }
        }

        /// <summary>
        /// Text box validations (not empty)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameText.Text))
            {
                e.Cancel = true;
                this.PatientFormValidator.SetError(FirstNameText, errorMsg);
            }
        }

        private void LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastNameText.Text))
            {
                e.Cancel = true;
                this.PatientFormValidator.SetError(LastNameText, errorMsg);
            }
        }

        private void Address_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AddressText.Text))
            {
                e.Cancel = true;
                this.PatientFormValidator.SetError(AddressText, errorMsg);
            }
        }

        private void ConsultingDoctor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ConsultingDoctorText.Text))
            {
                e.Cancel = true;
                this.PatientFormValidator.SetError(ConsultingDoctorText, errorMsg);
            }
        }

        private void Ward_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(WardText.Text))
            {
                e.Cancel = true;
                this.PatientFormValidator.SetError(WardText, errorMsg);
            }
        }
        /// <summary>
        /// Needs to accept only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(RoomNoText.Text))
            {
                e.Cancel = true;
                this.PatientFormValidator.SetError(RoomNoText, errorMsg);
            }
        }
        /// <summary>
        /// Needs to accept only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BedNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(BedNoText.Text))
            {
                e.Cancel = true;
                PatientFormValidator.SetError(BedNoText, errorMsg);
            }
        }

        /// <summary>
        /// Save record button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePatientBtn_Click(object sender, EventArgs e)
        {
            var textBoxes = Controls.OfType<TextBox>();

            PatientModel patient = new PatientModel
            {
                FirstName = FirstNameText.Text,
                LastName = LastNameText.Text,
                HomeAddress = AddressText.Text,
                Gender = GenderComboBox.Text,
                ConsultingDoctor = ConsultingDoctorText.Text,
                Ward = WardText.Text,
                RoomNumber = RoomNoText.Text,
                BedNumber = BedNoText.Text,
                HasHealthCard = HealthCardLabel.Text
            };

            foreach (IDataConnection connection in GlobalConfiguration.Connection)
            {
                connection.InsertPatient(patient);
            }
        }

        /// <summary>
        /// Clear all fields on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Return to previous window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
           //To be fixed
        }
    }
}
 
