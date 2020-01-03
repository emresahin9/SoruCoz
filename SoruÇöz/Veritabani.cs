using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Charts.Model;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace SoruÇöz
{
    public class Veritabani
    {
        SqlConnection baglanti = new SqlConnection("Server=.;Database=SoruCoz; trusted_connection=true");
        public void Open()
        {
            baglanti.Open();
        }

        public void Close()
        {
            baglanti.Close();
        }

        public bool SoruEkle(TextBox textBoxAciklama, TextBox textBoxCevap,string konu)
        {
            SqlDataAdapter sadaptor = new SqlDataAdapter("SELECT * FROM Soru", baglanti);
            DataTable sdt = new DataTable();
            sadaptor.Fill(sdt);
            DataSet sds = new DataSet();
            sds.Tables.Add(sdt);
            int j = 0;
            while (j != sds.Tables[0].Rows.Count)
            {
                string _aciklama = sds.Tables[0].Rows[j]["aciklama"].ToString();
                if (_aciklama == textBoxAciklama.Text.ToUpper().ToString())
                    return false;
                j++;
            }
            SqlCommand soruekleme = new SqlCommand("INSERT INTO Soru (aciklama,cevap,konu) VALUES('" + textBoxAciklama.Text.ToUpper() + "','" + textBoxCevap.Text.ToUpper() + "','" + konu + "')");
            soruekleme.Connection = baglanti;
            soruekleme.ExecuteNonQuery();
            return true;
        }
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public void TabloDoldurma()
        {
            dt = new DataTable();
            ds = new DataSet();
            SqlCommand tablosil = new SqlCommand("DELETE FROM Sinav");
            tablosil.Connection = baglanti;
            tablosil.ExecuteNonQuery();
            SqlCommand testtablo1 = new SqlCommand("INSERT INTO Sinav(soruId, aciklama,cevap,konu) SELECT TOP " + baskentsorusayi + " soruId,aciklama, cevap,konu FROM Soru WHERE konu='baskent' ORDER BY NEWID()");
            testtablo1.Connection = baglanti;
            testtablo1.ExecuteNonQuery();
            SqlCommand testtablo2 = new SqlCommand("INSERT INTO Sinav(soruId, aciklama,cevap,konu) SELECT TOP " + kıtasorusayi + " soruId,aciklama, cevap,konu FROM Soru WHERE konu='kıta' ORDER BY NEWID()");
            testtablo2.Connection = baglanti;
            testtablo2.ExecuteNonQuery();
            SqlCommand testtablo3 = new SqlCommand("INSERT INTO Sinav(soruId, aciklama,cevap,konu) SELECT TOP " + bolgesorusayi + " soruId,aciklama, cevap,konu FROM Soru WHERE konu='bolge' ORDER BY NEWID()");
            testtablo3.Connection = baglanti;
            testtablo3.ExecuteNonQuery();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Sinav", baglanti);
            adaptor.Fill(dt);
            ds.Tables.Add(dt);
        }

        int i = 0;
        int _soruid = 0;
        public string SoruGetir(int _ogrenciNo)
        {
            if (i != ds.Tables[0].Rows.Count)
            {
                string _soru = ds.Tables[0].Rows[i]["aciklama"].ToString();
                _soruid = Convert.ToInt32(ds.Tables[0].Rows[i]["soruId"]);
                i++;
                return _soru;
            }
            else
            {
                return "Test Bitti";
            }
        }
        public bool SoruCevapla(TextBox yanit, int ogrno)
        {
            SqlDataAdapter ogradaptor = new SqlDataAdapter("SELECT * FROM Ogrenci", baglanti);
            DataTable ogrdt = new DataTable();
            ogradaptor.Fill(ogrdt);
            DataSet ogrds = new DataSet();
            ogrds.Tables.Add(ogrdt);
            int j = 0;
            while (j != ogrds.Tables[0].Rows.Count)
            {
                if (ogrno == Convert.ToInt32(ogrds.Tables[0].Rows[j]["no"]))
                    break;
                j++;
            }
            string cevap = ds.Tables[0].Rows[i - 1]["cevap"].ToString();
            string konu = ds.Tables[0].Rows[i - 1]["konu"].ToString();
            if (yanit.Text.ToUpper() == cevap)
            {
                XtraMessageBox.Show("DOĞRU");
                SqlCommand cevapdogru = new SqlCommand("UPDATE Ogrenci SET " + konu + "dogru=" + konu + "dogru+1 WHERE no=" + ogrno + "");
                cevapdogru.Connection = baglanti;
                cevapdogru.ExecuteNonQuery();
                return true;
            }
            else
            {
                XtraMessageBox.Show("YANLIŞ");
                SqlCommand cevapyanlis = new SqlCommand("UPDATE Ogrenci SET " + konu + "yanlis=" + konu + "yanlis+1 WHERE no=" + ogrno + "");
                cevapyanlis.Connection = baglanti;
                cevapyanlis.ExecuteNonQuery();
                return false;
            }
        }
        public int baskentsorusayi = 0;
        public int kıtasorusayi = 0;
        public int bolgesorusayi = 0;
        public void TestHazirlama(int _ogrno)
        {
            SqlDataAdapter testadaptor = new SqlDataAdapter("SELECT * FROM Ogrenci", baglanti);
            DataTable testdt = new DataTable();
            testadaptor.Fill(testdt);
            DataSet testds = new DataSet();
            testds.Tables.Add(testdt);
            int a = 0;
            int baskentdogru = 0;
            int baskentyanlis = 0;
            int kıtadogru = 0;
            int kıtayanlis = 0;
            int bolgedogru = 0;
            int bolgeyanlis = 0;
            while (a != testds.Tables[0].Rows.Count)
            {
                if (_ogrno == Convert.ToInt32(testds.Tables[0].Rows[a]["no"]))
                {
                    baskentdogru = Convert.ToInt32(testds.Tables[0].Rows[a]["baskentdogru"]);
                    baskentyanlis = Convert.ToInt32(testds.Tables[0].Rows[a]["baskentyanlis"]);
                    kıtadogru = Convert.ToInt32(testds.Tables[0].Rows[a]["kıtadogru"]);
                    kıtayanlis = Convert.ToInt32(testds.Tables[0].Rows[a]["kıtayanlis"]);
                    bolgedogru = Convert.ToInt32(testds.Tables[0].Rows[a]["bolgedogru"]);
                    bolgeyanlis = Convert.ToInt32(testds.Tables[0].Rows[a]["bolgeyanlis"]);
                    break;
                }
                a++;
            }
            if (baskentdogru == 0 || baskentyanlis == 0)
            {
                baskentdogru++;
                baskentyanlis++;
            }
            if (kıtadogru == 0 || kıtayanlis == 0)
            {
                kıtadogru++;
                kıtayanlis++;
            }
            if (bolgedogru == 0 || bolgeyanlis == 0)
            {
                bolgedogru++;
                bolgeyanlis++;
            }
            double baskentoran = Convert.ToDouble(baskentyanlis) / Convert.ToDouble(baskentdogru);
            double iklimoran = Convert.ToDouble(kıtayanlis) / Convert.ToDouble(kıtadogru);
            double bolgeoran = Convert.ToDouble(bolgeyanlis) / Convert.ToDouble(bolgedogru);
            double oran = 20 / (iklimoran + baskentoran + bolgeoran);
            baskentsorusayi = Convert.ToInt32(oran * baskentoran);
            kıtasorusayi = Convert.ToInt32(oran * iklimoran);
            bolgesorusayi = Convert.ToInt32(oran * bolgeoran);
            if (baskentsorusayi + kıtasorusayi + bolgesorusayi == 19)
                baskentsorusayi = baskentsorusayi + 1;
            else if (baskentsorusayi + kıtasorusayi + bolgesorusayi == 21)
                baskentsorusayi = baskentsorusayi - 1;
            SqlCommand tablodegis = new SqlCommand("UPDATE Ogrenci SET baskentdogru=0, baskentyanlis=0, kıtayanlis=0, kıtadogru=0, bolgeyanlis=0, bolgedogru=0 WHERE no=" + _ogrno + "");
            tablodegis.Connection = baglanti;
            tablodegis.ExecuteNonQuery();
        }
        public int KullaniciBilgisi(string unvan, string isim, string sifre)
        {
            SqlDataAdapter kullanicibilgi = new SqlDataAdapter("Select * FROM " + unvan + "", baglanti);
            DataTable klncbilgidt = new DataTable();
            kullanicibilgi.Fill(klncbilgidt);
            DataSet klncbilgids = new DataSet();
            klncbilgids.Tables.Add(klncbilgidt);
            int k = 0;
            while (k != klncbilgids.Tables[0].Rows.Count)
            {
                if (isim.ToUpper() == klncbilgids.Tables[0].Rows[k]["isim"].ToString())
                {
                    if (sifre == klncbilgids.Tables[0].Rows[k]["sifre"].ToString())
                        return Convert.ToInt32(klncbilgids.Tables[0].Rows[k]["no"]);
                }
                k++;
            }
                return 0;
        }
        public void Istatistik(int ogrno,ChartControl chartControl)
        {
            SqlDataAdapter ogristatistik = new SqlDataAdapter("Select baskentdogru,baskentyanlis,kıtadogru,kıtayanlis,bolgedogru,bolgeyanlis FROM Ogrenci WHERE no=" + ogrno + "", baglanti);
            DataTable ogristatistikdt = new DataTable();
            ogristatistik.Fill(ogristatistikdt);
            DataSet ogristatistikds = new DataSet();
            ogristatistikds.Tables.Add(ogristatistikdt);
            if (ogristatistikdt.Rows.Count == 0)
                XtraMessageBox.Show("Böyle bir öğrenci bulunamadı!");
            else
            {
                chartControl.Series["DOĞRU"].Points.AddPoint("Başkent", int.Parse(ogristatistikds.Tables[0].Rows[0]["baskentdogru"].ToString()));
                chartControl.Series["YANLIŞ"].Points.AddPoint("Başkent", int.Parse(ogristatistikds.Tables[0].Rows[0]["baskentyanlis"].ToString()));
                chartControl.Series["DOĞRU"].Points.AddPoint("Kıta", int.Parse(ogristatistikds.Tables[0].Rows[0]["kıtadogru"].ToString()));
                chartControl.Series["YANLIŞ"].Points.AddPoint("Kıta", int.Parse(ogristatistikds.Tables[0].Rows[0]["kıtayanlis"].ToString()));
                chartControl.Series["DOĞRU"].Points.AddPoint("Bölge", int.Parse(ogristatistikds.Tables[0].Rows[0]["bolgedogru"].ToString()));
                chartControl.Series["YANLIŞ"].Points.AddPoint("Bölge", int.Parse(ogristatistikds.Tables[0].Rows[0]["bolgeyanlis"].ToString()));
            }

        }
    }
}