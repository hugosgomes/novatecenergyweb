using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IVisitasRepository
    {

        List<Visitas> GetVisitasByLote();
        IEnumerable<Visitas> GetVisitasFiltro( int zonas, int delegacao, int area, int condominio);

    }
}
