using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Helper;

namespace QuanLyHocSinhTHPT.View.VGiaoVien
{
    public partial class UserControlGiaoVien : UserControl
    {
        public UserControlGiaoVien()
        {
            InitializeComponent();
        }

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
            foreach (DataGridViewColumn col in dtgrGV.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            try { dtgrGV.CurrentCell = dtgrGV[CurCl, CurR]; } catch { }
            // lblTongSL.Text = GetTongSobanGhi("select * from GiaoVien").ToString();
            dtgrGV.Refresh();
        }

        private int CurCl = 0, CurR = 0;
        private string _Query = "select * from GiaoVien";
        private string IDmember;

        private void UserControlGiaoVien_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void dtgrGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmember = dtgrGV.CurrentRow.Cells[0].Value.ToString();
            CurCl = dtgrGV.CurrentCell.ColumnIndex;
            CurR = dtgrGV.CurrentCell.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}