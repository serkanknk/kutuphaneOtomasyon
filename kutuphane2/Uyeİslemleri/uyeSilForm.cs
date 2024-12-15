using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane2.Uyeİslemleri
{
    public partial class uyeSilForm : Form
    {
        public uyeSilForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        public void listele()
        {
            try
            {
                var uyeleriGetir = skb.uyeler.ToList();
                dataGridView1.DataSource = uyeleriGetir.ToList();
                // kolonlar gizlendi
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[8].Visible = false;

                // kolonların ismi değişti
                dataGridView1.Columns[1].HeaderText = "İsim";
                dataGridView1.Columns[2].HeaderText = "Soyad";
                dataGridView1.Columns[3].HeaderText = "Tc";
                dataGridView1.Columns[4].HeaderText = "Mail";
                dataGridView1.Columns[5].HeaderText = "Telefon";
                dataGridView1.Columns[6].HeaderText = "Ceza";
                dataGridView1.Columns[7].HeaderText = "Cinsiyet";
            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
            
           
        }
        private void uyeSilForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            DialogResult silmeİslemi = MessageBox.Show("Silmek istediğinize emin misiniz", "Üye silme işlemi", MessageBoxButtons.YesNo);

            try
            { // üye silme işlemi onayı
                if (silmeİslemi == DialogResult.Yes)
                {
                    int seçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var uyeSil = skb.uyeler.Where(x => x.uyeID.Equals(seçilenId)).FirstOrDefault();

                    skb.uyeler.Remove(uyeSil);
                    skb.SaveChanges();
                    listele();

                    MessageBox.Show("Üye silindi");
                }
                else
                {
                    MessageBox.Show("Silme işlemi yapılamadı");
                }
            }
            catch (Exception)  // üyeye ait kayıtları silemiyoruz
            {
                MessageBox.Show("Üyeye ait teslim edilmemiş kaynak bulunmakta bu yüzden silme işlemini gerçekleştireemiyoruz,");

            }

           
            

          
        }
    }
}
