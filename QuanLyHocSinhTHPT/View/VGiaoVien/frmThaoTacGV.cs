using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using QuanLyHocSinhTHPT.Controller;
using QuanLyHocSinhTHPT.Models;

namespace QuanLyHocSinhTHPT.View.VGiaoVien
{
    public partial class frmThaoTacGV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*
        private GiaoVienController gvc;
        private string _ID = null;

        public frmThaoTacGV(string id)
        {
            InitializeComponent();
            _ID = id;
            gvc = new GiaoVienController();
            GiaoVien gv = new GiaoVien();
            if (id == null)
            {
                txtMaGV.Enabled = true;
                return;
            }
            gv = gvc.GetData(id);
            txtMaGV.Text = gv.MaGV;
            txtHoTen.Text = gv.HoTen;
            DateTime _NgaySinh = (Convert.ToDateTime(gv.NgaySinh));
            dtNgaySinh.Value = _NgaySinh;
            if (gv.GioiTinh == "False")
            {
                ckNam.Checked = true;
            }
            else if (gv.GioiTinh == "True")
                ckNu.Checked = true;
            txtSDT.Text = gv.Sdt;
            txtQueQuan.Text = gv.QueQuan;
            lblTen.Text = gv.HoTen;
            string gt = null;
            if (gv.GioiTinh == "False")
            {
                gt = "Nam";
            }
            else if (gv.GioiTinh == "True")
                gt = "Nữ";
            lblGoiTinh.Text = gt;
            int tuoi = DateTime.Now.Year - _NgaySinh.Year;
            lblTuoi.Text = tuoi.ToString() + " Tuổi";
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvc = new GiaoVienController();
            int gt = 0;
            if (gvc.CheckErr(txtMaGV.Text.Trim(), txtHoTen.Text.Trim(), dtNgaySinh.Value.ToString(), gt, txtSDT.Text.Trim(), txtQueQuan.Text.Trim()))
            {
                if (ckNam.Checked) gt = 0;
                if (ckNu.Checked) gt = 1;
                string _ngaysinh = dtNgaySinh.Value.Year + "/" + dtNgaySinh.Value.Month + "/" + dtNgaySinh.Value.Day;
                if (_ID == null)
                {
                    if (gvc.ThemGV(txtMaGV.Text.Trim(), txtHoTen.Text.Trim(), _ngaysinh, gt, txtSDT.Text.Trim(), txtQueQuan.Text.Trim()))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (gvc.SuaGV(txtMaGV.Text.Trim(), txtHoTen.Text.Trim(), _ngaysinh, gt, txtSDT.Text.Trim(), txtQueQuan.Text.Trim()))
                    {
                        MessageBox.Show("Thành Công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiSave_ItemClick(sender, e);
            this.Close();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        */
        #endregion

        public frmThaoTacGV(string _MaGV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _Sdt, string _DiaChi, string _MaMon)
        {
            InitializeComponent();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
    }
}