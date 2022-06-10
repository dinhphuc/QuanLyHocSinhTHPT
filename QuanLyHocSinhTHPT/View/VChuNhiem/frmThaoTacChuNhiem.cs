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

namespace QuanLyHocSinhTHPT.View.VChuNhiem
{
    public partial class frmThaoTacChuNhiem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int state;
        private List<GiaoVien> listGV = new List<GiaoVien>();
        private List<Lop> listLop = new List<Lop>();
        public frmThaoTacChuNhiem(string _MaGV, string _MaLop, string _NamHoc, int _state)
        {
            InitializeComponent();
            txtNamHoc.Text = _NamHoc;
            state = _state;
            if (state == 1)
            {
                cbTenGV.Enabled = false;
                cbTenLop.Enabled = false;
            }
            //Xử lý giáo viên ,lớp
            using (var db = setupConection.ConnectionFactory())
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                listGV = db.Query<GiaoVien>("SELECT MaGV,HoTen FROM dbo.GiaoVien").ToList();
                for (int i = 0; i < listGV.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listGV[i].HoTen.ToString();
                    item.Value = listGV[i].MaGV.ToString();
                    cbTenGV.Items.Add(item);
                    if (_MaGV == listGV[i].MaGV)
                    {
                        cbTenGV.SelectedIndex = i;
                    }
                }

                listLop = db.Query<Lop>("SELECT * FROM dbo.Lop").ToList();
                for (int i = 0; i < listLop.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = listLop[i].TenLop.ToString();
                    item.Value = listLop[i].MaLop.ToString();
                    cbTenLop.Items.Add(item);
                    if (_MaLop == listLop[i].MaLop)
                    {
                        cbTenLop.SelectedIndex = i;
                    }
                }
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ChuNhiemController.checkInputCN(txtNamHoc.Text))
            {
                string maGV = listGV.Find(x => x.HoTen == cbTenGV.Text).MaGV;
                string maLop = listLop.Find(x => x.TenLop == cbTenLop.Text).MaLop;
                if (state == 0)
                {
                    if (ChuNhiemController.ThemCN(maGV, maLop, txtNamHoc.Text))
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
                    if (ChuNhiemController.SuaCN(maGV, maLop, txtNamHoc.Text))
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
    }
}
