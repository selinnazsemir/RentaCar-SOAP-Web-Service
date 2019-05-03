using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class Araclar 
    {
        public int AracId { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public int AracYil { get; set; }
        public int AracGerekenEhliyetYili { get; set; }
        public int AracGerekenMinimumYas { get; set; }
        public int AracKoltukSayisi { get; set; }
        public decimal AracGunlukFiyat { get; set; }
        public bool AracAirbagDurumu { get; set; }
        public decimal AracBagajHacmi { get; set; }
        public int AracGunlukKmSiniri { get; set; }
        public int FirmaId { get; set; }
        public bool KiralandiMi { get; set; }
        public string AracPlakaNo { get; set; }
        public bool SilindiMi { get; set; }
        public int MusteriId { get; set; }
        public bool RezerveMi { get; set; }
    }
}
