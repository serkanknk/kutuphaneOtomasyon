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
    public partial class uyeEkleForm : Form
    {
        public uyeEkleForm()
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

        private void uyeEkleForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uyeler uyelerEkle = new uyeler();
                uyelerEkle.uyeAd = ekleAd.Text;
                uyelerEkle.uyeSoyad = ekleSoyad.Text;
                uyelerEkle.uyeCeza = Convert.ToInt32(ekleCeza.Text);
                uyelerEkle.uyeTel = ekelTel.Text;
                uyelerEkle.uyeTc = ekleTc.Text;
                uyelerEkle.uyeMail = ekelMail.Text;

                if (cinsiyetE.Checked == true)
                {
                    uyelerEkle.uyeCinsiyet = "E";
                }
                else
                {
                    uyelerEkle.uyeCinsiyet = "K";
                }
                skb.uyeler.Add(uyelerEkle);
                skb.SaveChanges();
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
           
            
        }
    }
}
