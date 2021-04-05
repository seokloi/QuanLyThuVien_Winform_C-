using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Setting : DBConnect
    {
        public static string TABLE_SETTING = "setting";
        public DataTable getQuyDinh()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM setting", _conn);
            DataTable dtSetting = new DataTable();
            da.Fill(dtSetting);
            return dtSetting;
        }
        public bool themSetting(DTO_SETTING dtoSetting)
        {
            try
            {
                _conn.Open();
                
                string SQL = $"INSERT INTO {TABLE_SETTING} (id,nameSetting, valueSetting) " +
                             $"VALUES ({dtoSetting.ID}, '{dtoSetting.NAMESETTING}', '{dtoSetting.VALUESETTING}')";
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool xoaQuyDinh(int IdSetsting)
        {
            try
            {
                _conn.Open();
                string SQL = $"DELETE FROM {TABLE_SETTING} WHERE id = '{IdSetsting}'";
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
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
        public bool suaQuyDinh(DTO_SETTING dtoSetting)
        {
            try
            {
                _conn.Open();
                string SQL = $"UPDATE {TABLE_SETTING} SET nameSetting='{dtoSetting.NAMESETTING}', valueSetting='{dtoSetting.VALUESETTING}' WHERE id='{dtoSetting.ID}'";
                MySqlCommand cmd = new MySqlCommand(SQL, _conn);
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
