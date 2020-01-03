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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }
        AnaSayfa anasayfa = new AnaSayfa();
        public static Ogrenci ogrenci = new Ogrenci();
        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_giris_Click(object sender, EventArgs e)
        {
            ogrenci.Giris(textBox_isim, textBox_sifre);
            //anasayfa.button1_Click(sender,e);
            //anasayfa.button1.PerformClick();
            //anasayfa.barButtonItem_yenile.PerformClick();
            //new System.EventHandler(anasayfa.barButtonItem_yenile.Refresh());
            //anasayfa.Load(sender,e);
            //anasayfa.AnaSayfa_Load(sender, e);
            this.Hide();
        }
    }
}
