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
    public partial class kaynakGuncelleForm : Form
    {
        public kaynakGuncelleForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        private void kaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            var kaynakListe =skb.kaynaklar.ToList();
            dataGridView1.DataSource = kaynakListe;

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kaynakGuncelleAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kaynakGuncelleYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kaynakGuncelleYayınevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           kaynakGuncelleSayfa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kaynakGuncelleTarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void kaynakGuncelleButton_Click(object sender, EventArgs e)
        {

            try
            {
                int gunceleKaynak = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                var seçilenKaynak = skb.kaynaklar.Where(x => x.kitapID == gunceleKaynak).FirstOrDefault();

                seçilenKaynak.kitapAd = kaynakGuncelleAd.Text;
                seçilenKaynak.kitapTarih = Convert.ToDateTime(kaynakGuncelleTarih.Text);
                seçilenKaynak.kitapYazar = kaynakGuncelleYazar.Text;
                seçilenKaynak.kitapSayfa = Convert.ToInt32(kaynakGuncelleSayfa.Value.ToString());
                seçilenKaynak.kitapYayınevi = kaynakGuncelleYayınevi.Text;

                skb.SaveChanges();

                var listele2 = skb.kaynaklar.ToList();
                dataGridView1.DataSource = listele2;
            }
            catch(Exception)
            {
                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");

            }

            


           
        }
    }
}
