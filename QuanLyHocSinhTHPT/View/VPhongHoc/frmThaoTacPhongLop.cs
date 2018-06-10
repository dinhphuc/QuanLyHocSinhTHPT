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

namespace QuanLyHocSinhTHPT.View.VPhongHoc
{
    public partial class frmThaoTacPhongLop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _state;
        List<Lop> lstLop; List<PhongHoc> lstPhongHoc;
        public frmThaoTacPhongLop(string ID
            ,string _MaPhong, string _MaLop, string _KipHoc, string _HocKyNamHoc, int state)
        {
            InitializeComponent();
            _state = state;
            if (state == 2)
            {
                txtID.Enabled = false;
            }
            txtID.Text = ID;
            txtKip.Text = _KipHoc;
            txtKyHoc.Text = _HocKyNamHoc;
            ///Thao tac ma lop
            ///1. Get all ma lop
            ///
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
              lstLop = db.Query<Lop>("SELECT MaLop,TenLop FROM dbo.Lop").ToList();
                for (int i = 0; i < lstLop.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = lstLop[i].TenLop.ToString();
                    item.Value = lstLop[i].MaLop.ToString();
                    cbTenLop.Items.Add(item);
                    if (_MaLop == lstLop[i].MaLop)
                    {
                        cbTenLop.SelectedIndex = i;
                    }
                }
            }
            ///1. Get all ma Phong
            ///
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
               lstPhongHoc = db.Query<PhongHoc>("SELECT MaPhong,SoPhong FROM dbo.PhongHoc").ToList();
                for (int i = 0; i < lstPhongHoc.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = lstPhongHoc[i].SoPhong.ToString();
                    item.Value = lstPhongHoc[i].MaPhong.ToString();
                    cbSoPhong.Items.Add(item);
                    if (_MaPhong == lstPhongHoc[i].MaPhong)
                    {
                        cbSoPhong.SelectedIndex = i;
                    }
                }
            }
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maPhong = lstPhongHoc.Find(x => x.SoPhong == cbSoPhong.Text).MaPhong;
            string malop = lstLop.Find(x => x.TenLop == cbTenLop.Text).MaLop;
            if (_state == 1)
            {
                if (PhongLopController.InsertRoomClass(txtID.Text, maPhong,malop,txtKip.Text,txtKyHoc.Text))
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
                if (PhongLopController.EditRoomClass(txtID.Text, maPhong, malop, txtKip.Text, txtKyHoc.Text))
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