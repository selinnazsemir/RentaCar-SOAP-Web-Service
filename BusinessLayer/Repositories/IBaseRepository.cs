using System.Collections.Generic;
using System.Data;

namespace BusinessLayer.Repositories
{
    public interface IBaseRepository<Object> where Object:class
    {
        bool Ekle(Object obje);
        bool Sil(Object obje);
        bool Guncelle(Object obje);
        List<Object> TumVeriyiGetir();
        Object IdyeGoreGetir(int Id);
    }
}
