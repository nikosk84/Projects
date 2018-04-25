using System.Configuration;

namespace SimpleSQLConnector
{
    class GlobalConnection
    {
        public static string Connection (string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
