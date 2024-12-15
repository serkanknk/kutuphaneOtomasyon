using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane2.kayitlarForm
{
    public partial class kaynakOduncForm : Form
    {
        public kaynakOduncForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        
        private void kaynakOduncForm_Load(object sender, EventArgs e)
        {



            var kayitlarListe = from kayit in skb.kayitlar select new 
            { kayit.uyeler.uyeAd, kayit.kaynaklar.kitapAd,kayit.alişTarih,kayit.teslimTarih,kayit.teslimDurum };
            dataGridView1.DataSource = kayitlarListe.ToList();

            var kaynaklarListe2 = skb.kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklarListe2;

            // kolonlar gizlendi
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[6].Visible = false;

            // kolonların ismi değişti
            dataGridView2.Columns[1].HeaderText = "Kitap Ad";
            dataGridView2.Columns[2].HeaderText = "Yazar";
            dataGridView2.Columns[3].HeaderText = "Yayınevi";
            dataGridView2.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns[5].HeaderText = "Basım Yılı";



         
        }

        private void uyeAraButton_Click(object sender, EventArgs e)
        {
            string bulTc =uyeAraText.Text;
            var istenilenTc = skb.uyeler.Where(x=>x.uyeTc==bulTc).FirstOrDefault();

            if (istenilenTc == null)
            {
                label2.Text = "Girfiğiniz Bilgiye göre bir kayt bulunamadı";
               
            }
            else
            {

                label2.Text = istenilenTc.uyeAd + " " + istenilenTc.uyeSoyad;
            }
        }

        private void kitapAdArama_TextChanged(object sender, EventArgs e)
        {
            string kitapAdi = kitapAdArama.Text;

            var arananKitap =skb.kaynaklar.Where(x=>x.kitapAd.Contains(kitapAdi)).ToList();
            dataGridView2.DataSource = arananKitap;
        }

        private void uyeAraText_TextChanged(object sender, EventArgs e)
        {

        }

        private void öduncVer_Click(object sender, EventArgs e)
        {
            try
            {
                string gelenTc = uyeAraText.Text;
                var uyeTcBul = skb.uyeler.Where(x => x.uyeTc.Equals(gelenTc)).FirstOrDefault();

                int seçilenKitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                var istenilenKaynak = skb.kaynaklar.Where(x => x.kitapID == seçilenKitapId).FirstOrDefault();

                kayitlar yeniKayit = new kayitlar();

                yeniKayit.kitapID = Convert.ToInt32(istenilenKaynak.kitapID);
                yeniKayit.uyeID = uyeTcBul.uyeID;

                yeniKayit.alişTarih = DateTime.Today;
                yeniKayit.teslimTarih = DateTime.Today.AddDays(15);
                yeniKayit.teslimDurum = false;
                skb.kayitlar.Add(yeniKayit);
                skb.SaveChanges();

                var kayitlarListe = skb.kayitlar.ToList();
                dataGridView1.DataSource = kayitlarListe;
            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }

          

        }


    }
}
