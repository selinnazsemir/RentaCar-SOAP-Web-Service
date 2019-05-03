using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer.Giris
{
    public class Giris
    {
        public bool GirisYap(Kullanicilar kullanici)
        {
            string strSql = @"SELECT * FROM Kullanicilar WHERE KullaniciAdi = '" + kullanici.KullaniciAdi.ToString() +
                             "' AND KullaniciParola = '" + kullanici.KullaniciParola.ToString() + "'" +
                             " AND SilindiMi = 0;";
            if (Veritabani.Baglanti.VeriVarmi(strSql))
                return true;
            return false;
        }
        public Kullanicilar KullaniciBilgileriGetir(Kullanicilar kullanici)
        {
            string strSql = @"SELECT * FROM Kullanicilar WHERE KullaniciAdi = '" + kullanici.KullaniciAdi.ToString() +
                            "' AND KullaniciParola = '" + kullanici.KullaniciParola.ToString() + "'" +
                             " AND SilindiMi = 0;";
            try
            {
                if (Veritabani.Baglanti.VeriVarmi(strSql))
                {
                    DataTable dt = new DataTable();
                    dt = Veritabani.Baglanti.VeriGetir(strSql);
                    kullanici = new Kullanicilar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[0]["FirmaId"]),
                        KullaniciAd = dt.Rows[0]["KullaniciAd"].ToString(),
                        KullaniciAdi = dt.Rows[0]["KullaniciAdi"].ToString(),
                        KullaniciId = Convert.ToInt32(dt.Rows[0]["KullaniciId"]),
                        KullaniciParola = dt.Rows[0]["KullaniciParola"].ToString(),
                        KullaniciSoyad = dt.Rows[0]["KullaniciSoyad"].ToString(),
                        RolId = Convert.ToInt32(dt.Rows[0]["RolId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[0]["SilindiMi"])
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata", "Veritabanından kullanıcı verileri alınamadı.,\r\n Açıklama: " + ex.Message + "\r\nSql: +" + strSql);
            }
            return kullanici;
        }
    }
}
