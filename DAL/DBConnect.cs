using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBConnect
    {
        public static string connectionString = $"datasource=127.0.0.1;username=root;password=;database=quanlythuvien;";
        protected MySqlConnection _conn = new MySqlConnection(connectionString);
    }
}
