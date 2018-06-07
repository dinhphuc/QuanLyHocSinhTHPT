namespace QuanLyHocSinhTHPT.View.VDiemHS
{
    partial class frmMainThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.charDiemHS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.charDiemHS)).BeginInit();
            this.SuspendLayout();
            // 
            // charDiemHS
            // 
            chartArea1.Name = "ChartArea1";
            this.charDiemHS.ChartAreas.Add(chartArea1);
            this.charDiemHS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.charDiemHS.Legends.Add(legend1);
            this.charDiemHS.Location = new System.Drawing.Point(0, 0);
            this.charDiemHS.Name = "charDiemHS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "XuatSac";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Gioi";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Kha";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "TrungBinhKha";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "TrungBinh";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Yeu";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Kem";
            this.charDiemHS.Series.Add(series1);
            this.charDiemHS.Series.Add(series2);
            this.charDiemHS.Series.Add(series3);
            this.charDiemHS.Series.Add(series4);
            this.charDiemHS.Series.Add(series5);
            this.charDiemHS.Series.Add(series6);
            this.charDiemHS.Series.Add(series7);
            this.charDiemHS.Size = new System.Drawing.Size(1350, 729);
            this.charDiemHS.TabIndex = 0;
            this.charDiemHS.Text = "Thống kê điểm hs";
            title1.Name = "Điểm học sinh";
            this.charDiemHS.Titles.Add(title1);
            // 
            // frmMainThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.charDiemHS);
            this.Name = "frmMainThongKe";
            this.Text = "frmMainThongKe";
            this.Load += new System.EventHandler(this.frmMainThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charDiemHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart charDiemHS;
    }
}