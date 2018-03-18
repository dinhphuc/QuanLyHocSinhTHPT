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
            dt.Columns["MaMon"].ColumnName = "Môn Giảng Dạy";
            int i = 0;
            foreach (DataGridViewColumn col in dtgrGV.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                dtgrGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                i++;
            }
            try { dtgrGV.CurrentCell = dtgrGV[CurCl, CurR]; } catch { }
            // lblTongSL.Text = GetTongSobanGhi("select * from GiaoVien").ToString();
            dtgrGV.Refresh();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
        }

        private void frmMainGiaoVien_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
    }
}