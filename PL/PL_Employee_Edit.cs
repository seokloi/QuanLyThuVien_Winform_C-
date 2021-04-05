using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class PL_Employee_Edit : Form
    {
        private BLL_NhanVien bllnhanvien = new BLL_NhanVien();

        public PL_Employee_Edit()
        {
            InitializeComponent();
        }

        public PL_Employee_Edit(int idnhanvien) ///
        {
            InitializeComponent();
            capNhat_DauVao(idnhanvien);
        }
           
        private void capNhat_DauVao(int idnhanvien)
        {
            MessageBox.Show("" + idnhanvien);
            DTO_NHANVIEN dtonhanvien = bllnhanvien.layNhanVien(idnhanvien);

            ttbTenNV.Text = dtonhanvien.HOVATEN;
            dtpNgaySinh.Text = dtonhanvien.NGAYSINH.ToString();
            ttbDiaChi.Text = dtonhanvien.DIACHI;
            ttbSoDT.Text = dtonhanvien.SODT;
            ttbEmail.Text = dtonhanvien.EMAIL;
            dtpNgayVaoLam.Text = dtonhanvien.NGAYVAOLAM.ToString();
            ttbMatKhau.Text = dtonhanvien.PASSWORD;
        }
        
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (KiemTra_DauVao())
            {
                string ngaysinh, ngayvaolam, chucvu, gioitinh;

                ngaysinh = dtpNgaySinh.ToString();
                ngayvaolam = dtpNgayVaoLam.ToString();
                gioitinh = cbbGioiTinh.GetItemText(cbbGioiTinh.SelectedItem);
                chucvu = cbbChucVu.GetItemText(cbbChucVu.SelectedItem);

                DTO_NHANVIEN dtonhanvien = new DTO_NHANVIEN() { HOVATEN = ttbTenNV.Text, GIOITINH = gioitinh, 
                NGAYSINH = ngaysinh, SODT = ttbSoDT.Text, EMAIL = ttbEmail.Text, DIACHI = ttbDiaChi.Text,
                NGAYVAOLAM = ngayvaolam, CHUCVU = chucvu };

                try
                {
                    if (bllnhanvien.suaNhanVien(dtonhanvien))
                    {
                        MessageBox.Show("Thay đổi thông tin thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thông tin thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();

            this.Close();
            plhome.Show();
        }

        private bool KiemTra_DauVao()
        {
            RegularExp reg = new RegularExp();

            if (reg.Is_WhiteSpaceAndLetters_Only(ttbTenNV.Text) && reg.Is_Numbers_Only(ttbSoDT.Text) && string.IsNullOrEmpty(ttbDiaChi.Text) &&
                 reg.Is_NumberAndLetter_Only(ttbMatKhau.Text))
            {
                return true;
            }


            return false;
        }
    }
}
