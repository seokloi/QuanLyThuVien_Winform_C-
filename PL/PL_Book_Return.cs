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
    public partial class PL_Book_Return : Form
    {
        private BLL_PhieuMuonSach bllphieums = new BLL_PhieuMuonSach();
        private BLL_PhieuTraSach bllphieuts = new BLL_PhieuTraSach();

        public PL_Book_Return()
        {
            InitializeComponent();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (kiemTra_DauVao())
            {
                try
                {
                    DataTable dtsachm = bllphieums.laySachMuon(Int32.Parse(ttbMaDocGia.Text));
                    MessageBox.Show("In");
                    capNhat_SachMuonDtgv(dtsachm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã độc giả không hợp lệ");
            }
        }

        private void capNhat_SachMuonDtgv(DataTable dtsachmuon)
        { 

            foreach (DataRow row in dtsachmuon.Rows)
            {
                string[] content = new string[] { row["id"].ToString(), row["TenSach"].ToString(),
                    row["TacGia"].ToString(), row["Ten"].ToString(), row["TinhTrang"].ToString(), row["TriGia"].ToString(), row["NhaXuatBan"].ToString(), row["NamXuatBan"].ToString() };
                dtgvSachMuon.Rows.Add(content);
            }
            dtgvSachMuon.ColumnCount = 8;
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            IEnumerable<DataGridViewRow> selectedSach = dtgvSachMuon.SelectedRows.Cast<DataGridViewRow>();
            List<int> lsidsach = new List<int>();

            foreach (DataGridViewRow row in selectedSach)
            {
                dtgvSachMuon.Rows.Remove(row);

                lsidsach.Add(Int32.Parse(row.Cells[0].Value.ToString()));
            }

            tra_Sach(lsidsach);
        }

        public void tra_Sach(List<int> lsidsach)
        {
            DTO_TRASACH dtotrasach = new DTO_TRASACH() { ID_USER = Int32.Parse(ttbMaDocGia.Text) };
            bllphieuts.themPhieuTraSach(ref dtotrasach, lsidsach);

            ttbSoNgayTT.Text = dtotrasach.SONGAYTRE.ToString();
            ttbNgayTra.Text = DateTime.Now.Date.ToString();
        }

        private void btnLapPhieuThuTP_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            PL_Home plhome = new PL_Home();

            this.Hide();
            plhome.Show();
        }

        private bool kiemTra_DauVao()
        {
            RegularExp reg = new RegularExp();

            if (reg.Is_Numbers_Only(ttbMaDocGia.Text))
            {
                return true;
            }

            return false;
        }
       
    }
}
