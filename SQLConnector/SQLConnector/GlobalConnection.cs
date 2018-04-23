using System.Configuration;

namespace SQLConnector
{
    public class GlobalConnection
    {
        /// <summary>
        /// Looks up the connection string from App.Config
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Connection(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
