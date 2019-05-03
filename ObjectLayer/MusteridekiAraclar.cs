using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class MusteridekiAraclar
    {
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public int AracYil { get; set; }
        public string AracPlakaNo { get; set; }
        public DateTime KiralikZamanBaslangic { get; set; }
        public DateTime KiralikZamanBitis { get; set; }
        public int KalanGun { get; set; }
    }
}
