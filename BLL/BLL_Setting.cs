using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Setting
    {
        DAL_Setting dalSetting = new DAL_Setting();
        public DataTable getQuyDinh()
        {
            return dalSetting.getQuyDinh();
        }
        public bool themSetting(DTO_SETTING dtoSetting)
        {
            return dalSetting.themSetting(dtoSetting);
        }
        public bool xoaQuyDinh(int IdSetting)
        {
            return dalSetting.xoaQuyDinh(IdSetting);
        }
        public bool suaQuyDinh(DTO_SETTING dtoSetting)
        {
            return dalSetting.suaQuyDinh(dtoSetting);
        }
    }
}
