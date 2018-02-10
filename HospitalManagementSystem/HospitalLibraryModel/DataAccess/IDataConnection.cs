using HospitalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel InsertEmployee (EmployeeModel employee);
        PatientModel InsertPatient (PatientModel patient);
    }
}
