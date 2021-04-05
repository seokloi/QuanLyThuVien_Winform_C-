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
    public class DAL_Book : DBConnect
    {
        public DataTable getBook()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM sach", _conn);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            return dtBook;
        }

        public bool themBook(DTO_SACH book)
        {
            try
            {
                // Mở kết nối
                _conn.Open();

                // Query string 
                string SQL = $"INSERT INTO sach (id, TenSach, TacGia, id_TheLoai, NamXuatBan, NhaXuatBan, TriGia, TinhTrang, SoLuong) " +
                             $"VALUES ({book.ID}, '{book.TENSACH}', '{book.TACGIA}', {book.ID_THELOAI}, {book.NAMXUATBAN}, '{book.NHAXUATBAN}', {book.TRIGIA}, '{book.TINHTRANG}', {book.SOLUONG})";
                // Command 
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch{}
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }
            return false;
        }

        public bool xoaBook(int Book_ID)
        {
            try
            {
                // Mở kết nối
                _conn.Open();
                // Query string
                string SQL = $"DELETE FROM sach WHERE id = {Book_ID}";
                // Command
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch{}
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }
            return false;
        }

        public bool suaBook(DTO_SACH book)
        {
            try
            {
                // Mở kết nối
                _conn.Open();

                // Query string
                string SQL = $"UPDATE sach " +
                             $"SET TenSach = '{book.TENSACH}', TacGia = '{book.TACGIA}', " +
                             $"id_TheLoai = {book.ID_THELOAI}, NamXuatBan = {book.NAMXUATBAN}, NhaXuatBan = '{book.NHAXUATBAN}', TriGia = {book.TRIGIA}," +
                             $" TinhTrang = '{book.TINHTRANG}', SoLuong = 0 " +
                             $"WHERE ID = { book.ID }";

                // Command
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch{}
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }
            return false;
        }
        public bool nhapBook()
        {
            return false;
        }
    }
}