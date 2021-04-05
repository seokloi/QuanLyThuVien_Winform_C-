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
    public class BLL_BaoCao
    {
        DAL_Report dalReport = new DAL_Report();

        public DataTable layBaoCaoMuonSachTheLoai(int thang)
        {
            return dalReport.layBaoCaoMuonSachTheLoai(thang);
        }
        public DataTable layBaoCaoTraSachTre(string ngay)
        {
            return dalReport.layBaoCaoTraSachTre(ngay);
        }
    }
}
