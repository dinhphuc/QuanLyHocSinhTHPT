using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;

namespace QuanLyHocSinhTHPT.View.Main
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string padFile = "LgData.bin";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select TaiKhoan from Account where TaiKhoan='{0}' and MatKhau='{1}'", txtUseName.Text, txtPassWord.Text);
            DataTable dt = sqlHelper.Query(sql);

            if (dt.Rows.Count == 1)
            {
                SingletonData.Getlates().nguoidung = new TaiKhoan() { TenTaiKhoan = txtUseName.Text };
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ///////////////////////

                if (ckLuu.Checked)
                {
                    file.ghifileLG(padFile, txtUseName.Text.Trim(),
                txtPassWord.Text.Trim());
                    lblsuccess.Text = "✓ success";
                    ckLuu.Enabled = false;
                    btnDangNhap.Enabled = true;
                }
                else
                {
                    lblsuccess.Text = "X error";
                }
                this.Close();
            }
            else
            {
                SingletonData.Getlates().nguoidung = null;
                MessageBox.Show("Đăng nhập thất bại. Xem lại tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            ckLuu.Checked = true;
            try
            {
                TaiKhoan ac = new TaiKhoan();
                ac = file.docFileLG(padFile);
                txtUseName.Text = ac.TenTaiKhoan;
                txtPassWord.Text = ac.Matkhau;
            }
            catch
            { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}