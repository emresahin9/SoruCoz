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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        
        Veritabani veritabani = new Veritabani();
        Ogretmen _ogretmen = EgitmenGiris.ogretmen;
        Ogrenci _ogrenci = OgrenciGiris.ogrenci;
        SoruCevaplama sorucevaplama;
        EgitmenGiris egitmengiris;
        OgrenciGiris ogrencigiris;
        SoruEkle soruekle;
        Istatistik istatistik;

        public void AnaSayfa_Load(object sender, EventArgs e)
        {
            barButtonItemsorucoz.Enabled = false;
            barButton_soruekle.Enabled = false;
            barButtonItem_istatistik.Enabled = false;
            barButtonItem_cikis.Enabled = false;
        }

        public void barButtonItem_yenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_ogrenci.no!=0)
            {
                barButtonItemsorucoz.Enabled = true;
                barButton_egitmengiris.Enabled = false;
                barButton_ogrencigiris.Enabled = false;
                barButtonItem_istatistik.Enabled = true;
                barButtonItem_cikis.Enabled = true;
            }
            else if(_ogretmen.no!=0)
            {
                barButton_soruekle.Enabled = true;
                barButton_egitmengiris.Enabled = false;
                barButton_ogrencigiris.Enabled = false;
                barButtonItem_istatistik.Enabled = true;
                barButtonItem_cikis.Enabled = true;
            }
            else
            {
                barButtonItemsorucoz.Enabled = false;
                barButton_soruekle.Enabled = false;
                barButton_egitmengiris.Enabled = true;
                barButton_ogrencigiris.Enabled = true;
                barButtonItem_cikis.Enabled = false;
            }
        }
        
        private void barButtonItemsorucoz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                sorucevaplama = new SoruCevaplama();
                sorucevaplama.MdiParent = this;
                sorucevaplama.Show();
        }

        private void barButton_egitmengiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_ogrenci.no == 0)
            {
                egitmengiris = new EgitmenGiris();
                egitmengiris.MdiParent = this;
                egitmengiris.Show();
            }
        }

        private void barButton_ogrencigiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_ogretmen.no == 0)
            {
                ogrencigiris = new OgrenciGiris();
                ogrencigiris.MdiParent = this;
                ogrencigiris.Show();
            }
        }

        private void barButton_soruekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                soruekle = new SoruEkle();
                soruekle.MdiParent = this;
                soruekle.Show();
        }
        private void barButtonItem_istatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            istatistik = new Istatistik();
            istatistik.MdiParent = this;
            istatistik.Show();
        }

        private void barButtonItem_cikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _ogretmen.no = 0;
            _ogretmen.isim = null;
            _ogretmen.sifre = null;
            _ogrenci.no = 0;
            _ogrenci.isim = null;
            _ogrenci.sifre = null;
        }
    }
}
