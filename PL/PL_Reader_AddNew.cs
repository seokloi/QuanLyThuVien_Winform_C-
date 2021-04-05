using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using PL;

namespace PL
{
    public partial class PL_Reader_AddNew : Form
    {
        BLL_Reader bllReader = new BLL_Reader();
        public delegate void Test(string param);
        public Test TestDelegate;
        public PL_Reader_AddNew()
        {
            InitializeComponent();
        }
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text != "" && txtHoVaTen.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "")
            {
                string sex;
                if (radioNam.Checked == true)
                    sex = "Nam";
                else
                    sex = "Nu";
                // Tạo DTo
                DTO_DOCGIA user = new DTO_DOCGIA(int.Parse(txtMaDocGia.Text), txtHoVaTen.Text, sex, txtSoDT.Text, txtLoaiDocGia.Text, dtNgaySinh.Value.ToString("yyyy-MM-dd"), txtDiaChi.Text, txtEmail.Text, dtNgayLapThe.Value.ToString("yyyy-MM-dd"), 0);
                // Them
                if (bllReader.themReader(user))
                {
                    MessageBox.Show("Thêm thành công");
                    this.TestDelegate.Invoke("OK");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnHuyThemDocGia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
