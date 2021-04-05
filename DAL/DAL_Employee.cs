using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DAL_Employee : DBConnect
    {
        public string getID(string username, string pass)
        {
            string id = "";
            try
            {
                // Ket noi
                _conn.Open();
                var TABLE_EMPLOYEE = "nhanvien";
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM {TABLE_EMPLOYEE} WHERE username ='" + username + "' and password='" + pass + "'", _conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id"].ToString();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return id;
        }
    }
}
