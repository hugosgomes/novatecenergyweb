using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Domain.Interfaces.Repository;

namespace NovatecEnergyWeb.Repository
{
    public class LoteEstatisticaRepository : ILoteEstatisticaRepository
    {
        private BDNVTContext _context;

        public LoteEstatisticaRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<LoteEstatistica> GetLoteEstatisticaByLote(int idLote)
        {
            var estatisticas = _context.LoteEstatistica.FromSql(" exec [dbo].[LoteEstatistica] {0}", idLote).ToList();
            return estatisticas;
        }
    }
}
