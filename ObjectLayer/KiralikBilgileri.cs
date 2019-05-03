using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class KiralikBilgileri
    {
        public int KiralikId { get; set; }
        public int AracId { get; set; }
        public int FirmaId { get; set; }
        public int MusteriId { get; set; }
        public DateTime KiralikZamanBaslangic { get; set; }
        public DateTime KiralikZamanBitis { get; set; }
        public int AracKmId { get; set; }
        public decimal KiralikUcret { get; set; }
        public bool SilindiMi { get; set; }
    }
}
