using System;
using System.Collections.Generic;
using System.Data;
using ObjectLayer;

namespace BusinessLayer.Repositories
{
    public class FirmalarRepository : IFirmalarRepository
    {
        DataAccessLayer.Repositories.FirmalarRepository repo = new DataAccessLayer.Repositories.FirmalarRepository();
        Firmalar firma = new Firmalar();
        public List<Firmalar> AdIleFirmaGetir(string ad)
        {
            List<Firmalar> firmalar = null;
            Firmalar firma = null;
            DataTable dt = repo.AdIleFirmaGetir(ad);
            if (dt != null)
            {
                firmalar = new List<Firmalar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    firma = new Firmalar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        FirmaAdi = dt.Rows[i]["FirmaAdi"].ToString(),
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        FirmaAdres = dt.Rows[i]["FirmaAdres"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    firmalar.Add(firma);
                }
            }
            return firmalar;
            //return repo.AdIleFirmaGetir(ad);
        }

        public bool Ekle(Firmalar obje)
        {
            return repo.Ekle(obje);
        }

        public bool Guncelle(Firmalar obje)
        {
            return repo.Guncelle(obje);
        }

        public Firmalar IdyeGoreGetir(int Id)
        {
            DataTable dt = null;
            Firmalar firma = null;
            dt = repo.IdyeGoreGetir(Id);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    firma = new Firmalar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        FirmaAdi = dt.Rows[i]["FirmaAdi"].ToString(),
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        FirmaAdres = dt.Rows[i]["FirmaAdres"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                }
            }
            return firma;
        }

        public List<Firmalar> SehirIleFirmaGetir(string sehir)
        {
            List<Firmalar> firmalar = null;
            Firmalar firma = null;
            DataTable dt = repo.SehirIleFirmaGetir(sehir);
            if (dt != null)
            {
                firmalar = new List<Firmalar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    firma = new Firmalar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        FirmaAdi = dt.Rows[i]["FirmaAdi"].ToString(),
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        FirmaAdres = dt.Rows[i]["FirmaAdres"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    firmalar.Add(firma);
                }
            }
            return firmalar;
        }

        public bool Sil(Firmalar obje)
        {
            return repo.Sil(obje);
        }

        public List<Firmalar> TumVeriyiGetir()
        {
            List<Firmalar> firmalar = null;
            Firmalar firma = null;
            DataTable dt = null;
            dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                firmalar = new List<Firmalar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    firma = new Firmalar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        FirmaAdi = dt.Rows[i]["FirmaAdi"].ToString(),
                        SehirId = Convert.ToInt32(dt.Rows[i]["SehirId"]),
                        FirmaAdres = dt.Rows[i]["FirmaAdres"].ToString(),
                        SilindiMi = Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                    firmalar.Add(firma);
                }
            }
            return firmalar;
        }
    }
}
