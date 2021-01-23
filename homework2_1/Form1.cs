using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ekranHazirla()
        {
            mtbPersonelNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtBirim.Clear();
            mtbTcKimlikNo.Clear();
            txtDogumYeri.Clear();
            mtbPersonelNo.Focus();
        }

        public List<Personel> Personeller = new List<Personel>();
        public Fabrika fabrika = new Fabrika();

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            fabrika.ad = "Kocak Fabrika";
            fabrika.adres = "Izmir";

            try
            {
                Personel personel = new Personel();

                personel.personelNo = Convert.ToInt32(mtbPersonelNo.Text);
                personel.kimlik.ad = txtAd.Text;
                personel.kimlik.soyad = txtSoyad.Text;
                personel.birim = txtBirim.Text;
                personel.kimlik.tcKimlikNo = Convert.ToInt32(mtbTcKimlikNo.Text);
                personel.kimlik.dogumYeri = txtDogumYeri.Text;

                fabrika.PersonelEkle(Personeller , personel);
                MessageBox.Show("Personel Eklendi!!! Goruntulemek icin Personel Listele butonuna basiniz!!!");
                ekranHazirla();
            }
            catch (Exception)
            {
                MessageBox.Show("Personel Eklenemedi!!!");
                ekranHazirla();
            }
           
        }

        private void btnPersonelCikart_Click(object sender, EventArgs e)
        {
            fabrika.PersonelCikartma(Personeller , Convert.ToInt64(mtbTcKimlikNoCikart.Text));
            MessageBox.Show("Personel Cikartildi !! Goruntulemek icin Personel Listele butonuna basiniz!!!");
            mtbTcKimlikNoCikart.Clear();
        }

        private void PersonelListele()
        {
            foreach (Personel personel in Personeller)
            {
                string temp = "Ad:" + personel.kimlik.ad + "  Soyad:" + personel.kimlik.soyad + "  Tc Kimlik No: " + personel.kimlik.tcKimlikNo + "  Personel No : " + personel.personelNo;
                lvlPersonelListele.Items.Add(temp);
            }
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            lvlPersonelListele.Clear();
            PersonelListele();
        }

    }
}
