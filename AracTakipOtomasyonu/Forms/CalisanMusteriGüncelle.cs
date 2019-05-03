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
    public partial class CalisanMusteriGüncelle : Form
    {
        public CalisanMusteriGüncelle()
        {
            InitializeComponent();
        }
        public List<Musteriler> musteri;
        MusterilerRepository mus = new MusterilerRepository();
        public static Musteriler a = null;
        public static Musteriler b  = null;
        private void btn_MusteriGuncelle_Click(object sender, EventArgs e)
        {
            b = new Musteriler()
            {
                MusteriAd = txt_MusteriAd.Text,
                MusteriSoyad = txt_MusteriSoyad.Text,
                MusteriEhliyetNo = Convert.ToInt32(txt_MusteriEhliyetNo.Text),
                MusteriTCKNo = a.MusteriTCKNo,
                MusteriTelNo = txt_MusteriTelNo.Text,
                MusteriEmail = txt_MusteriEmail.Text,
                MusteriId = a.MusteriId
            };

            mus.Guncelle(b);
        }

        private void CalisanMusteriGüncelle_Load(object sender, EventArgs e)
        {
            dt_MusterileriGor.DataSource = mus.TumVeriyiGetir();
        }

        private void dt_MusterileriGor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = mus.IdyeGoreGetir(Convert.ToInt32(dt_MusterileriGor.SelectedRows[0].Cells[0].Value));
            txt_MusteriAd.Text = a.MusteriAd;
            txt_MusteriSoyad.Text = a.MusteriSoyad;
            txt_MusteriEhliyetNo.Text = a.MusteriEhliyetNo.ToString();
            txt_MusteriTelNo.Text = a.MusteriTelNo;
            txt_MusteriEmail.Text = a.MusteriEmail;
        }
    }
}
