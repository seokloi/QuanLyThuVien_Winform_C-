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
    public partial class PL_Setting_AddNew : Form
    {
        BLL_Setting bLLSetting = new BLL_Setting();
        public delegate void Test(string param);
        public Test TestDelegate;
        public PL_Setting_AddNew()
        {
            InitializeComponent();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (txtId.Text!="" && txtNameSetting.Text!="" && txtValueSetting.Text!="")
            {
                // Tạo DTo
                DTO_SETTING dtoSetting = new DTO_SETTING(Int16.Parse(txtId.Text), txtNameSetting.Text, txtValueSetting.Text);
                // Them
                if (bLLSetting.themSetting(dtoSetting))
                {
                    MessageBox.Show("Thêm thành công");
                    this.TestDelegate.Invoke("OK");
                    this.Close();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
