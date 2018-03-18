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

namespace QuanLyHocSinhTHPT.View.VHocSinh
{
    public partial class frmHocSinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*

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
            dt.Columns["MaHS"].ColumnName = "Mã Học Sinh";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ ✓/nam)";
            dt.Columns["TenBo"].ColumnName = "Tên Bố";
            dt.Columns["TenMe"].ColumnName = "Tên Mẹ";
            dt.Columns["MaLop"].ColumnName = "Mã Lớp";
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; } catch { }

            lblTongSL.Text = GetTongSobanGhi("select * from HocSinh").ToString();
            dtgrv.Refresh();
        }

        private int CurCl = 0, CurR = 0;
        private string _Query = "select * from HocSinh";
        private string IDmember;

        public frmHocSinh()
        {
            InitializeComponent();
            Hienthi(_Query);
        }

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
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
            frmThaoTacHS frm = new frmThaoTacHS(IDmember);
            frm.ShowDialog();
            Hienthi(_Query);
        }

        private void SobanGhi_TextChanged(object sender, EventArgs e)
        {
            int sobanghi;
            if (SobanGhi.Text.Trim() == "")
            {
                sobanghi = 10;
                _Query = string.Format("select TOP {0} * from HocSinh ", sobanghi);
                Hienthi(_Query);
                return;
            }
            if (!int.TryParse(SobanGhi.Text.Trim(), out sobanghi))
            {
                MessageBox.Show("Sai Định Dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            _Query = string.Format("select TOP {0} * from HocSinh ", sobanghi);
            Hienthi(_Query);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThaoTacHS frm = new frmThaoTacHS(null);
            frm.ShowDialog();
            Hienthi(_Query);
        }

*/
        #endregion

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
    }
}