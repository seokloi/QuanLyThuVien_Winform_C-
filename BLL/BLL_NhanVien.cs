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
    public class BLL_NhanVien
    {
        private DAL_NhanVien dalnhanvien = new DAL_NhanVien();

        public bool themNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            return dalnhanvien.themNhanVien(dtonhanvien);
        }

        public bool suaNhanVien(DTO_NHANVIEN dtonhanvien)
        {
            return dalnhanvien.suaNhanVien(dtonhanvien);
        }

        public bool xoaNhanVien(int idnhanvien)
        {
            return dalnhanvien.xoaNhanVien(idnhanvien);
        }

        public DTO_NHANVIEN layNhanVien(int idnhanvien)
        {
            return dalnhanvien.layNhanVien(idnhanvien);
        }

        public DataTable layNhanVien()
        {
            return dalnhanvien.layNhanVien();
        }
    }
}
