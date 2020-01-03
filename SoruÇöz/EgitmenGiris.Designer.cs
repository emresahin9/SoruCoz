namespace SoruÇöz
{
    partial class EgitmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgitmenGiris));
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton_giris = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.textBox_sifre.Location = new System.Drawing.Point(386, 339);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(447, 49);
            this.textBox_sifre.TabIndex = 1;
            // 
            // textBox_isim
            // 
            this.textBox_isim.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.textBox_isim.Location = new System.Drawing.Point(386, 211);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(447, 49);
            this.textBox_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.label1.Location = new System.Drawing.Point(175, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 19.8F);
            this.label2.Location = new System.Drawing.Point(168, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(412, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 59);
            this.label3.TabIndex = 7;
            this.label3.Text = "EĞİTMEN GİRİŞİ";
            // 
            // simpleButton_giris
            // 
            this.simpleButton_giris.Appearance.Font = new System.Drawing.Font("Sitka Small", 24F);
            this.simpleButton_giris.Appearance.Options.UseFont = true;
            this.simpleButton_giris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_giris.ImageOptions.Image")));
            this.simpleButton_giris.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_giris.ImageOptions.ImageToTextIndent = 20;
            this.simpleButton_giris.Location = new System.Drawing.Point(445, 452);
            this.simpleButton_giris.Name = "simpleButton_giris";
            this.simpleButton_giris.Size = new System.Drawing.Size(305, 120);
            this.simpleButton_giris.TabIndex = 2;
            this.simpleButton_giris.Text = "GİRİŞ";
            this.simpleButton_giris.Click += new System.EventHandler(this.simpleButton_giris_Click);
            // 
            // EgitmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 632);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton_giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_isim);
            this.Controls.Add(this.textBox_sifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EgitmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton_giris;
    }
}