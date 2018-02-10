using Dapper;
using HospitalLibrary.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //TODO - FIX PATIENT

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

                MessageBox.Show("Insert OK");

                return employee;
            }
        }

        public PatientModel InsertPatient (PatientModel patient)
        {
            throw new NotImplementedException();
        }
    }
}
