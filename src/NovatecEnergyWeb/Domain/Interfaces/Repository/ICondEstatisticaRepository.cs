using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface ICondEstatisticaRepository
    {
        List<CondEstatistica> GetLoteEstatisticaByLote(int idLote);
    }
}
