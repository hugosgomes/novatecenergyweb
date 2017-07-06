using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;

namespace NovatecEnergyWeb.Models.Repository
{
    public interface ICondVisitasRepository
    {

        List<CondVisita> GetVisitasByLote();
        IEnumerable<CondVisita> GetVisitasFiltro( int zonas, int delegacao, int area, int condominio);

    }
}
