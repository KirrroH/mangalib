using MySql.Data.MySqlClient;

namespace mangalib
{
    internal class DBUtils
    {
        public static MySqlConnection GetConnection()
        {
            string host = "localhost";
            string database = "mangalib";
            int port = 3306;
            string user = "root";
            string pass = "root";

            return MySQLDBUtils.GetConnection(host, database, port, user, pass);
        }
    }
}