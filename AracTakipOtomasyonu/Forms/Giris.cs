using DataAccessLayer.Repositories;
using HelperLayer;
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

    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        public static Kullanicilar kullanici = null;
        Calisan calisan = new Calisan();
        Yonetici yonetici = new Yonetici();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (Helper.AlanKontrol(this))
            {
                kullanici = new Kullanicilar()
                {
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    KullaniciParola = Helper.MD5eDonustur(txtParola.Text.Trim())
                };
                kullanici = new BusinessLayer.Giris.Giris().GirisYap(kullanici);
                if (kullanici != null)
                {
                    this.Hide();
                    if ((KullaniciRolleri)kullanici.RolId == KullaniciRolleri.Calisan)
                        calisan.Show();
                    else
                        yonetici.Show();
                }
                else
                    MessageBox.Show("Veritabanında kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Alanlar boş geçilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
