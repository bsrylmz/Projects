using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Formu_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("...LUTFEN BİLGİLERİ EKSİZSİZ DOLDURUN...");
                return;
            }

            lvBilgiler.Items.Add(KisiBilgisi(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtEmail.Text, txtAdres.Text));

            Temizle(this);
        }
        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        public void Temizle(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }


        public ListViewItem KisiBilgisi(string ad, string soyad, string telefon, string email, string adres)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = ad;
            lvi.SubItems.Add(soyad);
            lvi.SubItems.Add(telefon);
            lvi.SubItems.Add(email);
            lvi.SubItems.Add(adres);

            return lvi;
        }
    }
}
