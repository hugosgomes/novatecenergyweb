using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface ILoteEstatisticaPcoRepository
    {
        List<LoteEstatisticaPco> GetLoteEstatisticaPcoByLote(int idLote);
    }
}
