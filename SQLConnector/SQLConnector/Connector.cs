using Dapper;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace SQLConnector
{
    public class Connector
    {
        /// <summary>
        /// Get person by LastName using stored procedure and show it in the ListBox
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public List<Person> GetPerson(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConnection.ConnectionValue("SQLConnectorTester")))
            {
                var output = connection.Query<Person>("dbo.spPerson_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }
    }
}
