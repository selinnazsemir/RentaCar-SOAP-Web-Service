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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        public static Musteriler musteriler = null;
        
        private void btn_MusEkle_Click(object sender, EventArgs e)
        {

            if (HelperLayer.Helper.AlanKontrol(this))
            {
                MusterilerRepository repo = new MusterilerRepository();
                Musteriler b = new Musteriler()
                {
                    MusteriAd = txt_MusAd.Text,
                    MusteriSoyad = txt_MusSoyAd.Text,
                    MusteriEhliyetNo = Convert.ToInt32(txt_MusEhliyetNo.Text),
                    MusteriTCKNo = Convert.ToInt32(txt_TcNo.Text),
                    MusteriTelNo = txt_MusTel.Text.ToString(),
                    MusteriEmail = txt_MusEmail.Text,
                    SilindiMi = false
                };
                if (repo.Ekle(b))
                     MessageBox.Show("Eklendi"); 
                  
                else
                    MessageBox.Show("Eklenemedi");
            }
            else
                MessageBox.Show("Alanlar boş geçilemez");
        }
    }
}
