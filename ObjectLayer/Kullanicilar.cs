using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class Kullanicilar
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public int FirmaId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciParola { get; set; }
        public int RolId { get; set; }
        public bool SilindiMi { get; set; }
    }
    public enum KullaniciRolleri
    {
        Calisan = 1,
        Yonetici = 2,
    }
}
