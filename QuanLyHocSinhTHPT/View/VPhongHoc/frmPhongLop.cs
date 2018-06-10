using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.View.VPhongHoc
{
    public partial class frmPhongLop : Form
    {
        public frmPhongLop()
        {
            InitializeComponent();
        }

        //var
        private List<PhongLop> lstPhongLop;

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaPhong;
        private string SoPhong;
        private string MaLop;
        private string TenLop;
        private string KipHoc;
        private string ID;
        private string HocKyNamHoc;

        private void frmMainPhongHoc_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private int i = 0;

        private void dtgPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgPhongHoc.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgPhongHoc.CurrentCell.ColumnIndex;
            CurR = dtgPhongHoc.CurrentCell.RowIndex;
            i = CurR;
            // show data
            ID= lstPhongLop[i].ID;
            txtMaPhong.Text = MaPhong = lstPhongLop[i].MaPhong;
            txtSoPhong.Text = SoPhong = lstPhongLop[i].SoPhong;
            txtTenlop.Text = TenLop = lstPhongLop[i].TenLop;
            txtMaLop.Text = MaLop = lstPhongLop[i].MaLop;
            txtKip.Text = KipHoc = lstPhongLop[i].KipHoc;
            txtKyHoc.Text = HocKyNamHoc = lstPhongLop[i].HocKyNamHoc;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            VPhongHoc.frmThaoTacPhongLop frm = new frmThaoTacPhongLop(null, null, null, null, null, 1);
            frm.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            VPhongHoc.frmThaoTacPhongLop frm = new frmThaoTacPhongLop(ID, MaPhong, MaLop, KipHoc, HocKyNamHoc, 2);
            frm.ShowDialog();
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "KHDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (PhongLopController.DelRoomClass(IDmember))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Hienthi();
                        IDmember = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            file.ExportToExcel(dtgPhongHoc);
        }

        public void Hienthi()
        {
            lstPhongLop = PhongLopController.GetAllDataRoomClass();
            DataTable dt = ViewHelper.ToDataTable<PhongLop>(lstPhongLop);
            dtgPhongHoc.DataSource = dt;
            dtgPhongHoc.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["ID"].ColumnName = "ID";
            dt.Columns["MaPhong"].ColumnName = "Mã phòng";
            dt.Columns["SoPhong"].ColumnName = "Số phòng";
            dt.Columns["MaLop"].ColumnName = "Mã lớp";
            dt.Columns["TenLop"].ColumnName = "Tên lớp";
            dt.Columns["KipHoc"].ColumnName = "Kíp học";
            dt.Columns["HocKyNamHoc"].ColumnName = "Học kỳ";
            int i = 0;
            foreach (DataGridViewColumn col in dtgPhongHoc.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgPhongHoc.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgPhongHoc.CurrentCell = dtgPhongHoc[CurCl, CurR]; } catch { }
            dtgPhongHoc.Refresh();
        }
    }
}