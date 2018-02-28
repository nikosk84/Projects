using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void CreateMaintenanceStaffBtn_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm newForm = new CreateEmployeeForm();
            newForm.Show();
        }

        private void CreatePatientBtn_Click(object sender, EventArgs e)
        {
            CreatePatientForm createPatient = new CreatePatientForm();
            createPatient.Show();
        }

        private void FindStaffMenuBtn_Click(object sender, EventArgs e)
        {
            FindStaffForm findRecord = new FindStaffForm();
            findRecord.Show();
        }

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {
            CreateVehicleForm newVehicle = new CreateVehicleForm();
            newVehicle.Show();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLogin = new MainLoginForm();
            Close();
            mainLogin.Show();
        }

        private void CreateRecordBtn_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm addNewRecord = new CreateEmployeeForm();
            addNewRecord.Show();
        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetEmployeeListBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdatePatientBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetPatientListBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FindPatientBtn_Click(object sender, EventArgs e)
        {
            FindPatient findPatient = new FindPatient();
            findPatient.Show();
        }
    }
}
