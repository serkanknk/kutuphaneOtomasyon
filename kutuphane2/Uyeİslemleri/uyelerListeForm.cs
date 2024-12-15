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
    public partial class uyelerListeForm : Form
    {
        public uyelerListeForm()
        {
            InitializeComponent();
        }
        public void listele()
        {
            try
            {
                kutuphane2Entities skb = new kutuphane2Entities();
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



        private void uyelerListeForm_Load(object sender, EventArgs e)
        {


            try
            {
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }

        }
    }
}
