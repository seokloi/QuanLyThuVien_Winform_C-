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
    public partial class PL_Login : Form
    {
        public static string ID_USER = "";
        public static string HoVaTenUser = "";
        BLL_Employee bllEmployee = new BLL_Employee();
        public PL_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (bllEmployee.login(txtUsername.Text, txtPassword.Text) != "")
                {
                    PL_Home plHome = new PL_Home();
                    plHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
               
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
