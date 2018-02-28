using HospitalLibrary.Models;

namespace HospitalLibrary.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel InsertEmployee (EmployeeModel employee);
        PatientModel InsertPatient (PatientModel patient);
    }
}
