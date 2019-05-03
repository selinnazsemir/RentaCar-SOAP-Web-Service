using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public interface IAraclarRepository : IBaseRepository<Araclar>
    {
        List<Araclar> MarkayaGoreGetir(string marka);
        List<Araclar> ModeleGoreGetir(string model);
        List<Araclar> YilaGoreGetir(int yil);
        List<Araclar> AracGunlukFiyataGoreGetir(decimal fiyat);
        List<Araclar> FirmaIdyeGoreGetir(int id);
        List<Araclar> KiralandiMiyeGoreGetir();

        List<Araclar> KiralanmayanlariGetir();
        bool Kirala(int id);
    }
}
