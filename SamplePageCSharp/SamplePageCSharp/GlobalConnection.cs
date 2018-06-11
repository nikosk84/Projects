using OfficeOpenXml;
using System.Configuration;
using System.Data;
using System.Linq;

public static class GlobalConnection
{
    public static string Connection(string name)
    {
        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}