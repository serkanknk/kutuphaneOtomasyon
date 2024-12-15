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
    public partial class kaynakTeslimAlmaForm : Form
    {
        public kaynakTeslimAlmaForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        private void kaynakTeslimAlmaForm_Load(object sender, EventArgs e)
        {

            try
            {
                var kayitlar = skb.kayitlar.Where(x => x.teslimDurum == false).ToList();
                dataGridView1.DataSource = kayitlar.ToList();

                // kolonlar gizlendi
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;

                // kolonların ismi değişti
                dataGridView1.Columns[1].HeaderText = "Üye İsim";
                dataGridView1.Columns[2].HeaderText = "Kaynak ad";
                dataGridView1.Columns[3].HeaderText = "Alış Tarih";
                dataGridView1.Columns[4].HeaderText = "Teslim Tarih";
                dataGridView1.Columns[5].HeaderText = "Teslim Durum";

            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
            

        }

        private void teslimAlButton_Click(object sender, EventArgs e)
        {
            try
            {
                int seçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var teslimAlinanKaynak = skb.kayitlar.Where(x => x.kayitID == seçilenId).FirstOrDefault();
                teslimAlinanKaynak.teslimDurum = true;

                skb.SaveChanges();
                var kayitlar = skb.kayitlar.Where(x => x.teslimDurum == false).ToList();
                dataGridView1.DataSource = kayitlar.ToList();

            }
            catch (Exception)
            {

                MessageBox.Show("sistemsel bir hata lütfen daha sonra tekrar deneyiniz");
            }
           
        }
    }
}
