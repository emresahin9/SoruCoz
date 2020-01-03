using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruÇöz
{
    public partial class SoruEkle : Form
    {
        public SoruEkle()
        {
            InitializeComponent();
        }
        Veritabani veritabani = new Veritabani();
        Ogretmen ogretmen=EgitmenGiris.ogretmen;
        private void simpleButton_ekle_Click(object sender, EventArgs e)
        {
            veritabani.Open();
            if (radioButton1.Checked)
            {
                if (veritabani.SoruEkle(textBox_aciklama, textBox_cevap, "baskent"))
                    XtraMessageBox.Show("SORU EKLENDİ");
                else
                    XtraMessageBox.Show("SORU EKLENMEDİ");
            }
            else if (radioButton2.Checked)
            {
                if (veritabani.SoruEkle(textBox_aciklama, textBox_cevap, "kıta"))
                    XtraMessageBox.Show("SORU EKLENDİ");
                else
                    XtraMessageBox.Show("SORU EKLENMEDİ");
            }
            else if (radioButton3.Checked)
            {
                if (veritabani.SoruEkle(textBox_aciklama, textBox_cevap, "bolge"))
                    XtraMessageBox.Show("SORU EKLENDİ");
                else
                    XtraMessageBox.Show("SORU EKLENMEDİ");
            }
            veritabani.Close();
            this.Hide();
        }

        private void SoruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
