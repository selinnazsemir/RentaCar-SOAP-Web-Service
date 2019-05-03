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
    public partial class CalisanAracKiralama : Form
    {
        public CalisanAracKiralama()
        {
            InitializeComponent();
        }
        public List<Araclar> araclar;
        AraclarRepository arac = new AraclarRepository();
        public List<Musteriler> musteriler;
        int aracid;
        public List<Firmalar> firmalar;
        private void CalisanAracKiralama_Load(object sender, EventArgs e)
        {

            araclar = arac.KiralanmayanlariGetir();
            dt_AracListele.DataSource = araclar;
            FirmalarRepository b = new FirmalarRepository();
            firmalar = b.TumVeriyiGetir();
            for (int i = 0; i < firmalar.Count; i++)
            {
                cmb_FirmaSec.Items.Add(firmalar[i].FirmaAdi);
            }
            MusterilerRepository a = new MusterilerRepository();
            musteriler = a.TumVeriyiGetir();
            for (int i = 0; i < musteriler.Count; i++)
            {
                cmb_MusSec.Items.Add(musteriler[i].MusteriAd);
            }
        }

        private void dt_AracListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //a = arac.IdyeGoreGetir(Convert.ToInt32(dt_AracListele.SelectedRows[0].Cells[0].Value));
            aracid = Convert.ToInt32(dt_AracListele.SelectedRows[0].Cells[0].Value);
            MessageBox.Show(aracid.ToString());



        }

        private void btn_AracKirala_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.MusteriId = musteriler.Find(x => x.MusteriAd == cmb_MusSec.SelectedItem.ToString()).MusteriId;
            //a.AracId = firmalar.Find(x => x.FirmaAdi == cmb_FirmaSec.SelectedItem.ToString()).FirmaId;
            arac.Kirala(aracid);
            MessageBox.Show("Arac Kiralandi");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
