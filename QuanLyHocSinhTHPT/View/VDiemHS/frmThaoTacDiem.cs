using Dapper;
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

namespace QuanLyHocSinhTHPT.View.VDiemHS
{
    public partial class frmThaoTacDiem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _state;
        List<HocSinh> lstHS; List<MonHoc> lstMonHoc;
        public frmThaoTacDiem(string _MaMH, string _MaHS, double _DiemMieng, double _Diem15p, double _Diem1h, double _DiemHK, int state)
        {
            InitializeComponent();
            _state = state;
            if (state == 2)
            {
                cbTenHS.Enabled = false; cbTenMon.Enabled = false;
            }
            txtDiem15p.Text = _Diem15p.ToString();
            txtDiem1h.Text = _Diem1h.ToString();
            txtDiemMieng.Text = _DiemMieng.ToString();
            txtDiemHK.Text = _DiemHK.ToString();
            ///Thao tac ma lop
            ///1. Get all ma lop
            ///
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                lstHS = db.Query<HocSinh>("SELECT MaHS,HoTen FROM dbo.HocSinh").ToList();
                for (int i = 0; i < lstHS.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = lstHS[i].HoTen.ToString();
                    item.Value = lstHS[i].MaHS.ToString();
                    cbTenHS.Items.Add(item);
                    if (_MaHS == lstHS[i].MaHS)
                    {
                        cbTenHS.SelectedIndex = i;
                    }
                }
            }
            ///1. Get all ma Phong
            ///
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                lstMonHoc = db.Query<MonHoc>("SELECT MaMon,TenMon FROM dbo.MonHoc").ToList();
                for (int i = 0; i < lstMonHoc.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = lstMonHoc[i].TenMon.ToString();
                    item.Value = lstMonHoc[i].MaMon.ToString();
                    cbTenMon.Items.Add(item);
                    if (_MaMH == lstMonHoc[i].MaMon)
                    {
                        cbTenMon.SelectedIndex = i;
                    }
                }
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maHS = lstHS.Find(x => x.HoTen == cbTenHS.Text).MaHS;
            string maMon = lstMonHoc.Find(x => x.TenMon == cbTenMon.Text).MaMon;
            double diemMieng = 0;
            double diem15p = 0; double diem1h = 0; double diemHK = 0;
            if (!double.TryParse(txtDiemMieng.Text, out diemMieng)
                || !double.TryParse(txtDiem15p.Text, out diem15p)
                || !double.TryParse(txtDiem1h.Text, out diem1h)
                || !double.TryParse(txtDiemHK.Text, out diemHK))
            {
                MessageBox.Show("Xem lại dữ liệu điểm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_state == 1)
            {
                if (DiemController.ThemDiem(maMon, maHS,diemMieng,diem15p,diem1h,diemHK))
                {
                    MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (_state == 2)
            {
                if (DiemController.SuaDiem(maMon, maHS, diemMieng, diem15p, diem1h, diemHK))
                {
                    MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmThaoTacHS_Load(object sender, EventArgs e)
        {

        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiSave_ItemClick(sender, e);
            this.Close();
        }
    }
}