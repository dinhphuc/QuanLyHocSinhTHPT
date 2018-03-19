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

namespace QuanLyHocSinhTHPT.View.VLop
{
    public partial class frmLop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*

        public frmLop()
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
            dt.Columns["Malop"].ColumnName = "Mã Lớp";
            dt.Columns["ViTri"].ColumnName = "Vị Trí";
            dt.Columns["SiSo"].ColumnName = "Sĩ Số";
            foreach (DataGridViewColumn col in dtgrv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrv.CurrentCell = dtgrv[CurCl, CurR]; } catch { }
            lblTongSL.Text = GetTongSobanGhi("select * from Lop").ToString();
            dtgrv.Refresh();
        }
        int CurCl = 0, CurR = 0;
        private string _Query = "select * from Lop";
        string IDmember;

        private void dtgrv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrv.CurrentRow.Cells[0].Value.ToString();
            //myvalue =dgvList.Rows[rowindex].Cells[columnindex].Value.ToString();
            CurCl = dtgrv.CurrentCell.ColumnIndex;
            CurR = dtgrv.CurrentCell.RowIndex;
        }

        private void sobanGhi_TextChanged(object sender, EventArgs e)
        {
            int sobanghi;
            if (sobanGhi.Text.Trim() == "")
            {
                sobanghi = 10;
                _Query = string.Format("select TOP {0} * from Lop ", sobanghi);
                Hienthi(_Query);
                return;
            }
            if (!int.TryParse(sobanGhi.Text.Trim(), out sobanghi))
            {
                MessageBox.Show("Sai Định Dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            _Query = string.Format("select TOP {0} * from Lop ", sobanghi);
            Hienthi(_Query);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmThaoTacLop frm = new frmThaoTacLop(IDmember);
            frm.ShowDialog();
            Hienthi(_Query);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThaoTacLop frm = new frmThaoTacLop(null);
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