using System;
using System.Collections.Generic;
using System.Configuration;

namespace HospitalLibrary.DataAccess
{
    public class GlobalConfiguration
    {
        //Global connection
        public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections (bool database)
        {
            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connection.Add(sql);
            }
        }
        //Global connection string
        public static string ConnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
