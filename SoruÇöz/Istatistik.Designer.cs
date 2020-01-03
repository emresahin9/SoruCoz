namespace SoruÇöz
{
    partial class Istatistik
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBar3DSeriesView stackedBar3DSeriesView1 = new DevExpress.XtraCharts.StackedBar3DSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBar3DSeriesView stackedBar3DSeriesView2 = new DevExpress.XtraCharts.StackedBar3DSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istatistik));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.label_ogrencino = new System.Windows.Forms.Label();
            this.textBox_ogrencino = new System.Windows.Forms.TextBox();
            this.simpleButton_goster = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBar3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBar3DSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram3D1.RotationMatrixSerializable = "0.983368778546759;-0.0284791862878555;0.179373301602818;0;-0.000746009563016894;0" +
    ".986987654732649;0.160794318541213;0;-0.181618525622378;-0.158253926819474;0.970" +
    "551598729846;0;0;0;0;1";
            xyDiagram3D1.ZoomPercent = 150;
            this.chartControl1.Diagram = xyDiagram3D1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(41, 108);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "DOĞRU";
            stackedBar3DSeriesView1.BarWidth = 1D;
            series1.View = stackedBar3DSeriesView1;
            series2.Name = "YANLIŞ";
            stackedBar3DSeriesView2.BarWidth = 1D;
            series2.View = stackedBar3DSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.Size = new System.Drawing.Size(1074, 465);
            this.chartControl1.TabIndex = 0;
            // 
            // label_ogrencino
            // 
            this.label_ogrencino.AutoSize = true;
            this.label_ogrencino.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.label_ogrencino.Location = new System.Drawing.Point(110, 19);
            this.label_ogrencino.Name = "label_ogrencino";
            this.label_ogrencino.Size = new System.Drawing.Size(231, 49);
            this.label_ogrencino.TabIndex = 2;
            this.label_ogrencino.Text = "Öğrenci No :";
            // 
            // textBox_ogrencino
            // 
            this.textBox_ogrencino.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.textBox_ogrencino.Location = new System.Drawing.Point(402, 21);
            this.textBox_ogrencino.Name = "textBox_ogrencino";
            this.textBox_ogrencino.Size = new System.Drawing.Size(264, 49);
            this.textBox_ogrencino.TabIndex = 0;
            // 
            // simpleButton_goster
            // 
            this.simpleButton_goster.Appearance.Font = new System.Drawing.Font("Sitka Small", 24F);
            this.simpleButton_goster.Appearance.Options.UseFont = true;
            this.simpleButton_goster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_goster.ImageOptions.Image")));
            this.simpleButton_goster.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_goster.ImageOptions.ImageToTextIndent = 25;
            this.simpleButton_goster.Location = new System.Drawing.Point(770, 12);
            this.simpleButton_goster.Name = "simpleButton_goster";
            this.simpleButton_goster.Size = new System.Drawing.Size(271, 76);
            this.simpleButton_goster.TabIndex = 1;
            this.simpleButton_goster.Text = "GÖSTER";
            this.simpleButton_goster.Click += new System.EventHandler(this.simpleButton_goster_Click);
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 585);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton_goster);
            this.Controls.Add(this.textBox_ogrencino);
            this.Controls.Add(this.label_ogrencino);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBar3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBar3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label label_ogrencino;
        private System.Windows.Forms.TextBox textBox_ogrencino;
        private DevExpress.XtraEditors.SimpleButton simpleButton_goster;
    }
}