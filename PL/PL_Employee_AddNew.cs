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
    public partial class PL_Employee_AddNew : Form
    {
        private BLL_NhanVien bllnhanvien = new BLL_NhanVien();

        public PL_Employee_AddNew()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string gioitinh, chucvu, ngayvaolam, ngaysinh;

            ngaysinh = dtpNgaySinh.ToString();
            ngayvaolam = dtpNgayVaoLam.ToString();
            gioitinh = cbbGioiTinh.GetItemText(cbbGioiTinh.SelectedItem);
            chucvu = cbbChucVu.GetItemText(cbbChucVu.SelectedItem);

            if (KiemTra_DauVao())
            {
                DTO_NHANVIEN dtonhanvien = new DTO_NHANVIEN() { USERNAME = ttbTenDN.Text, PASSWORD = ttbMatKhau.Text, 
                HOVATEN = ttbTenNV.Text, NGAYSINH = ngaysinh, DIACHI = ttbDiaChi.Text, SODT = ttbSoDT.Text, 
                GIOITINH = gioitinh, EMAIL = ttbEmail.Text, NGAYVAOLAM = ngayvaolam, CHUCVU = chucvu };

                try
                {
                    if (bllnhanvien.themNhanVien(dtonhanvien))
                    {
                        MessageBox.Show("Thêm nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
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
                 reg.Is_NumberAndLetter_Only(ttbMatKhau.Text) && reg.Is_NumberAndLetter_Only(ttbTenDN.Text))
            {
                return true;
            }


            return false;
        }
    }
}
