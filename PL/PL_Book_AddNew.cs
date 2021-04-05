﻿using System;
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
    public partial class PL_Book_AddNew : Form
    {
        BLL_Book bllBook = new BLL_Book();
        public delegate void Test(string param);
        public Test TestDelegate;
        public PL_Book_AddNew()
        {
            InitializeComponent();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && txtTheLoai.Text != "" && txtTacGia.Text != "" && txtNamXuatBan.Text != "" && txtNhaXuatBan.Text != "" && txtTriGia.Text != "")
            {
                // Tạo DTo
                DTO_SACH book = new DTO_SACH(int.Parse(txtMaSach.Text), txtTenSach.Text, txtTacGia.Text, int.Parse(txtTheLoai.Text), int.Parse(txtNamXuatBan.Text), txtNhaXuatBan.Text, int.Parse(txtTriGia.Text), "Het Hang", 0);
                // Them
                if (bllBook.themBook(book))
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
