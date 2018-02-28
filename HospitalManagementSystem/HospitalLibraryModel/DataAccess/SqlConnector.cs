using Dapper;
using HospitalLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Add new employee to database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public EmployeeModel InsertEmployee (EmployeeModel employee)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfiguration.ConnVal("HospitalModelDB")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", employee.FirstName);
                parameters.Add("@LastName", employee.LastName);
                parameters.Add("@HomeAddress", employee.HomeAddress);
                parameters.Add("@EmailAddress", employee.EmailAddress);
                parameters.Add("@CellPhoneNumber", employee.CellNumber);
                parameters.Add("@Position", employee.Position);

                connection.Execute("dbo.spEmployee_Insert", parameters, commandType: CommandType.StoredProcedure);

                MessageBox.Show("New employee saved", "Employee Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return employee;
            }
        }

        /// <summary>
        /// Add new patient to database
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public PatientModel InsertPatient (PatientModel patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfiguration.ConnVal("HospitalModelDB")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", patient.FirstName);
                parameters.Add("@LastName", patient.LastName);
                parameters.Add("@HomeAddress", patient.HomeAddress);
                parameters.Add("@Gender", patient.Gender);
                parameters.Add("@ConsultingDoctor", patient.ConsultingDoctor);
                parameters.Add("@Ward", patient.Ward);
                parameters.Add("@FirstName", patient.FirstName);
                parameters.Add("@RoomNumber", patient.RoomNumber);
                parameters.Add("@BedNumber", patient.BedNumber);
                parameters.Add("@HasHealthCard", patient.HasHealthCard);

                connection.Execute("dbo.spPatientInsert", parameters, commandType: CommandType.StoredProcedure);

                MessageBox.Show("New patient saved", "Patient Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return patient;

            }
        }

        /// <summary>
        /// Get employee by last name and display record in ListBox
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public List<EmployeeModel> GetEmployee (string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfiguration.ConnVal("HospitalModelDB")))
            {
                var output = connection.Query<EmployeeModel>("dbo.spEmployee_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        /// <summary>
        /// Get log on credentials from database and log user into system
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public SysUserModel LogOn(string userName, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfiguration.ConnVal("HospitalModelDB")))
            {
                var sysUser = connection.Query<SysUserModel>("dbo.spLogin", new { UserName = userName, Password = password }, commandType: CommandType.StoredProcedure).First();
                return sysUser;
            }
        }
    }
}
