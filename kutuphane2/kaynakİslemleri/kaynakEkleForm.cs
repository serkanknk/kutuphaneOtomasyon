using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane2.kaynakİslemleri
{
    public partial class kaynakEkleForm : Form
    {
        public kaynakEkleForm()
        {
            InitializeComponent();
        }

        kutuphane2Entities skb = new kutuphane2Entities();
        private void kaynakEkleButton_Click(object sender, EventArgs e)
        {
            kaynaklar kaynaklar = new kaynaklar();
            kaynaklar.kitapAd =kaynakEkleAd.Text;
            kaynaklar.kitapYazar =kaynakEkleYazar.Text;
            kaynaklar.kitapTarih=Convert.ToDateTime(kaynakEkleTarih.Value);
            kaynaklar.kitapSayfa = Convert.ToInt16( kaynakEkleSayfa.Value);

            skb.kaynaklar.Add(kaynaklar);
            skb.SaveChanges();
            var listele2 =skb.kaynaklar.ToList();
            dataGridView1.DataSource = listele2;
        }

        private void kaynakEkleForm_Load(object sender, EventArgs e)
        {
            var kaynakListele =skb.kaynaklar.ToList();
            dataGridView1.DataSource=kaynakListele;


            // kolonlar gizlendi
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            // kolonların ismi değişti
            dataGridView1.Columns[1].HeaderText = "Kitap Ad";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Yayınevi";
            dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Basım Yılı";
            
        }
    }
}
