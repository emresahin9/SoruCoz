using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruÇöz
{
    public class Ogrenci
    {
        public int no { get; set; }
        public string isim { get; set; }
        public string sifre { get; set; }

        public Ogrenci()
        { }
        Veritabani veritabani = new Veritabani();

        public void Giris(TextBox _isim,TextBox _sifre)
        {
            veritabani.Open();
            int _no = 0;
            if ((_no=veritabani.KullaniciBilgisi("Ogrenci", _isim.Text.ToUpper(), _sifre.Text)) == 0)
                XtraMessageBox.Show("Hatalı isim veya şifre!");
            else
            {
                no = _no;
                isim = _isim.Text;
                XtraMessageBox.Show("Giriş Başarılı!");
            }
            veritabani.Close();
        }
    }
}
