using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public interface IAracKmRepository : IBaseRepository<AracKmler>
    {
        List<AracKmler> AracIdyeGoreGetir(int id);
    }
}
