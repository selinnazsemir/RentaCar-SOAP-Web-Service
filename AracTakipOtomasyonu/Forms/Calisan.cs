using AracTakipOtomasyonu.Forms;
using BusinessLayer.Repositories;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakipOtomasyonu
{
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }
        public static Kullanicilar calisan = null;
        List<Araclar> araclar = null;
        List<Musteriler> musteriler = null;
        List<KiralikBilgileri> kiralik = null;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calisan_Load(object sender, EventArgs e)
        {

        }

        private void yeniAraçEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            AracEkle a = new AracEkle();
            a.Show();
        }

        private void btn_AracListele_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            araclar = arac.TumVeriyiGetir();
            for (int i = 0; i < araclar.Count; i++)
            {
                dt_AracListele.DataSource = araclar;
            }
        }

        private void btn_MusteriListele_Click(object sender, EventArgs e)
        {
            MusterilerRepository musteri = new MusterilerRepository();
            musteriler = musteri.TumVeriyiGetir();
            for (int i = 0; i < musteriler.Count; i++)
            {
                dt_MusteriListele.DataSource = musteriler;
            }

        }

        private void btn_KiralananAraclar_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            List<Araclar> araclar = arac.KiralandiMiyeGoreGetir();
            for (int i = 0; i < araclar.Count; i++)
            {
                dt_KiralananAraclar.DataSource = araclar;
            }
        }

        private void yeniMüşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            MusteriEkle c = new MusteriEkle();
            c.Show();
            
        }

        private void müşteriBilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanMusteriGüncelle musguncelle = new CalisanMusteriGüncelle();
            musguncelle.Show();
        }

        private void araçKiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanAracKiralama kira = new CalisanAracKiralama();
            kira.Show();

        }
    }
}
