using System;
using MySql.Data.MySqlClient;

namespace mangalib
{
    internal class MySQLDBUtils
    {
        public static MySqlConnection GetConnection (string host, string database, int port, string user, string pass)
        {
            String connString = $"Server={host};database={database};port={port};user={user};password={pass};";
            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}