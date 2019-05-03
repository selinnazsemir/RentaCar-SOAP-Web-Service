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
    public class AracKmRepository : IAracKmRepository
    {
        public DataTable AracIdyeGoreGetir(int id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM AracKmler WHERE AracId='" + id + "'AND SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Ekle(AracKmler obje)
        {
            try
            {
                Baglanti.BaglantiKontrol();
                var strSql = @"    
                                INSERT INTO [dbo].[AracKmler]
                                ([AracId]
                                ,[AracBaslangicKm]
                                ,[AracBitisKm]                 
                                 VALUES
                                       ('" + obje.AracId + "','" + obje.AracBaslangicKm + "', '" + obje.AracBitisKm + "',);";
                SqlCommand sqlCommand = new SqlCommand(strSql, Baglanti.sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            { }
            return false;
        }

        public bool Guncelle(AracKmler obje)
        {
            try
            {
                string strSql = @"UPDATE AracKmler SET AracId = '" + obje.AracId + "', AracBaslangicKm = '" + obje.AracBaslangicKm
                                + "', AracBitisKm = '" + obje.AracBitisKm +"'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM AracKmler WHERE AracKmId='" + Id + "'AND SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }

        public bool Sil(AracKmler obje)
        {
            try
            {
                string strSql = "UPDATE AracKmler SET SilindiMi = 1 WHERE AracKmId = '" + obje.AracKmId + "'";
                Baglanti.VeriGuncelle(strSql);
            }
            catch (Exception ex)
            { }
            return false;
        }

        public DataTable TumVeriyiGetir()
        {
            DataTable dt = null;
            string strSql = @"SELECT * FROM AracKmler WHERE SilindiMi=0";
            dt = Baglanti.VeriGetir(strSql);
            return dt;
        }
    }
}
