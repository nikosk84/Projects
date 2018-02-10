using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class FindPatient : Form
    {
        //Under construction
        public FindPatient()
        {
            InitializeComponent();
            UpdateBindingPatient();
        }

        private void UpdateBindingPatient()
        {
            PatientsFoundLb.DisplayMember = "FullPatientInfo";
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTb.Text))
            {
                MessageBox.Show("Please enter a last name to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UpdateBindingPatient();
            }
        }
    }
}
