using System;
using System.Collections.Generic;
using System.Data;
using ObjectLayer;
namespace BusinessLayer.Repositories
{
    public class AracKmRepository : IAracKmRepository
    {
        DataAccessLayer.Repositories.AracKmRepository repo = new DataAccessLayer.Repositories.AracKmRepository();
        public List<AracKmler> AracIdyeGoreGetir(int id)
        {
            List<AracKmler> arackmler = null;
            AracKmler arackm = null;
            DataTable dt = repo.AracIdyeGoreGetir(id);
            if (dt != null)
            {
                arackmler = new List<AracKmler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arackm = new AracKmler()
                    {
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        AracBaslangicKm = Convert.ToInt32(dt.Rows[i]["AracBaslangicKm"]),
                        AracBitisKm= Convert.ToInt32(dt.Rows[i]["AracBitisKm"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        SilindiMi= Convert.ToBoolean(dt.Rows[i]["AracId"])
                    };
                    arackmler.Add(arackm);
                }
            }
            return arackmler;
        }

        public bool Ekle(AracKmler obje)
        {
            return repo.Ekle(obje);
        }

        public bool Guncelle(AracKmler obje)
        {
            return repo.Guncelle(obje);
        }

        public AracKmler IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            AracKmler arackm = null;
            dt = repo.IdyeGoreGetir(Id);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arackm = new AracKmler()
                    {
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        AracBaslangicKm = Convert.ToInt32(dt.Rows[i]["AracBaslangicKm"]),
                        AracBitisKm = Convert.ToInt32(dt.Rows[i]["AracBitisKm"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["AracId"])
                    };
                }
            }
            return arackm;
        }

        public bool Sil(AracKmler obje)
        {
            return repo.Sil(obje);
        }

        public List<AracKmler> TumVeriyiGetir()
        {
            List<AracKmler> arackmler = null;
            AracKmler arackm = null;
            DataTable dt = null;
            dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                arackmler = new List<AracKmler>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arackm = new AracKmler()
                    {
                        AracKmId = Convert.ToInt32(dt.Rows[i]["AracKmId"]),
                        AracBaslangicKm = Convert.ToInt32(dt.Rows[i]["AracBaslangicKm"]),
                        AracBitisKm = Convert.ToInt32(dt.Rows[i]["AracBitisKm"]),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["AracId"])
                    };
                    arackmler.Add(arackm);
                }
            }
            return arackmler;
        }
    }
}
