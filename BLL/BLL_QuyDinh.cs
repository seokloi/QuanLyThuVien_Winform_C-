using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_QuyDinh
    {
        private DAL_QuyDinh dalquydinh = new DAL_QuyDinh();

        public int layQuyDinh(string namequydinh)
        {
            return dalquydinh.layQuyDinh(namequydinh);
        }
    }
}
