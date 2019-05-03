using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Veritabani;
using ObjectLayer;

namespace DataAccessLayer.Repositories
{
    public class FirmalarRepository : IFirmalarRepository
    {
        public DataTable AdIleFirmaGetir(string ad)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Firmalar WHERE FirmaAd LIKE '%" + ad + "%' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable AdIleFirmaIdGetir(string ad)
        {
            DataTable dt = null;
            string strSql = @"EXEC AdagoreFirmaId '"+ad+"'";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Ekle(Firmalar obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @"    
                                INSERT INTO [dbo].[Firmalar]
                                            ([FirmaAdi]
                                             ,[SehirId]
                                             ,[FirmaAdres])
                                 VALUES
                                       ('" + obje.FirmaAdi + "','" + obje.SehirId + "', '" + obje.FirmaAdres
                                           + "');";
                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public bool Guncelle(Firmalar obje)
        {
            try
            {
                string strSql = @"UPDATE Firmalar SET FirmaAdi = '" + obje.FirmaAdi + "', SehirId = '" + obje.SehirId
                                + "', FirmaAdres = '" + obje.FirmaAdres + "', KullaniciAdi = '" + 
                                 "' WHERE KullaniciId = '" + obje.FirmaId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {

            DataTable dt = null;
            string strSql = @"SELECT * FROM Firmalar WHERE FirmaId='"+Id+"' AND SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable SehirIleFirmaGetir(string sehir)
        {
            DataTable dt = null;
            string strSql = @"SELECT f.FirmaAdi FROM Firmalar f INNER JOIN Sehirler s ON f.SehirId = s.SehirId AND f.SilindiMi=0
                              WHERE s.SehirAdi = '" + sehir + "' AND s.SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(Firmalar obje)
        {
            try
            {
                string strSql = "UPDATE Firmalar SET SilindiMi = 1 WHERE FirmaId = '" + obje.FirmaId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Firmalar WHERE SilindiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
