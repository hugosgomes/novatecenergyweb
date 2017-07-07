using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Models.Repository
{
    public class CondEstatisticaRepository : ICondEstatisticaRepository
    {
        private BDNVTContext _context;

        public CondEstatisticaRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<CondEstatistica> GetLoteEstatisticaByLote(int idLote)
        {
            var estatisticas = _context.CondEstatistica.FromSql(" exec [dbo].[CondEstatistica] {0}", idLote).ToList();
            return estatisticas;
        }
    }
}
