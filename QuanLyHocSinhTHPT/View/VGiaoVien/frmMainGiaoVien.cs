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

namespace QuanLyHocSinhTHPT.View.VGiaoVien
{
    public partial class frmMainGiaoVien : Form
    {
        public frmMainGiaoVien()
        {
            InitializeComponent();
        }

        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private List<GiaoVien> lstGV;
        private string MaGV = "";
        private string HoTen = "";
        private DateTime NgaySinh = DateTime.Now;
        private bool GioiTinh = true;
        private string Sdt = "";
        private string TenMon = "";
        private string DiaChi = "";
        private int i = 0;

        public void Hienthi()
        {
            lstGV = GiaoVienController.getAllDataGV();
            DataTable dt = ViewHelper.ToDataTable<GiaoVien>(lstGV);
            dtgrGV.DataSource = dt;
            dtgrGV.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaGV"].ColumnName = "Mã Giáo Viên";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ ✓/nam)";
            dt.Columns["Sdt"].ColumnName = "Số Điện Thoại";
            dt.Columns["DiaChi"].ColumnName = "Địa Chỉ";
            dt.Columns["TenMon"].ColumnName = "Tên môn";
            int j = 0;
            foreach (DataGridViewColumn col in dtgrGV.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgrGV.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                j++;
            }
            try { dtgrGV.CurrentCell = dtgrGV[CurCl, CurR]; } catch { }
            // lblTongSL.Text = GetTongSobanGhi("select * from GiaoVien").ToString();
            dtgrGV.Refresh();
        }

        private void dtgrGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrGV.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgrGV.CurrentCell.ColumnIndex;
            CurR = dtgrGV.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtID.Text = MaGV = lstGV[i].MaGV;
            txtHoTen.Text = HoTen = lstGV[i].HoTen;
            txtMon.Text = TenMon = lstGV[i].TenMon;
            txtDiaChi.Text = DiaChi = lstGV[i].DiaChi;
            if (lstGV[i].GioiTinh)
            {
                radNam.Checked = true;
                GioiTinh = true;
            }
            else
            {
                radNu.Checked = true;
                GioiTinh = false;
            }
            dtpNgaySinh.Value = NgaySinh = lstGV[i].NgaySinh;
            txtSDT.Text = Sdt = lstGV[i].Sdt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmThaoTacGV frmThem = new frmThaoTacGV(null, null, DateTime.Now, true, null, null, null, 1);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            file.ExportToExcel(dtgrGV);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("No Select!!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmThaoTacGV frmSua = new frmThaoTacGV(MaGV, HoTen, NgaySinh, GioiTinh, Sdt, DiaChi, TenMon, 2);
                frmSua.ShowDialog();
                Hienthi();
            }
        }

        private void frmMainGiaoVien_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
    }
}