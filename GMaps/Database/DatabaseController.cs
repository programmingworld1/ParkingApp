using System.Data.SqlClient;

namespace GMaps
{
    public class DatabaseController
    {
        protected SqlConnection connection;
        protected string filePath;

        public DatabaseController()
        {
            filePath = @"..\..\..\error_log.txt";
            connection = new SqlConnection();
            connection.ConnectionString =
            "Data Source=MURAT;" +
            "Initial Catalog=parkingapp;" +
            "Integrated Security=SSPI;";
        }
    }
}
