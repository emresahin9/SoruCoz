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
    public partial class SoruCevaplama : Form
    {
        int i = 1;
        public SoruCevaplama()
        {
            InitializeComponent();
        }
        Veritabani veritabani = new Veritabani();
        Ogrenci _ogrenci = OgrenciGiris.ogrenci;
        private void SoruCevaplama_Load(object sender, EventArgs e)
        {
            veritabani.Open();
            veritabani.TestHazirlama(_ogrenci.no);
            veritabani.TabloDoldurma();
            label_aciklama.Text = veritabani.SoruGetir(_ogrenci.no);
        }

        private void simpleButton_cevap_Click(object sender, EventArgs e)
        {
            if (i != 21)
            {
                veritabani.SoruCevapla(textBox_cevap, _ogrenci.no);
                if(i!=20)
                    label_aciklama.Text = veritabani.SoruGetir(_ogrenci.no);
                progressBarControl.EditValue = i + 1;
                i++;
            }
            if(i==21)
            {
                textBox_cevap.Enabled = false;
                simpleButton_cevap.Enabled = false;
                label_aciklama.Text = "TEST BİTTİ";
                this.Hide();
                
            }
        }
    }
}
