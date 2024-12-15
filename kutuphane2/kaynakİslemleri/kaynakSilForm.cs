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
    public partial class kaynakSilForm : Form
    {
        public kaynakSilForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        private void kaynakSilForm_Load(object sender, EventArgs e)
        {

            try
            {
                var kaynakListele = skb.kaynaklar.ToList();
                dataGridView1.DataSource = kaynakListele;

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
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
           


            
        }

        private void silButton_Click(object sender, EventArgs e)
        {


            try
            {
                int seçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                var silinenKaynak = skb.kaynaklar.Where(x => x.kitapID == seçilenId).FirstOrDefault();

                skb.kaynaklar.Remove(silinenKaynak);
                skb.SaveChanges();

                var listele2 = skb.kaynaklar.ToList();
                dataGridView1.DataSource = listele2;
            }
            catch (Exception)
            {
                MessageBox.Show("Bu kaynak şu anda birisine ödünç verilmiş durumda teslim alma işlemi yapılmadan silinemez.");
            }

            
        }
    }
}
