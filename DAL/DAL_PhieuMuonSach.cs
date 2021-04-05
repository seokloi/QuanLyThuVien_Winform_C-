using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_PhieuMuonSach : DBConnect
    {
        public bool themPhieuMuonSach(DTO_MUONSACH dtophieums)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO MUONSACH (ID_USER, NGAYMUON, NGAYTRA," +
                    " TONGTIEN, TRANGTHAI, CREATED_AT, UPDATED_AT)" +
                    " VALUES( {0}, '{1}', '{2}', {3}, '{4}', '{5}', '{6}' )", dtophieums.ID_USER, dtophieums.NGAYMUON, dtophieums.NGAYTRA,
                    dtophieums.TONGTIEN, dtophieums.TRANGTHAI, dtophieums.CREATED_AT.ToString("yyyy-MM-dd hh:mm:ss"), dtophieums.UPDATED_AT.ToString("yyyy-MM-dd HH:mm:ss"));

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

        public bool themCTP_MuonSach(DTO_CHITIETMUONSACH dtoctms)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO CHITTIETMUONSACH (ID_MUONSACH, ID_SACH, CREATED_AT, UPDATED_AT) VALUES ( {0}, {1}, {2}, {3} )",
                    dtoctms.ID_MUONSACH, dtoctms.ID_SACH, dtoctms.CREATED_AT.ToString("yyyy-MM-dd hh:mm:ss"), dtoctms.UPDATED_AT.ToString("yyyy-MM-dd hh:mm:ss"));

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

        public bool suaCTP_MuonSach(DTO_CHITIETMUONSACH dtoctms)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("UPDATE CHITIETMUONSACH  SET UPDATED_AT = '{0}' WHERE ID IN " +
                    "(SELECT CT.ID FROM MUONSACH MS, (SELECT * FROM CHITIETMUONSACH) CT " +
                    "WHERE MS.ID = CT.ID_MUONSACH AND CT.CREATED_AT = CT.UPDATED_AT AND MS.ID_USER = {1} AND CT.ID_SACH = {2})",
                    dtoctms.UPDATED_AT.ToString("yyyy-MM-dd hh:mm:ss"), dtoctms.ID_MUONSACH, dtoctms.ID_SACH);

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

        public bool tongKet_MuonSach(int iddocgia)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("UPDATE MUONSACH SET TRANGTHAI = 1 WHERE ID_USER = {0} AND ID NOT IN (SELECT DISTINCT MS.ID FROM (SELECT * FROM MUONSACH) MS, CHITIETMUONSACH CT " +
                    "WHERE MS.ID = CT.ID_MUONSACH AND CT.ID IN (SELECT CT2.ID FROM CHITIETMUONSACH CT2 WHERE CT2.CREATED_AT = CT2.UPDATED_AT))", iddocgia);

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

        public DataTable lay_CTMuonSach_ChuaTra(int iddocgia, int idsach)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT CT.CREATED_AT FROM MUONSACH MS," +
                    " CHITIETMUONSACH CT WHERE MS.ID = CT.ID_MUONSACH AND CT.UPDATED_AT IS NULL AND MS.ID_USER = {0} AND CT.ID_SACH = {1}", iddocgia, idsach);

                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dttimems = new DataTable();

                sda.Fill(dttimems);

                return dttimems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null;
        }

        public DataTable laySachMuon(int iddocgia)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT * FROM SACH S, THELOAI TL WHERE S.ID IN " +
                    " (SELECT ID_SACH FROM MUONSACH MS, CHITIETMUONSACH CT WHERE MS.ID = CT.ID_MUONSACH AND CT.UPDATED_AT IS NULL AND MS.ID_USER = {0})", iddocgia);

                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtsachm = new DataTable();

                sda.Fill(dtsachm);
                
                return dtsachm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return null;
        }
    }
}
