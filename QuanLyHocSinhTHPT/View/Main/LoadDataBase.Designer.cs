namespace QuanLyHocSinhTHPT.View.Main
{
    partial class LoadDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.ckLuu = new System.Windows.Forms.CheckBox();
            this.txtCSDL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radXacThucSQL = new System.Windows.Forms.RadioButton();
            this.radXacThucWindow = new System.Windows.Forms.RadioButton();
            this.txtTenMayChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblsuccess = new System.Windows.Forms.Label();
            this.btnLgHT = new System.Windows.Forms.Button();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(126, 306);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ckLuu
            // 
            this.ckLuu.AutoSize = true;
            this.ckLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ckLuu.Location = new System.Drawing.Point(50, 270);
            this.ckLuu.Name = "ckLuu";
            this.ckLuu.Size = new System.Drawing.Size(157, 17);
            this.ckLuu.TabIndex = 6;
            this.ckLuu.Text = "Lưu lại thông tin đăng nhập";
            this.ckLuu.UseVisualStyleBackColor = true;
            this.ckLuu.CheckedChanged += new System.EventHandler(this.ckLuu_CheckedChanged);
            // 
            // txtCSDL
            // 
            this.txtCSDL.Location = new System.Drawing.Point(153, 210);
            this.txtCSDL.MaxLength = 100;
            this.txtCSDL.Name = "txtCSDL";
            this.txtCSDL.Size = new System.Drawing.Size(218, 21);
            this.txtCSDL.TabIndex = 5;
            this.txtCSDL.TextChanged += new System.EventHandler(this.txtCSDL_TextChanged);
            this.txtCSDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMayChu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên cơ sở dữ liệu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(153, 150);
            this.txtMatKhau.MaxLength = 100;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(218, 21);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMayChu_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(153, 124);
            this.txtTenDangNhap.MaxLength = 100;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(218, 21);
            this.txtTenDangNhap.TabIndex = 3;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMayChu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên đăng nhập";
            // 
            // radXacThucSQL
            // 
            this.radXacThucSQL.AutoSize = true;
            this.radXacThucSQL.Location = new System.Drawing.Point(50, 74);
            this.radXacThucSQL.Name = "radXacThucSQL";
            this.radXacThucSQL.Size = new System.Drawing.Size(90, 17);
            this.radXacThucSQL.TabIndex = 2;
            this.radXacThucSQL.TabStop = true;
            this.radXacThucSQL.Text = "Xác Thục SQL";
            this.radXacThucSQL.UseVisualStyleBackColor = true;
            this.radXacThucSQL.CheckedChanged += new System.EventHandler(this.radXacThucSQL_CheckedChanged);
            // 
            // radXacThucWindow
            // 
            this.radXacThucWindow.AutoSize = true;
            this.radXacThucWindow.Location = new System.Drawing.Point(50, 50);
            this.radXacThucWindow.Name = "radXacThucWindow";
            this.radXacThucWindow.Size = new System.Drawing.Size(110, 17);
            this.radXacThucWindow.TabIndex = 1;
            this.radXacThucWindow.TabStop = true;
            this.radXacThucWindow.Text = "Xác Thực Window";
            this.radXacThucWindow.UseVisualStyleBackColor = true;
            this.radXacThucWindow.CheckedChanged += new System.EventHandler(this.radXacThucWindow_CheckedChanged);
            // 
            // txtTenMayChu
            // 
            this.txtTenMayChu.Location = new System.Drawing.Point(126, 14);
            this.txtTenMayChu.MaxLength = 100;
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(245, 21);
            this.txtTenMayChu.TabIndex = 0;
            this.txtTenMayChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMayChu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên máy chủ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(215, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblsuccess
            // 
            this.lblsuccess.AutoSize = true;
            this.lblsuccess.ForeColor = System.Drawing.Color.Green;
            this.lblsuccess.Location = new System.Drawing.Point(212, 271);
            this.lblsuccess.Name = "lblsuccess";
            this.lblsuccess.Size = new System.Drawing.Size(0, 13);
            this.lblsuccess.TabIndex = 25;
            // 
            // btnLgHT
            // 
            this.btnLgHT.Location = new System.Drawing.Point(153, 347);
            this.btnLgHT.Name = "btnLgHT";
            this.btnLgHT.Size = new System.Drawing.Size(118, 23);
            this.btnLgHT.TabIndex = 9;
            this.btnLgHT.Text = "Vào Hệ Thống";
            this.btnLgHT.UseVisualStyleBackColor = true;
            this.btnLgHT.Click += new System.EventHandler(this.btnLgHT_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // LoadDataBase
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 395);
            this.Controls.Add(this.btnLgHT);
            this.Controls.Add(this.lblsuccess);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.ckLuu);
            this.Controls.Add(this.txtCSDL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radXacThucSQL);
            this.Controls.Add(this.radXacThucWindow);
            this.Controls.Add(this.txtTenMayChu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LoadDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy dữ liệu database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadDataBase_FormClosing);
            this.Load += new System.EventHandler(this.LoadDataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox ckLuu;
        private System.Windows.Forms.TextBox txtCSDL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radXacThucSQL;
        private System.Windows.Forms.RadioButton radXacThucWindow;
        private System.Windows.Forms.TextBox txtTenMayChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblsuccess;
        private System.Windows.Forms.Button btnLgHT;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}