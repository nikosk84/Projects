using System.Collections.Generic;
using System.Configuration;

namespace HospitalLibrary.DataAccess
{
    public class GlobalConfiguration
    {
        /// <summary>
        /// Global connection
        /// </summary>
        public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections (bool database)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connection.Add(sql);
            }
        }
        /// <summary>
        /// Global connection string from App.Config
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
