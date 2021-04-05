﻿using BLL;
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
    public partial class PL_Setting : Form
    {
        BLL_Setting bllSetting = new BLL_Setting();
        private PL_Setting_Edit plSettingEdit;
        public PL_Setting()
        {
            InitializeComponent();
        }

        private void PL_Setting_Load(object sender, EventArgs e)
        {
            dataGridViewSetting.DataSource = bllSetting.getQuyDinh();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewSetting.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewSetting.SelectedRows[0];
                int ID = Int16.Parse(row.Cells[0].Value.ToString());

                // Xóa
                if (bllSetting.xoaQuyDinh(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewSetting.DataSource = bllSetting.getQuyDinh();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn sách muốn xóa");
            }
        }

/*        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewSetting.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewSetting.SelectedRows[0];

                // Tạo DTo
                DTO_SETTING dtoSetting = new DTO_SETTING(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()); // Vì ID tự tăng nên để ID số gì cũng dc

                plSettingEdit = new PL_Setting_Edit(dtoSetting);
                plSettingEdit.EditDelegate = TestListen;
                plSettingEdit.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn độc giả muốn sửa");
            }
        }*/
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            PL_Setting_AddNew plSettingAddNew = new PL_Setting_AddNew();
            plSettingAddNew.TestDelegate = TestListen;
            plSettingAddNew.Show();
        }
        private void TestListen(string param)
        {
            // update DB 
            dataGridViewSetting.DataSource = bllSetting.getQuyDinh(); // refresh datagridview
            var x = param;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewSetting.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewSetting.SelectedRows[0];

                // Tạo DTo
                DTO_SETTING dtoSetting = new DTO_SETTING(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()); // Vì ID tự tăng nên để ID số gì cũng dc

                plSettingEdit = new PL_Setting_Edit(dtoSetting);
                plSettingEdit.EditDelegate = TestListen;
                plSettingEdit.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn độc giả muốn sửa");
            }
        }

    }
}
