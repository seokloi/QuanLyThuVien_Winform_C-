using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public bool themNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("INSERT INTO USERS (USERNAME, PASSWORD, HOVATEN, GIOITINH," +
                    " SODT, NGAYSINH, DIACHI, EMAIL, NGAYVAOLAM, CHUCVU) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", 
                    dtonhanvien.USERNAME, dtonhanvien.PASSWORD, dtonhanvien.HOVATEN, dtonhanvien.GIOITINH, dtonhanvien.SODT,
                    dtonhanvien.NGAYSINH, dtonhanvien.DIACHI, dtonhanvien.EMAIL, dtonhanvien.NGAYVAOLAM, dtonhanvien.CHUCVU);

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

        public bool suaNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("UPDATE USERS SET HOVATEN = '{0}', GIOITINH = '{1}'," +
                    " SODT = '{3}', NGAYSINH = '{4}', DIACHI = '{5}', EMAIL = '{6}', NGAYVAOLAM = '{7}'," +
                    " CHUCVU = '{8}' MATKHAU = '{9}' WHERE ID = '{10}'", dtonhanvien.USERNAME, dtonhanvien.PASSWORD, dtonhanvien.HOVATEN, 
                    dtonhanvien.GIOITINH, dtonhanvien.SODT, dtonhanvien.NGAYSINH, dtonhanvien.DIACHI, dtonhanvien.EMAIL, 
                    dtonhanvien.NGAYVAOLAM, dtonhanvien.CHUCVU, dtonhanvien.PASSWORD, dtonhanvien.ID);

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

        public bool xoaNhanVien(int idnhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("DELETE FROM USERS WHERE ID = {0}", idnhanvien);

                MySqlCommand cmd = new MySqlCommand(sql, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã xóa nhân viên");
                    return true;
                }
                   

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

        public DTO_NHANVIEN layNhanVien(int idnhanvien)
        {
            try
            {
                _conn.Open();

                string sql = string.Format("SELECT * FROM USERS WHERE ID = {0}", idnhanvien);
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtnhanvien = new DataTable();
             
                sda.Fill(dtnhanvien);

                DTO_NHANVIEN dtonhanvien = new DTO_NHANVIEN();
                MessageBox.Show("In 1" + Int32.Parse(dtnhanvien.Rows[0]["id"].ToString()));

                dtonhanvien.ID = Int32.Parse(dtnhanvien.Rows[0]["id"].ToString());
                dtonhanvien.USERNAME = dtnhanvien.Rows[0]["username"].ToString();
                dtonhanvien.PASSWORD = dtnhanvien.Rows[0]["password"].ToString();
                dtonhanvien.HOVATEN = dtnhanvien.Rows[0]["HoVaTen"].ToString();
                dtonhanvien.GIOITINH = dtnhanvien.Rows[0]["GioiTinh"].ToString();
                dtonhanvien.SODT = dtnhanvien.Rows[0]["SoDT"].ToString();
                dtonhanvien.NGAYSINH = dtnhanvien.Rows[0]["NgaySinh"].ToString();
                dtonhanvien.EMAIL = dtnhanvien.Rows[0]["Email"].ToString();
                dtonhanvien.NGAYVAOLAM = dtnhanvien.Rows[0]["NgayVaoLam"].ToString();
                dtonhanvien.CHUCVU = dtnhanvien.Rows[0]["ChucVu"].ToString();

                return dtonhanvien;

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

        public DataTable layNhanVien()
        {
            try
            {
                string sql = string.Format("SELECT * FROM USERS");
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, _conn);
                DataTable dtnhanvien = new DataTable();
                
                sda.Fill(dtnhanvien);

                return dtnhanvien;

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
