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

namespace QuanLyHocSinhTHPT.View.VHocSinh
{
    public partial class frmMainHocSinh : Form
    {
        public frmMainHocSinh()
        {
            InitializeComponent();
        }

        private List<HocSinh> lstHS;
        private int CurCl = 0, CurR = 0;
        private string IDmember;
        private string MaHS = "";
        private string HoTen = "";
        private string DiaChi = "";
        private bool GioiTinh = false;
        private DateTime NgaySinh = DateTime.Now;
        private string Sdt = "";
        private string TenPhuHuynh = "";
        private string SDTphuHuynh = "";
        private string TenLop = "";

        private void frmMainHocSinh_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private int i = 0;

        private void dtgHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgHocSinh.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgHocSinh.CurrentCell.ColumnIndex;
            CurR = dtgHocSinh.CurrentCell.RowIndex;
            i = CurR;
            // show data
            txtID.Text = MaHS = lstHS[i].MaHS;
            txtTen.Text = HoTen = lstHS[i].HoTen;
            txtMaLop.Text = TenLop = lstHS[i].TenLop;
            txtDiaChi.Text = DiaChi = lstHS[i].DiaChi;
            if (lstHS[i].GioiTinh)
            {
                radNam.Checked = true;
                GioiTinh = true;
            }
            else
            {
                radNu.Checked = true;
                GioiTinh = false;
            }
            dateNgaySinh.Value = NgaySinh = lstHS[i].NgaySinh;
            dateNgaySinh.CustomFormat = "dd/mm/yyyy";
            txtSDT.Text = Sdt = lstHS[i].Sdt;
            txtTenPhuHuynh.Text = TenPhuHuynh = lstHS[i].TenPhuHuynh;
            txtSDTphuHuynh.Text = SDTphuHuynh = lstHS[i].SDTphuHuynh;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmThaoTacHS frmThem = new frmThaoTacHS(null, null, null, true, null, DateTime.Now, null, null, null, 1);
            frmThem.ShowDialog();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("Vui lòng chọn 1 Bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmThaoTacHS frmSua = new frmThaoTacHS(MaHS, HoTen, DiaChi, GioiTinh, Sdt, NgaySinh, TenPhuHuynh, SDTphuHuynh, TenLop, 2);
                frmSua.ShowDialog();
                Hienthi();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            file.ExportToExcel(dtgHocSinh);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (IDmember == null)
            {
                MessageBox.Show("Vui lòng chọn 1 Bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                View.VDiemHS.frmDiemHS frmdiem = new VDiemHS.frmDiemHS(IDmember,1);
                frmdiem.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (IDmember != null)
            {
                if (IDmember == "HSDEL")
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chọn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (HocSinhController.XoaHS(IDmember))
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

        public void Hienthi()
        {
            lstHS = HocSinhController.getAllDataHS();
            DataTable dt = ViewHelper.ToDataTable<HocSinh>(lstHS);
            dtgHocSinh.DataSource = dt;
            dtgHocSinh.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dt.Columns["MaHS"].ColumnName = "Mã HS";
            dt.Columns["HoTen"].ColumnName = "Họ Tên";
            dt.Columns["NgaySinh"].ColumnName = "Ngày Sinh";
            dt.Columns["DiaChi"].ColumnName = "Địa Chỉ";
            dt.Columns["GioiTinh"].ColumnName = "Giới Tính (Nữ/nam ✓)";
            dt.Columns["Sdt"].ColumnName = "SĐT";
            dt.Columns["TenPhuHuynh"].ColumnName = "Tên Phụ Huynh";
            dt.Columns["SDTphuHuynh"].ColumnName = "SDT Phụ Huynh";
            dt.Columns["TenLop"].ColumnName = "Mã Lớp";
            int i = 0;
            foreach (DataGridViewColumn col in dtgHocSinh.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgHocSinh.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgHocSinh.CurrentCell = dtgHocSinh[CurCl, CurR]; } catch { }
            dtgHocSinh.Refresh();
        }
    }
}