using AracTakipOtomasyonu.Forms;
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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_CalisanEkle_Click(object sender, EventArgs e)
        {
            CalisanEkle cal = new CalisanEkle();
            cal.Show();
        }

        private void btn_YoneticiYeniAracEkle_Click(object sender, EventArgs e)
        {
            YoneticiAracEkle aracEkle = new YoneticiAracEkle();
            aracEkle.Show();
        }

        private void kayıtlıAraçlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiAracListesi aracListesi = new YoneticiAracListesi();
            aracListesi.Show();
        }

        private void araçÖzellikleriniGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracOzellikGor ozellik = new AracOzellikGor();
            ozellik.Show();
        }

        private void çalışanlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiCalisanListele listele = new YoneticiCalisanListele();
            listele.Show();
        }

        private void araçKiralayanMüşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiAracKiralayanlar kiralayanlar = new YoneticiAracKiralayanlar();
            kiralayanlar.Show();
        }

        private void kiradaOlanAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiKiradaOlanAraclar kirada = new YoneticiKiradaOlanAraclar();
            kirada.Show();
        }

        private void çalışanBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiCalisanGuncelle yon = new YoneticiCalisanGuncelle();
            yon.Show();
        }

        private void btn_YoneticiAracKiralama_Click(object sender, EventArgs e)
        {
            YoneticiAracKiralama yonkirala = new YoneticiAracKiralama();
            yonkirala.Show();
        }
    }
}
