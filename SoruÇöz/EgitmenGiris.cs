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
    public partial class EgitmenGiris : Form
    {
        public EgitmenGiris()
        {
            InitializeComponent();
        }
        public static Ogretmen ogretmen = new Ogretmen();
        private void Giris_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton_giris_Click(object sender, EventArgs e)
        {
            ogretmen.Giris(textBox_isim, textBox_sifre);
            this.Hide();
        }
    }
}
