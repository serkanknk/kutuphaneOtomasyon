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
    public partial class kaynakListeForm : Form
    {
        public kaynakListeForm()
        {
            InitializeComponent();
        }
        kutuphane2Entities skb = new kutuphane2Entities();
        public void listeleK()
        {
            var kaynakGetir =skb.kaynaklar.ToList();
            dataGridView1.DataSource = kaynakGetir;

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
        private void kaynakListeForm_Load(object sender, EventArgs e)
        {
          listeleK();
        }
    }
}
