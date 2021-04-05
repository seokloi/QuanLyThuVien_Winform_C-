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
    public class DAL_Reader : DBConnect
    {
        /*Get toàn bộ Độc giả*/
        public DataTable getReader()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM docgia", _conn);
            DataTable dtReader = new DataTable();
            da.Fill(dtReader);
            return dtReader;
        }

        /*Thêm độc giả*/
        public bool themReader(DTO_DOCGIA reader)
        {
            try
            {
                // Ket noi
                _conn.Open();

                var TABLE_READER = "docgia";
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = $"INSERT INTO {TABLE_READER} (id, HoVaTen, SoDT, GioiTinh, DiaChi, NgaySinh, LoaiDocGia, Email, NgayLapThe, TongNo) " +
                             $"VALUES ({reader.ID}, '{reader.HOVATEN}', '{reader.SODT}', '{reader.GIOITINH}', '{reader.DIACHI}', '{reader.NGAYSINH}', '{reader.LOAIDOCGIA}', '{reader.EMAIL}', '{reader.NGAYLAPTHE}', 0)";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        /*Xóa thành viên*/
        public bool xoaReader(int Reader_ID)
        {
            try
            {
                // Ket noi
                _conn.Open();
                var TABLE_READER = "docgia";
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = $"DELETE FROM {TABLE_READER} WHERE id = {Reader_ID}";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /*Sửa độc giả*/
        public bool suaReader(DTO_DOCGIA reader)
        {
            try
            {
                // Ket noi
                _conn.Open();

                var TABLE_READER = "docgia";
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = $"UPDATE {TABLE_READER} " +
                             $"SET HoVaTen = '{reader.HOVATEN}', SoDT = '{reader.SODT}', LoaiDocGia = '{reader.LOAIDOCGIA}', NgayLapThe = '{reader.NGAYLAPTHE}', DiaChi = '{reader.DIACHI}', NgaySinh = '{reader.NGAYSINH}', Email = '{reader.EMAIL}' " +
                             $"WHERE ID = { reader.ID }";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }
    }
}