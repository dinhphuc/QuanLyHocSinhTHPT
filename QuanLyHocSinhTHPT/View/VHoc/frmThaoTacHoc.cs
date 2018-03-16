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
using QuanLyHocSinhTHPT.Models;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Controller;

namespace QuanLyHocSinhTHPT.View.VHoc
{
    public partial class frmThaoTacHoc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region
        /*
        HocController hc;
        string _id1, _id2;
        public frmThaoTacHoc(string id1, string id2)
        {
            _id1 = id1;
            _id2 = id2;
            InitializeComponent();
            hc = new HocController();
            //Xử lý mã Môn
            DataTable mm = sqlHelper.Query("SELECT MaMon FROM MonHoc");
            List<DataRow> list = mm.AsEnumerable().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = list[i].ItemArray[0].ToString();
                item.Value = list[i].ItemArray[0].ToString();
                cbMaMon.Items.Add(item);
            }
            //Xử lý mã HocSinh
            DataTable mhs = sqlHelper.Query("SELECT MaHS FROM HocSinh");
            List<DataRow> list1 = mhs.AsEnumerable().ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                ComboboxItem item1 = new ComboboxItem();
                item1.Text = list1[i].ItemArray[0].ToString();
                item1.Value = list1[i].ItemArray[0].ToString();
                cbMaHS.Items.Add(item1);
            }
            if (id1 == null||id2==null)
            {
                cbMaMon.Enabled = true;
                cbMaHS.Enabled = true;
                groupBox1.Visible = false;
                picAvtat.Visible = false;
                return;
            }
            Diem h = new Diem();
            h = hc.GetData(id1,id2);

            txtDiemTK.Text = h.DiemTongKet;
            for (int i = 0; i < list.Count; i++)
            {
                if (h.MaMH == list[i].ItemArray[0].ToString())
                {
                    cbMaMon.SelectedIndex = i;
                    h.MaMH = cbMaMon.Text;
                    break;
                }
            }
            for (int i = 0; i < list1.Count; i++)
            {
                if (h.MaHS == list1[i].ItemArray[0].ToString())
                {
                    cbMaHS.SelectedIndex = i;
                    h.MaHS = cbMaHS.Text;
                    break;
                }
            }

            //string s = string.Format("SELECT * FROM HocSinh where MaHS={0}", id1);
            //DataTable dtIF = sqlHelper.Query(s);
            HocSinh hsif = new HocSinh();
            HocSinhController hscf = new HocSinhController();
            hsif = hscf.GetData(h.MaHS);
            string NS = DateTime.Parse(hsif.NgaySinh).Date.ToString() + DateTime.Parse(hsif.NgaySinh).Month.ToString() + DateTime.Parse(hsif.NgaySinh).Year.ToString();
            lblTen.Text = "Họ Tên: "+ hsif.HoTen;
            lblTuoi.Text = "Ngày Sinh: "+ NS;
            try
            {
                if (hsif.GioiTinh == "False")
                {
                    lblGioiTinh.Text = "Giới Tính: Nam";
                    picAvtat.Image = Image.FromFile(Application.StartupPath + "\\Resources\\user1600.png");
                }
                else if (hsif.GioiTinh == "True")
                {
                    lblGioiTinh.Text = "Giới Tính: Nữ";
                    picAvtat.Image = Image.FromFile(Application.StartupPath + "\\Resources\\nanny-icon.png");
                }
            }
            catch { }
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

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hc = new HocController();
            if (hc.CheckErr(cbMaMon.Text.Trim(), cbMaHS.Text.Trim(), txtDiemTK.Text.Trim()))
            {
                if (_id1 == null || _id2 == null)
                {
                    if (hc.ThemH(cbMaMon.Text.Trim(), cbMaHS.Text.Trim(), txtDiemTK.Text.Trim()))
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
                    if (hc.SuaH(cbMaMon.Text.Trim(), cbMaHS.Text.Trim(), txtDiemTK.Text.Trim(), cbMaMon.Text.Trim(), cbMaHS.Text.Trim()))
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

        */
        #endregion
    }
}