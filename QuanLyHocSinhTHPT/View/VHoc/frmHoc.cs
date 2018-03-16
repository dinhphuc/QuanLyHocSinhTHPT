using QuanLyHocSinhTHPT.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.View.VHoc
{
    public partial class frmHoc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*
        public frmHoc()
        {
            InitializeComponent();
            Hienthi(_Query);
        }
        public int GetTongSobanGhi(string s)
        {
            DataTable dt = sqlHelper.Query(s);
            return dt.Rows.Count;
        }
        public void Hienthi(string _Query)
        {
            DataTable dt = sqlHelper.Query(_Query);
            dtgrv.DataSource = dt;
            dtgrv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaHS"].ColumnName = "Mã HS";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["MaMH"].ColumnName = "Mã Môn Học";
            dt.Columns["TenMon"].ColumnName = "Tên Môn";
            dt.Columns["HeSo"].ColumnName = "Hệ Số";
            dt.Columns["DiemTongKet"].ColumnName = "Điểm Tổng Kết";
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; } catch { }
            lblTongSL.Text = GetTongSobanGhi("select * from Hoc").ToString();
            dtgrv.Refresh();
        }
        int CurCl = 0, CurR = 0;
        private string _Query = "SELECT Hoc.MaHS, HoTen, NgaySinh, MaMH, TenMon, HeSo, DiemTongKet FROM HocSinh, MonHoc, Hoc WHERE hoc.MaHS= HocSinh.MaHS AND Hoc.MaMH= MonHoc.MaMon";
        string IDmember;
        string IDmember1;

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            IDmember1 = dtgrv.CurrentRow.Cells[3].Value.ToString();
            CurCl = dtgrv.CurrentCell.ColumnIndex;
            CurR = dtgrv.CurrentCell.RowIndex;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmThaoTacHoc frm = new frmThaoTacHoc(IDmember, IDmember1);
            frm.ShowDialog();
            Hienthi(_Query);
        }

        private void sobanGhi_TextChanged(object sender, EventArgs e)
        {
            int sobanghi;
            if (sobanGhi.Text.Trim() == "")
            {
                sobanghi = 10;
                _Query = string.Format("SELECT TOP {0} Hoc.MaHS, HoTen, NgaySinh, MaMH, TenMon, HeSo, DiemTongKet FROM HocSinh, MonHoc, Hoc WHERE hoc.MaHS= HocSinh.MaHS AND Hoc.MaMH= MonHoc.MaMon ", sobanghi);
                Hienthi(_Query);
                return;
            }
            if (!int.TryParse(sobanGhi.Text.Trim(), out sobanghi))
            {
                MessageBox.Show("Sai Định Dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            _Query = string.Format("SELECT TOP {0} Hoc.MaHS, HoTen, NgaySinh, MaMH, TenMon, HeSo, DiemTongKet FROM HocSinh, MonHoc, Hoc WHERE hoc.MaHS= HocSinh.MaHS AND Hoc.MaMH= MonHoc.MaMon ", sobanghi);
            Hienthi(_Query);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThaoTacHoc frm = new frmThaoTacHoc(null, null);
            frm.ShowDialog();
            Hienthi(_Query);
        }

*/
        #endregion
    }
}