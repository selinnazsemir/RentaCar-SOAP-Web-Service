using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class Firmalar
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; }
        public int SehirId { get; set; }
        public string FirmaAdres { get; set; }
        public bool SilindiMi { get; set; }
    }
}
