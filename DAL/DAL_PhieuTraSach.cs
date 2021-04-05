using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_PhieuTraSach : DBConnect
    {
        public bool themPhieuTraSach(DTO_TRASACH dtophieuts)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO TRASACH (ID_USER, NGAYTRA, SONGAYTRE," +
                    " TIENTRE, TIENBOITHUONG, TIENTHUESACH, TONGTIEN, CREATED_AT, UPDATED_AT)" +
                    " VALUES( {0}, '{1}', {2}, {3}, {4}, {5}, {6}, '{7}', '{8}' )", dtophieuts.ID_USER,
                    dtophieuts.NGAYTRA, dtophieuts.SONGAYTRE, dtophieuts.TIENTRE, dtophieuts.TIENBOITHUONG,
                    dtophieuts.TIENTHUESACH, dtophieuts.TONGTIEN, dtophieuts.CREATED_AT.ToString("yyyy-MM-dd HH:mm:ss.fff"), dtophieuts.UPDATED_AT.ToString("yyyy-MM-dd HH:mm:ss.fff"));

                MySqlCommand cmd = new MySqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool themCTP_TraSach(DTO_CHITIETTRASACH dtoctpt)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO CHITTIETTRASACH VALUES ({0}, {1}, {2}, {3} )",
                    dtoctpt.ID_TRASACH, dtoctpt.ID_SACH, dtoctpt.CREATED_AT.ToString("yyyy-MM-dd HH:mm:ss.fff"), dtoctpt.UPDATED_AT.ToString("yyyy-MM-dd HH:mm:ss.fff"));

                MySqlCommand cmd = new MySqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
