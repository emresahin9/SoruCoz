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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }
        Veritabani veritabani = new Veritabani();
        Ogrenci _ogrenci = OgrenciGiris.ogrenci;
        Ogretmen _ogretmen = EgitmenGiris.ogretmen;
        private void Istatistik_Load(object sender, EventArgs e)
        {
            label_ogrencino.Visible = false;
            textBox_ogrencino.Visible = false;
            simpleButton_goster.Visible = false;
            if(_ogrenci.no!=0)
                veritabani.Istatistik(_ogrenci.no, chartControl1);
            else if(_ogretmen.no!=0)
            {
                label_ogrencino.Visible = true;
                textBox_ogrencino.Visible = true;
                simpleButton_goster.Visible = true;
            }
        }
        
        private void simpleButton_goster_Click(object sender, EventArgs e)
        {
            veritabani.Istatistik(Convert.ToInt32(textBox_ogrencino.Text), chartControl1);
        }
    }
}
