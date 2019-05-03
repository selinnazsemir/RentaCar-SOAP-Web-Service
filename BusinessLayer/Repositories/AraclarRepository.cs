using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectLayer;

namespace BusinessLayer.Repositories
{
    public class AraclarRepository : IAraclarRepository
    {
        DataAccessLayer.Repositories.AraclarRepository repo = new DataAccessLayer.Repositories.AraclarRepository();
        public List<Araclar> AracGunlukFiyataGoreGetir(decimal fiyat)
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = repo.AracGunlukFiyataGoreGetir(fiyat);
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"]),
                        RezerveMi = Convert.ToBoolean(dt.Rows[i]["RezerveMi"]),
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"])
                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public bool Ekle(Araclar obje)
        {
            return repo.Ekle(obje);
        }

        public List<Araclar> FirmaIdyeGoreGetir(int id)
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = repo.FirmaIdyeGoreGetir(id);
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])


                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public bool Guncelle(Araclar obje)
        {
            return repo.Guncelle(obje);
        }

        public Araclar IdyeGoreGetir(int Id)
        {

            DataTable dt = null;
            Araclar arac = null;

            dt = repo.IdyeGoreGetir(Id);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac=new Araclar()
               
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracBagajHacmi"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = dt.Rows[i]["AracPlakaNo"].ToString(),
                        KiralandiMi= Convert.ToBoolean(dt.Rows[i]["KiralandiMi"]),
                        RezerveMi= Convert.ToBoolean(dt.Rows[i]["RezerveMi"]),
                        MusteriId = Convert.ToInt32(dt.Rows[i]["MusteriId"]),
                        SilindiMi= Convert.ToBoolean(dt.Rows[i]["SilindiMi"])
                    };
                  
                }
            }
            return arac;
        }

       

        public bool Kirala(int id)
        {
            return repo.Kirala(id);
        }

        public List<Araclar> KiralandiMiyeGoreGetir()
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = null;
            dt = repo.KiralandiMiyeGoreGetir();
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])
                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public List<Araclar> KiralanmayanlariGetir()
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = null;
            dt = repo.KiralanmayanlariGetir();
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])
                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public List<Araclar> MarkayaGoreGetir(string marka)
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = repo.MarkayaGoreGetir(marka);
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])


                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public List<Araclar> ModeleGoreGetir(string model)
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = repo.ModeleGoreGetir(model);
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])


                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public bool Sil(Araclar obje)
        {
            return repo.Sil(obje);
        }

        public List<Araclar> TumVeriyiGetir()
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = null;
            dt = repo.TumVeriyiGetir();
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])
                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }

        public List<Araclar> YilaGoreGetir(int yil)
        {
            List<Araclar> araclar = null;
            Araclar arac = null;
            DataTable dt = repo.YilaGoreGetir(yil);
            if (dt != null)
            {
                araclar = new List<Araclar>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    arac = new Araclar()
                    {
                        FirmaId = Convert.ToInt32(dt.Rows[i]["FirmaId"]),
                        AracMarka = dt.Rows[i]["AracMarka"].ToString(),
                        AracModel = dt.Rows[i]["AracModel"].ToString(),
                        AracId = Convert.ToInt32(dt.Rows[i]["AracId"]),
                        AracYil = Convert.ToInt32(dt.Rows[i]["AracYil"]),
                        AracGerekenEhliyetYili = Convert.ToInt32(dt.Rows[i]["AracGerekenEhliyetYili"]),
                        AracGerekenMinimumYas = Convert.ToInt32(dt.Rows[i]["AracGerekenMinimumYas"]),
                        AracKoltukSayisi = Convert.ToInt32(dt.Rows[i]["AracKoltukSayisi"]),
                        AracGunlukFiyat = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracAirbagDurumu = Convert.ToBoolean(dt.Rows[i]["AracAirbagDurumu"]),
                        AracBagajHacmi = Convert.ToDecimal(dt.Rows[i]["AracGunlukFiyat"]),
                        AracGunlukKmSiniri = Convert.ToInt32(dt.Rows[i]["AracGunlukKmSiniri"]),
                        AracPlakaNo = Convert.ToString(dt.Rows[i]["AracPlakaNo"]),
                        KiralandiMi = Convert.ToBoolean(dt.Rows[i]["KiralandiMi"])


                    };
                    araclar.Add(arac);
                }
            }
            return araclar;
        }
    }
}