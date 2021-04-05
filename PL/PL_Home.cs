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
    public partial class PL_Home : Form
    {
        public PL_Home()
        {
            InitializeComponent();
        }

        private void picQuanLyDocGia_Click(object sender, EventArgs e)
        {
            PL_Reader_List Reader = new PL_Reader_List();
            Reader.Show();
        }

        
        private void picDangXuat_Click(object sender, EventArgs e)
        {
            PL_Login Login = new PL_Login();
            Login.Show();
            this.Hide();
        }

        private void picQuanLySach_Click(object sender, EventArgs e)
        {
            PL_Book_List Book = new PL_Book_List();
            Book.Show();
        }

        private void picBaoCao_Click(object sender, EventArgs e)
        {
            PL_Report Report = new PL_Report();
            Report.Show();
        }

        private void picThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            PL_Setting Setting = new PL_Setting();
            Setting.Show();
        }
    } 
}
