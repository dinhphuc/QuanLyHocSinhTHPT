using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyHocSinhTHPT.Helper;

namespace QuanLyHocSinhTHPT.View.VMonHoc
{
    public partial class frmMonHoc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*

        public frmMonHoc()
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
            dt.Columns["MaMon"].ColumnName = "Mã Môn Học";
            dt.Columns["TenMon"].ColumnName = "Tên Môn Học";
            dt.Columns["HeSo"].ColumnName = "Hệ Số";
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; } catch { }
            lblTongSL.Text = GetTongSobanGhi("select * from MonHoc").ToString();
            dtgrv.Refresh();
        }
        int CurCl = 0, CurR = 0;
        private string _Query = "select * from MonHoc";
        string IDmember;

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
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
            frmThaoTacmMH frm = new frmThaoTacmMH(IDmember);
            frm.ShowDialog();
            Hienthi(_Query);
        }

        private void sobanGhi_TextChanged(object sender, EventArgs e)
        {
            int sobanghi;
            if (sobanGhi.Text.Trim() == "")
            {
                sobanghi = 10;
                _Query = string.Format("select TOP {0} * from MonHoc ", sobanghi);
                Hienthi(_Query);
                return;
            }
            if (!int.TryParse(sobanGhi.Text.Trim(), out sobanghi))
            {
                MessageBox.Show("Sai Định Dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            _Query = string.Format("select TOP {0} * from MonHoc ", sobanghi);
            Hienthi(_Query);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThaoTacmMH frm = new frmThaoTacmMH(null);
            frm.ShowDialog();
            Hienthi(_Query);
        }

*/
        #endregion
    }
}