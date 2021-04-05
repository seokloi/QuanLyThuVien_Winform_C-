using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_QuyDinh : DBConnect
    {
        public int layQuyDinh(string namequydinh)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT VALUESETTING FROM SETTING WHERE NAMESETTING LIKE '{0}'", namequydinh);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtquydinh = new DataTable();

                sda.Fill(dtquydinh);

                int mucquydinh = Int32.Parse(dtquydinh.Rows[0]["valueSetting"].ToString());


                return mucquydinh;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return 0;
        }
    }
}
