using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLayer;
using System.Data.SqlClient;
using DataAccessLayer.Veritabani;

namespace DataAccessLayer.Repositories
{
    public class AraclarRepository : IAraclarRepository
    {
        public DataTable AracGunlukFiyataGoreGetir(decimal fiyat)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE AracGunlukFiyat='" + fiyat + "' AND SilindiMi=0 AND RezerveMi = 0 AND KiralandiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;

        }

        public bool Ekle(Araclar obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @" INSERT INTO [dbo].[Araclar]
                            ([AracMarka]
                             ,[AracModel]
                             ,[AracYil]
                            ,[AracGerekenEhliyetYili]
                            ,[AracGerekenMinimumYas]
                            ,[AracKoltukSayisi]
                            ,[AracGunlukFiyat]
                            ,[AracAirbagDurumu]
                            ,[AracBagajHacmi]
                            ,[AracGunlukKmSiniri]
                            ,[FirmaId]
                            ,[AracPlakaNo])

                                 VALUES
                                       ('" + obje.AracMarka + "','" + obje.AracModel + "', '" + obje.AracYil
                                           + "', '" + obje.AracGerekenEhliyetYili + "', '" + obje.AracGerekenMinimumYas + "','" + obje.AracKoltukSayisi +
                                           "','" + obje.AracGunlukFiyat + "','" + obje.AracAirbagDurumu + "','" + obje.AracBagajHacmi + "','" 
                                           + obje.AracGunlukKmSiniri + "','" + obje.FirmaId + "','" + obje.AracPlakaNo + "');";
                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public DataTable FirmaIdyeGoreGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE FirmaId='" + id + "'AND SilindiMi=0 AND RezerveMi = 0 AND KiralandiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Guncelle(Araclar obje)
        {
            try
            {
                string strSql = @"UPDATE Araclar SET AracMarka = '" + obje.AracMarka + "', AracModel = '" + obje.AracModel
                                + "', AracYil = '" + obje.AracYil + "', AracGerekenEhliyetYili = '" + obje.AracGerekenEhliyetYili + "', AracGerekenMinimumYas = '" + obje.AracGerekenMinimumYas
                                + "', AracKoltukSayisi = '" + obje.AracKoltukSayisi + "', AracGunlukFiyat = '" + obje.AracGunlukFiyat + "', AracAirbagDurumu = '" + obje.AracAirbagDurumu
                                + "', AracBagajHacmi = '" + obje.AracBagajHacmi + "', AracGunlukKmSiniri = '" + obje.AracGunlukKmSiniri+ "', FirmaId = '" + obje.FirmaId
                                + "', KiralandiMi = '" + obje.KiralandiMi+ "', AracPlakaNo = '" + obje.AracPlakaNo+ "', MusteriId = '" + obje.MusteriId
                                + "' WHERE AracId = '" + obje.AracId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE AracId='" + Id + "'AND SilindiMi=0 AND RezerveMi = 0 AND KiralandiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Kirala(int id)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                string strSql = @"UPDATE Araclar SET KiralandiMi = 1 WHERE AracId = '" + id + "'";
                Baglanti.VeriGuncelle(strSql);
                return true;
            }
            catch(Exception ex) { }
            return false;
        }

        public DataTable KiralandiMiyeGoreGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE KiralandiMi= 1 AND SilindiMi=0 AND RezerveMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable KiralanmayanlariGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE KiralandiMi= 0 AND SilindiMi=0 AND RezerveMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable MarkayaGoreGetir(string marka)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE AracMarka LIKE '%" + marka + "%' AND SilindiMi = 0 AND RezerveMi = 0 AND KiralandiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable ModeleGoreGetir(string model)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE AracModel LIKE '%" + model + "%' AND SilindiMi = 0 AND RezerveMi = 0 AND KiralandiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(Araclar obje)
        {
            try
            {
                string strSql = "UPDATE Araclar SET SilindiMi = 1 WHERE AracId = '" + obje.AracId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public DataTable YilaGoreGetir(int yil)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM Araclar WHERE AracYil='" + yil + "'AND SilindiMi=0 AND RezerveMi = 0 AND KiralandiMi = 0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
