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

namespace AracTakipOtomasyonu.Forms
{
    public partial class AracEkle : Form
    {
        public List<Firmalar> firmalar;

        public AracEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HelperLayer.Helper.AlanKontrol(this))
            {
                AraclarRepository repo = new AraclarRepository();
                Araclar b = new Araclar()
                {
                    AracMarka = txt_AracMarka.Text,
                    AracModel = txt_AracModel.Text,
                    AracYil = Convert.ToInt32(txt_AracYil.Text),
                    AracGerekenEhliyetYili = Convert.ToInt32(txt_AracGerekenEhliyetYil.Text),
                    AracGerekenMinimumYas = Convert.ToInt32(txt_AracYasSinir.Text),
                    AracKoltukSayisi = Convert.ToInt32(txt_AracKoltukSayisi.Text),
                    AracGunlukFiyat = Convert.ToInt32(txt_AracGunlukFiyat.Text),
                    AracAirbagDurumu=true,
                    AracBagajHacmi = Convert.ToInt32(txt_AracBagajHacmi.Text),
                    AracGunlukKmSiniri = Convert.ToInt32(txt_AracGunlukKmSinir.Text),
                    FirmaId = firmalar.Find(x => x.FirmaAdi == cmb_firma.SelectedItem.ToString()).FirmaId,
                    KiralandiMi=false,
                    AracPlakaNo=txt_AracPlaka.Text,
                    SilindiMi=false,
                    
                };
                if (repo.Ekle(b))
                    MessageBox.Show("Eklendi");

                else
                    MessageBox.Show("Eklenemedi");
            }
            else
                MessageBox.Show("Alanlar boş geçilemez");
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            FirmalarRepository b = new FirmalarRepository();
            firmalar = b.TumVeriyiGetir();
            for (int i = 0; i < firmalar.Count; i++)
            {
                cmb_firma.Items.Add(firmalar[i].FirmaAdi);
            }
        }
    }
}
