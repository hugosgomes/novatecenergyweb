using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Repository
{
    public class LoteEstatisticaPcoRepository : ILoteEstatisticaPcoRepository
    {
        private BDNVTContext _context;

        public LoteEstatisticaPcoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<LoteEstatisticaPco> GetLoteEstatisticaPcoByLote(int idLote)
        {
            var estatisticas = _context.LoteEstatisticaPco.FromSql(" exec [dbo].[sp_lote_estatistica_pco] {0}", idLote).ToList();
            return estatisticas;
        }
    }
}
