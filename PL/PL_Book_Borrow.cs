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
    public partial class PL_Book_Borrow : Form
    {
        private BLL_Sach bllsach = new BLL_Sach();
        private BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();

        public PL_Book_Borrow()
        {
            InitializeComponent();

            capNhat_SachDtgv();
        }
        //-->
        private void capNhat_SachDtgv()
        {
            DataTable dttbsach = bllsach.laySach();

            foreach (DataRow row in dttbsach.Rows)
            {
                string[] content = new string[] { row["id"].ToString(), row["TenSach"].ToString(),
                    row["TacGia"].ToString(), row["Ten"].ToString(), row["TinhTrang"].ToString() };
                dtgvSach.Rows.Add(content);
            }
            dtgvSach.ColumnCount = 5;
            dtgvSachMuon.ColumnCount = 5;
        }  

        
        private void btnTimSach_Click(object sender, EventArgs e)
        {
            if (kiemTra_DauVao(1))
            {
                try
                {
                    DataTable foundsachs = bllsach.laySach(Int32.Parse(ttbMaSach.Text));
                    capNhat_SachDtgv(foundsachs);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã sách không hợp lệ");
            }
        }
        //-->
        private void capNhat_SachDtgv(DataTable dtfoundsach)
        {
            int positionsach = 0;
           
            foreach (DataRow row in dtfoundsach.Rows)
            {
                foreach (DataGridViewRow gvrow in dtgvSach.Rows)
                {
                    gvrow.DefaultCellStyle.BackColor = Color.White;

                    if (row["id"].ToString() == gvrow.Cells[0].Value.ToString())
                    {
                        dtgvSach.Rows.Remove(gvrow);
                        dtgvSach.Rows.Insert(positionsach, gvrow);
                        dtgvSach.Rows[positionsach++].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
               
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (kiemTra_DauVao())
            {
                DTO_MUONSACH dtomuonsach = new DTO_MUONSACH() { ID_USER = Int32.Parse(ttbMaDocGia.Text) };
                ttbNgayMuon.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

                List<int> lsidsachmuon = lay_MaSachMuon();
                
                try
                {
                    if (bllphieums.themPhieuMuonSach(dtomuonsach, lsidsachmuon))
                    {
                        MessageBox.Show("Lập phiếu thành công");
                    }
                    else
                    {
                        // NOT FINISHED
                        MessageBox.Show("Lập phiếu thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã độc giả không hợp lệ");
            }

            
        }
        //-->
        private List<int> lay_MaSachMuon()
        {
            
            IEnumerable<DataGridViewRow> lssachmuon = dtgvSachMuon.Rows.Cast<DataGridViewRow>();
            List<int> lsidsachmuon = new List<int>();

            foreach (DataGridViewRow sach in lssachmuon)
            {
                lsidsachmuon.Add(Int32.Parse(sach.Cells["dtgvsachmMaSach"].Value.ToString()));
            }

            return lsidsachmuon;
        }

        private void btnDichPhai_Click(object sender, EventArgs e)
        {
            IEnumerable<DataGridViewRow> selectedSach = dtgvSach.SelectedRows.Cast<DataGridViewRow>();

            foreach (DataGridViewRow row in selectedSach)
            {
                dtgvSach.Rows.Remove(row);
                dtgvSachMuon.Rows.Add(row);
            }
        }

        private void btnDichTrai_Click(object sender, EventArgs e)
        {
            IEnumerable<DataGridViewRow> selectedSach = dtgvSachMuon.SelectedRows.Cast<DataGridViewRow>();

            foreach (DataGridViewRow row in selectedSach)
            {
                dtgvSachMuon.Rows.Remove(row);
                dtgvSach.Rows.Add(row);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();

            this.Hide();
            plhome.Show();
        }

        private bool kiemTra_DauVao(int ctrolluon = 0)
        {
            RegularExp reg = new RegularExp();

            if (ctrolluon == 0)
            {
                if (reg.Is_Numbers_Only(ttbMaDocGia.Text))
                {
                    return true;
                }
            }
            else
            {
                if (reg.Is_Numbers_Only(ttbMaSach.Text))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
