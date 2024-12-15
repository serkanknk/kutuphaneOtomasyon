using kutuphane2.kayitlarForm;
using kutuphane2.kaynakİslemleri;
using kutuphane2.Uyeİslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane2
{
    public partial class GenelİslemPaneli : Form
    {
        public GenelİslemPaneli()
        {
            InitializeComponent();
        }

        kutuphane2Entities skb = new kutuphane2Entities();

        private void GenelİslemPaneli_Load(object sender, EventArgs e)
        {
            ekleButton.Visible = false;
            silButton.Visible = false;
            guncelleButton.Visible = false;

            kaynakEkle.Visible = false;
            kaynakGüncelleBtn.Visible = false;
            kaynakSilBtn.Visible = false;

            
        }

        private void uyeler_Click(object sender, EventArgs e)
        {
            if (guncelleButton.Visible == false)
            {
                ekleButton.Visible = true;
                silButton.Visible = true;
                guncelleButton.Visible = true;

            }
            else
            {
                ekleButton.Visible = false;
                silButton.Visible = false;
                guncelleButton.Visible = false;
            }



            uyelerListeForm uyelerListeForm = new uyelerListeForm();
            uyelerListeForm.MdiParent = this;
            uyelerListeForm.Show();

        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            uyeEkleForm uyeEkleForm = new uyeEkleForm();
            uyeEkleForm.MdiParent = this;
            uyeEkleForm.Show();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            uyeSilForm uyeSilForm = new uyeSilForm();
            uyeSilForm.MdiParent = this;
            uyeSilForm.Show();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            uyeGuncelleForm uyeGuncelleForm = new uyeGuncelleForm();
            uyeGuncelleForm.MdiParent = this;
            uyeGuncelleForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kaynakEkle.Visible==true)
            {
                kaynakEkle.Visible = false;
                kaynakGüncelleBtn.Visible = false;
                kaynakSilBtn.Visible = false;
            }
            else
            {
                kaynakEkle.Visible = true;
                kaynakGüncelleBtn.Visible = true;
                kaynakSilBtn.Visible = true;
            }

            kaynakListeForm kaynakListeForm = new kaynakListeForm();
            kaynakListeForm.MdiParent = this;
            kaynakListeForm.Show();
        }

        private void kaynakEkle_Click(object sender, EventArgs e)
        {
            kaynakEkleForm kaynakEkleForm = new kaynakEkleForm();
            kaynakEkleForm.MdiParent = this;
            kaynakEkleForm.Show();
        }

        private void kaynakSilBtn_Click(object sender, EventArgs e)
        {
            kaynakSilForm kaynakSilForm = new kaynakSilForm();
            kaynakSilForm.MdiParent = this;
            kaynakSilForm.Show();
        }

        private void kaynakGüncelleBtn_Click(object sender, EventArgs e)
        {
            kaynakGuncelleForm kaynakGuncelleForm = new kaynakGuncelleForm();
            kaynakGuncelleForm.MdiParent = this;
            kaynakGuncelleForm.Show();
        }

        private void oduncButton_Click(object sender, EventArgs e)
        {
            kaynakOduncForm kaynakOduncForm = new kaynakOduncForm();
            kaynakOduncForm.MdiParent = this;
            kaynakOduncForm.Show();
     
        }

        private void teslimAlmaButton_Click(object sender, EventArgs e)
        {
            kaynakTeslimAlmaForm kaynakTeslimAlmaForm = new kaynakTeslimAlmaForm();
            kaynakTeslimAlmaForm.MdiParent = this;
            kaynakTeslimAlmaForm.Show();
        }
    }
}
