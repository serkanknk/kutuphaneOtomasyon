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
    public partial class uyeGuncelleForm : Form
    {
        public uyeGuncelleForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        public void listele()
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
        private void uyeGuncelleForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var guncelleUye = skb.uyeler.Where(x => x.uyeID == secilenId).FirstOrDefault();

                guncelleUye.uyeAd = guncelleAd.Text;
                guncelleUye.uyeSoyad = guncelleSoyad.Text;
                guncelleUye.uyeCeza = Convert.ToInt32(guncelleCeza.Text);
                guncelleUye.uyeTel = guncelleTel.Text;
                guncelleUye.uyeTc = guncelleTc.Text;
                guncelleUye.uyeMail = guncelleMail.Text;

                if (guncelleCinsiyetE.Checked == true)
                {
                    guncelleUye.uyeCinsiyet = "E";
                }
                else
                {
                    guncelleUye.uyeCinsiyet = "K";
                }

                skb.SaveChanges();

                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
          
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                guncelleAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                guncelleSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                guncelleTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                guncelleMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                guncelleTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                guncelleCeza.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
                {
                    guncelleCinsiyetE.Checked = true;
                }
                else
                {
                    guncelleCinsiyetK.Checked = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
           
           
        }
    }
}
