using System;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CreateMaintenanceStaffBtn_Click(object sender, EventArgs e)
        {
            CreateEmployee newForm = new CreateEmployee();
            newForm.Show();
        }

        private void CreatePatientBtn_Click(object sender, EventArgs e)
        {
            CreatePatient createPatient = new CreatePatient();
            createPatient.Show();
        }

        private void FindStaffMenuBtn_Click(object sender, EventArgs e)
        {
            FindStaff findRecord = new FindStaff();
            findRecord.Show();
        }

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {
            CreateVehicle newVehicle = new CreateVehicle();
            newVehicle.Show();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainLogin mainLogin = new MainLogin();
            Close();
            mainLogin.Show();
        }

        private void CreateRecordBtn_Click(object sender, EventArgs e)
        {
            CreateEmployee addNewRecord = new CreateEmployee();
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
