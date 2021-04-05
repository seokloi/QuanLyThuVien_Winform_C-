using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhieuMuonSach
    {
        private DAL_PhieuMuonSach dalphieums = new DAL_PhieuMuonSach();

        public bool themPhieuMuonSach(DTO_MUONSACH dtoms, List<int> lsmasach)
        {
            BLL_Sach bllsach = new BLL_Sach();
            BLL_QuyDinh bllquydinh = new BLL_QuyDinh();
            int maxsongaymuon = 0, totalphims = 0, feemuonsach = 0;

            maxsongaymuon = bllquydinh.layQuyDinh("So Ngay Muon Toi Da");
            feemuonsach = bllquydinh.layQuyDinh("Tien Muon Sach");

            foreach (int idsach in lsmasach)
            {
                themCTP_MuonSach(dtoms.ID_USER, idsach);

                totalphims += feemuonsach;
            }

            dtoms.NGAYMUON = DateTime.Today.Date.ToString("yyyy-MM-dd");
            dtoms.NGAYTRA = DateTime.Today.AddDays(maxsongaymuon).Date.ToString("yyyy-MM-dd");
            dtoms.TONGTIEN = totalphims;
            dtoms.TRANGTHAI = 0; 
            dtoms.CREATED_AT = DateTime.Now;
            dtoms.UPDATED_AT = DateTime.Now;

            return dalphieums.themPhieuMuonSach(dtoms);
            return false;
        }

        public bool themCTP_MuonSach(int iddocgia, int idsach)
        {
            DTO_CHITIETMUONSACH dtoctms = new DTO_CHITIETMUONSACH() { ID_SACH = idsach, CREATED_AT = DateTime.Now, UPDATED_AT = DateTime.Now };

            return dalphieums.themCTP_MuonSach(dtoctms);
        }

        public bool suaCTP_MuonSach(int iddocgia, int idsach)
        {
            DTO_CHITIETMUONSACH dtoctms = new DTO_CHITIETMUONSACH() { ID_SACH = idsach, UPDATED_AT = DateTime.Now };

            return dalphieums.suaCTP_MuonSach(dtoctms);

        }

        public bool tongKet_MuonSach(int iddocgia)
        {
            return dalphieums.tongKet_MuonSach(iddocgia);
        }

        public DataTable layCTMuonSach_ChuaTra(int iddocgia, int idsach)
        {
            return dalphieums.lay_CTMuonSach_ChuaTra(iddocgia, idsach);
        }

        public DataTable laySachMuon(int iddocgia)
        {
            return dalphieums.laySachMuon(iddocgia);
        }
    }
}
