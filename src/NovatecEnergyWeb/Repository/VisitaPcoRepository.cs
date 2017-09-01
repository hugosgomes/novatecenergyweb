using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Core;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Repository
{
    public class VisitaPcoRepository : IVisitaPcoRepository
    {
        private BDNVTContext _context;

        public VisitaPcoRepository(BDNVTContext context)
        {
            _context = context;
        }


        public IEnumerable<VisitaPco> GetVisitaPco()
        {
            var visitasPco = _context.VisitaPco.FromSql(" exec [dbo].[sp_13_Visitas_Pco] ").ToList();
            return visitasPco;
        }
    }
}
