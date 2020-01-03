namespace SoruÇöz
{
    partial class SoruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruEkle));
            this.textBox_cevap = new System.Windows.Forms.TextBox();
            this.textBox_aciklama = new System.Windows.Forms.TextBox();
            this.label_aciklama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox_cevap
            // 
            this.textBox_cevap.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.textBox_cevap.Location = new System.Drawing.Point(386, 252);
            this.textBox_cevap.Name = "textBox_cevap";
            this.textBox_cevap.Size = new System.Drawing.Size(447, 49);
            this.textBox_cevap.TabIndex = 1;
            // 
            // textBox_aciklama
            // 
            this.textBox_aciklama.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.textBox_aciklama.Location = new System.Drawing.Point(386, 129);
            this.textBox_aciklama.Name = "textBox_aciklama";
            this.textBox_aciklama.Size = new System.Drawing.Size(447, 49);
            this.textBox_aciklama.TabIndex = 0;
            // 
            // label_aciklama
            // 
            this.label_aciklama.AutoSize = true;
            this.label_aciklama.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.label_aciklama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_aciklama.Location = new System.Drawing.Point(83, 129);
            this.label_aciklama.Name = "label_aciklama";
            this.label_aciklama.Size = new System.Drawing.Size(198, 49);
            this.label_aciklama.TabIndex = 30;
            this.label_aciklama.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(126, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 49);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cevap :";
            // 
            // simpleButton_ekle
            // 
            this.simpleButton_ekle.Appearance.Font = new System.Drawing.Font("Sitka Small", 24F);
            this.simpleButton_ekle.Appearance.Options.UseFont = true;
            this.simpleButton_ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_ekle.ImageOptions.Image")));
            this.simpleButton_ekle.ImageOptions.ImageIndex = 0;
            this.simpleButton_ekle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_ekle.ImageOptions.ImageToTextIndent = 30;
            this.simpleButton_ekle.Location = new System.Drawing.Point(445, 452);
            this.simpleButton_ekle.Name = "simpleButton_ekle";
            this.simpleButton_ekle.Size = new System.Drawing.Size(319, 116);
            this.simpleButton_ekle.TabIndex = 5;
            this.simpleButton_ekle.Text = "EKLE";
            this.simpleButton_ekle.Click += new System.EventHandler(this.simpleButton_ekle_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.radioButton1.Location = new System.Drawing.Point(252, 356);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 53);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Başkent";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.radioButton2.Location = new System.Drawing.Point(514, 356);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 53);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kıta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.radioButton3.Location = new System.Drawing.Point(727, 356);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(135, 53);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bölge";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.simpleButton_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_aciklama);
            this.Controls.Add(this.textBox_aciklama);
            this.Controls.Add(this.textBox_cevap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoruEkle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SoruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_cevap;
        private System.Windows.Forms.TextBox textBox_aciklama;
        public System.Windows.Forms.Label label_aciklama;
        public System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ekle;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}