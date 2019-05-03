using ObjectLayer;
using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer.Repositories;
using System.Collections.Generic;

namespace AracTakipOtomasyonu
{
    public partial class CalisanEkle : Form
    {
        public CalisanEkle()
        {
            InitializeComponent();
        }
        public static Kullanicilar kullanici = null;
        List<Firmalar> firmalar = null;
        private void btn_CalisanEkle_Click(object sender, EventArgs e)
        {
            if (HelperLayer.Helper.AlanKontrol(this))
            {
                KullanicilarRepository repo = new KullanicilarRepository();
                Kullanicilar b = new Kullanicilar()
                {
                    KullaniciAd = txt_CalisanAd.Text,
                    KullaniciSoyad = txt_CalisanSoyad.Text,
                    KullaniciAdi = txt_CalisanAdi.Text,
                    KullaniciParola = HelperLayer.Helper.MD5eDonustur(txt_CalisanSifre.Text),
                    FirmaId = firmalar.Find(x => x.FirmaAdi == cmb_FirmaId.SelectedItem.ToString()).FirmaId,
                    RolId = 1
                };
                if (repo.Ekle(b))
                    MessageBox.Show("Eklendi");
                else
                    MessageBox.Show("Kayıt esnasında hata");
            }
            else
                MessageBox.Show("Alanlar boş geçilemez");
        }

        private void CalisanEkle_Load(object sender, EventArgs e)
        {
            FirmalarRepository b = new FirmalarRepository();
            firmalar = b.TumVeriyiGetir();
            for (int i = 0; i < firmalar.Count; i++)
            {
                cmb_FirmaId.Items.Add(firmalar[i].FirmaAdi);
            }
            
        }
    }
}
