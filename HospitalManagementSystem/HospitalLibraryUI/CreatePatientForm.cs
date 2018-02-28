using HospitalLibrary.DataAccess;
using HospitalLibrary.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    //TODO - Text field validation recheck

    public partial class CreatePatient : Form
    {
        private string errorMsg = "Check field";

        public CreatePatient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all fields on form
        /// </summary>
        private void ClearAllFields()
        {
            FirstName.Text = "";
            LastName.Text = "";
            Address.Text = "";
            GenderComboBox.SelectedIndex = -1;
            ConsultingDoctor.Text = "";
            Ward.Text = "";
            RoomNo.Text = "";
            BedNo.Text = "";
            YesCheckBox.Checked = false;
            patientFormValidator.Clear();
            healthCardLabel.Text = "-";

            FirstName.Focus();
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
                healthCardLabel.Text = YesCheckBox.Text;
            }
            else
            {
                healthCardLabel.Text = "-";
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
                patientFormValidator.Clear();
            }
        }

        /// <summary>
        /// Text box validations (not empty)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstName.Text))
            {
                e.Cancel = true;
                this.patientFormValidator.SetError(FirstName, errorMsg);
            }
        }

        private void LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LastName.Text))
            {
                e.Cancel = true;
                this.patientFormValidator.SetError(LastName, errorMsg);
            }
        }

        private void Address_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Address.Text))
            {
                e.Cancel = true;
                this.patientFormValidator.SetError(Address, errorMsg);
            }
        }

        private void ConsultingDoctor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ConsultingDoctor.Text))
            {
                e.Cancel = true;
                this.patientFormValidator.SetError(ConsultingDoctor, errorMsg);
            }
        }

        private void Ward_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Ward.Text))
            {
                e.Cancel = true;
                this.patientFormValidator.SetError(Ward, errorMsg);
            }
        }
        /// <summary>
        /// Needs to accept only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(RoomNo.Text))
            {
                e.Cancel = true;
                this.patientFormValidator.SetError(RoomNo, errorMsg);
            }
        }
        /// <summary>
        /// Needs to accept only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BedNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(BedNo.Text))
            {
                e.Cancel = true;
                patientFormValidator.SetError(BedNo, errorMsg);
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
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                HomeAddress = Address.Text,
                Gender = GenderComboBox.Text,
                ConsultingDoctor = ConsultingDoctor.Text,
                Ward = Ward.Text,
                RoomNumber = RoomNo.Text,
                BedNumber = BedNo.Text,
                HasHealthCard = healthCardLabel.Text
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
            patientFormValidator.Clear();
            ClearAllFields();
        }

        /// <summary>
        /// Return to previous window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 
