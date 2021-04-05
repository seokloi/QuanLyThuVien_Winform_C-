using DTO;
using MySql.Data.MySqlClient;
using Renci.SshNet.Messages;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Sach : DBConnect
    {
        public DataTable laySach(int idsach)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT S.ID, TENSACH, TACGIA, TL.TEN, TINHTRANG, TRIGIA," +
                    " NHAXUATBAN, NAMXUATBAN, SOLUONG, S.CREATED_AT, S.UPDATED_AT FROM SACH S, THELOAI TL " +
                    "WHERE S.ID_THELOAI = TL.ID AND S.ID LIKE '{0}'", idsach);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtsach = new DataTable();

                sda.Fill(dtsach);

                return dtsach;
                /*
                DTO_SACH dtosach = new DTO_SACH();

                dtosach.ID = Int32.Parse(dtsach.Rows[0]["id"].ToString());
                dtosach.TENSACH = dtsach.Rows[0]["TenSach"].ToString();
                dtosach.TACGIA = dtsach.Rows[0]["TacGia"].ToString();
                dtosach.ID_THELOAI = Int32.Parse(dtsach.Rows[0]["id_TheLoai"].ToString());
                dtosach.NAMXUATBAN = Int32.Parse(dtsach.Rows[0]["NamXuatBan"].ToString());
                dtosach.NHAXUATBAN = dtsach.Rows[0]["NhaXuatBan"].ToString();
                dtosach.TRIGIA = Int32.Parse(dtsach.Rows[0]["TriGia"].ToString());
                dtosach.TINHTRANG = dtsach.Rows[0]["TinhTrang"].ToString();
                dtosach.SOLUONG = Int32.Parse(dtsach.Rows[0]["Email"].ToString());
                
                return dtosach;
                */
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

        public DataTable laySach()
        {
            try
            {
                string sql = string.Format("SELECT S.ID, TENSACH, TACGIA, TL.TEN, TINHTRANG, TRIGIA," +
                    " NHAXUATBAN, NAMXUATBAN, SOLUONG, S.CREATED_AT, S.UPDATED_AT FROM SACH S, THELOAI TL " +
                    "WHERE S.ID_THELOAI = TL.ID");
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtsach = new DataTable();

                sda.Fill(dtsach);

                return dtsach;

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
