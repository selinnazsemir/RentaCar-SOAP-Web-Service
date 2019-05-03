using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Giris
{
    public class Giris
    {
        Kullanicilar kullanici = null;
        public Kullanicilar GirisYap(Kullanicilar Kullanici)
        {
            if (new DataAccessLayer.Giris.Giris().GirisYap(Kullanici))
                kullanici = new DataAccessLayer.Giris.Giris().KullaniciBilgileriGetir(Kullanici);
            return kullanici;
        }
    }
}
