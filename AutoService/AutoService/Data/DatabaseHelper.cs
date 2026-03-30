using System.Configuration;
using System.Data.SqlClient;

namespace AutoService.Data
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["AutoServiceDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
