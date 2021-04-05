using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BLL_PhieuTraSach
    {
        private DAL_PhieuTraSach dalphieuts = new DAL_PhieuTraSach();

        public bool themPhieuTraSach(ref DTO_TRASACH dtots, List<int> lsmasach)
        {
            BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();

            khoiTao_DoiTuongTraSach(ref dtots);

            foreach (int idsach in lsmasach)
            {
                tra_TungSach(ref dtots, idsach);
                themCTP_TraSach(idsach);
                bllphieums.suaCTP_MuonSach(dtots.ID_USER, idsach);
            }

            bllphieums.tongKet_MuonSach(dtots.ID_USER);

            return dalphieuts.themPhieuTraSach(dtots);
        }

        public void khoiTao_DoiTuongTraSach(ref DTO_TRASACH dtots)
        {
            dtots.NGAYTRA = DateTime.Today.Date.ToString();
            dtots.CREATED_AT = DateTime.Now.Date;
            dtots.UPDATED_AT = DateTime.Now.Date;
            dtots.SONGAYTRE = 0;
            dtots.TIENTRE = 0;
            dtots.TIENBOITHUONG = 0;
            dtots.TIENTHUESACH = 0;
            dtots.TONGTIEN = 0;
        }

        public bool tra_TungSach(ref DTO_TRASACH dtots, int idsach)
        {
            BLL_Sach bllsach = new BLL_Sach();
            BLL_QuyDinh bllquydinh = new BLL_QuyDinh();
            BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();

            DataTable dtphieums = null;
            DateTime datemuonsach = DateTime.Now;
            int totalngaytra = 0, maxngaytra = 0, finetratre = 0, feethuesach = 0, feeboithuong = 0;
            
            try
            {
                dtphieums = bllphieums.layCTMuonSach_ChuaTra(dtots.ID_USER, idsach);
                datemuonsach = Convert.ToDateTime(dtphieums.Rows[0]["CREATED_AT"].ToString());

                totalngaytra = DateTime.Now.Subtract(datemuonsach).Days;
                maxngaytra = bllquydinh.layQuyDinh("So_Ngay_Muon_Toi_Da");
                finetratre = bllquydinh.layQuyDinh("Tien_Phat");
                feethuesach = bllquydinh.layQuyDinh("Tien_Muon_Sach");

                dtots.SONGAYTRE += ((totalngaytra - maxngaytra > 0) ? (totalngaytra - maxngaytra) : 0);
                dtots.TIENTRE += dtots.SONGAYTRE * finetratre;
                dtots.TIENBOITHUONG += 0;
                dtots.TIENTHUESACH += feethuesach;
                dtots.TONGTIEN += dtots.TIENTRE + dtots.TIENBOITHUONG + dtots.TIENTHUESACH;

                return true;
            }
            catch (Exception ex)
            {
                //mess
            }

            return false;
        }

        public bool themCTP_TraSach(int idsach)
        {
            DTO_CHITIETTRASACH dtoctts = new DTO_CHITIETTRASACH() { ID_SACH = idsach, CREATED_AT = DateTime.Now, UPDATED_AT = DateTime.Now };

            return dalphieuts.themCTP_TraSach(dtoctts);
        }
    }
}
