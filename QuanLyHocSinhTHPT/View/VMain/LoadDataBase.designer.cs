namespace QuanLyHocSinhTHPT.View.VMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadDataBase));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLgHT = new System.Windows.Forms.Button();
            this.lblsuccess = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(495, 54);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(27, 81);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.TabIndex = 44;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(195, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(284, 86);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 474);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(495, 21);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLgHT);
            this.panel1.Controls.Add(this.lblsuccess);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.ckLuu);
            this.panel1.Controls.Add(this.txtCSDL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radXacThucSQL);
            this.panel1.Controls.Add(this.radXacThucWindow);
            this.panel1.Controls.Add(this.txtTenMayChu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 420);
            this.panel1.TabIndex = 43;
            // 
            // btnLgHT
            // 
            this.btnLgHT.Location = new System.Drawing.Point(190, 372);
            this.btnLgHT.Name = "btnLgHT";
            this.btnLgHT.Size = new System.Drawing.Size(122, 31);
            this.btnLgHT.TabIndex = 50;
            this.btnLgHT.Text = "Vào Hệ Thống";
            this.btnLgHT.UseVisualStyleBackColor = true;
            this.btnLgHT.Click += new System.EventHandler(this.btnLgHT_Click);
            // 
            // lblsuccess
            // 
            this.lblsuccess.AutoSize = true;
            this.lblsuccess.ForeColor = System.Drawing.Color.Green;
            this.lblsuccess.Location = new System.Drawing.Point(249, 291);
            this.lblsuccess.Name = "lblsuccess";
            this.lblsuccess.Size = new System.Drawing.Size(0, 13);
            this.lblsuccess.TabIndex = 55;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(263, 326);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(163, 326);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 31);
            this.btnDangNhap.TabIndex = 48;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ckLuu
            // 
            this.ckLuu.AutoSize = true;
            this.ckLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ckLuu.Location = new System.Drawing.Point(87, 290);
            this.ckLuu.Name = "ckLuu";
            this.ckLuu.Size = new System.Drawing.Size(157, 17);
            this.ckLuu.TabIndex = 47;
            this.ckLuu.Text = "Lưu lại thông tin đăng nhập";
            this.ckLuu.UseVisualStyleBackColor = true;
            this.ckLuu.CheckedChanged += new System.EventHandler(this.ckLuu_CheckedChanged);
            // 
            // txtCSDL
            // 
            this.txtCSDL.Location = new System.Drawing.Point(190, 227);
            this.txtCSDL.MaxLength = 100;
            this.txtCSDL.Name = "txtCSDL";
            this.txtCSDL.Size = new System.Drawing.Size(218, 21);
            this.txtCSDL.TabIndex = 46;
            this.txtCSDL.Text = "QuanLyBanGiay";
            this.txtCSDL.TextChanged += new System.EventHandler(this.txtCSDL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tên cơ sở dữ liệu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(190, 170);
            this.txtMatKhau.MaxLength = 100;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(218, 21);
            this.txtMatKhau.TabIndex = 45;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(190, 144);
            this.txtTenDangNhap.MaxLength = 100;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(218, 21);
            this.txtTenDangNhap.TabIndex = 44;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên đăng nhập";
            // 
            // radXacThucSQL
            // 
            this.radXacThucSQL.AutoSize = true;
            this.radXacThucSQL.Location = new System.Drawing.Point(87, 94);
            this.radXacThucSQL.Name = "radXacThucSQL";
            this.radXacThucSQL.Size = new System.Drawing.Size(90, 17);
            this.radXacThucSQL.TabIndex = 43;
            this.radXacThucSQL.TabStop = true;
            this.radXacThucSQL.Text = "Xác Thục SQL";
            this.radXacThucSQL.UseVisualStyleBackColor = true;
            this.radXacThucSQL.CheckedChanged += new System.EventHandler(this.radXacThucSQL_CheckedChanged);
            // 
            // radXacThucWindow
            // 
            this.radXacThucWindow.AutoSize = true;
            this.radXacThucWindow.Location = new System.Drawing.Point(87, 70);
            this.radXacThucWindow.Name = "radXacThucWindow";
            this.radXacThucWindow.Size = new System.Drawing.Size(110, 17);
            this.radXacThucWindow.TabIndex = 42;
            this.radXacThucWindow.TabStop = true;
            this.radXacThucWindow.Text = "Xác Thực Window";
            this.radXacThucWindow.UseVisualStyleBackColor = true;
            this.radXacThucWindow.CheckedChanged += new System.EventHandler(this.radXacThucWindow_CheckedChanged);
            // 
            // txtTenMayChu
            // 
            this.txtTenMayChu.Location = new System.Drawing.Point(163, 34);
            this.txtTenMayChu.MaxLength = 100;
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(245, 21);
            this.txtTenMayChu.TabIndex = 41;
            this.txtTenMayChu.Text = ".\\PHUCBINZ";
            this.txtTenMayChu.TextChanged += new System.EventHandler(this.txtTenMayChu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tên máy chủ";
            // 
            // LoadDataBase
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(495, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoadDataBase";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Lấy dữ liệu database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadDataBase_FormClosing);
            this.Load += new System.EventHandler(this.LoadDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLgHT;
        private System.Windows.Forms.Label lblsuccess;
        private System.Windows.Forms.Button btnThoat;
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
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
    }
}