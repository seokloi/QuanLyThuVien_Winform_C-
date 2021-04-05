using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Sach
    {
        private DAL_Sach dalsach = new DAL_Sach();

        public DataTable laySach(int idsach)
        {
            return dalsach.laySach(idsach);
        }

        public DataTable laySach()
        {
            return dalsach.laySach();
        }
    }
}
