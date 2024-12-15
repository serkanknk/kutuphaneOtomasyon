using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane2
{
    public partial class Form1 : Form
    {

        kutuphane2Entities skb = new kutuphane2Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void girişButton_Click(object sender, EventArgs e)
        {
            try
            {
                string girilenAd = PersonelAdi.Text;
                string gelenSifre = PersonelŞifre.Text;

                var personelVeri = skb.personel.Where(x => x.personelKullaniciAdi.Equals(girilenAd) && x.personelŞifre.Equals(gelenSifre)).FirstOrDefault();

                if (personelVeri == null)
                {
                    MessageBox.Show("Giriş Başarısız");

                }
                else
                {
                    MessageBox.Show("Giriş Başarılı");
                    GenelİslemPaneli genelİslemPaneli = new GenelİslemPaneli();
                    genelİslemPaneli.Show();
                    this.Hide();

                }
            }
            catch (Exception ) 
                {
                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
                }
           
            
        }
    }
}
