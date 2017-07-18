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
    public class CondVisitasRepository : ICondVisitasRepository
    {


        private BDNVTContext _context;

        public CondVisitasRepository(BDNVTContext context)
        {
            _context = context;
        }


        public List<CondVisita> GetVisitasByLote()
        {
            var visitas = _context.CondVisita.FromSql(" exec [dbo].[CondVisitaSH] ").ToList();
            return visitas;
        }

        public List<CondVisita> GetVisitasFiltro( int zonas, int delegacao, int area, int condominio)
        {
            var visitas = _context.CondVisita.FromSql(" exec [dbo].[CondVisitaSH] ").ToList();

            IEnumerable<CondVisita> filtro = null;

                // filtro area
            if (area == 0)
                {
                    // filtro delegacao 
                    if (delegacao == 0)
                    {
                        //filtro zona 
                        if (zonas == 0)
                        {
                            return (visitas);
                        }
                        else
                        {
                            filtro = visitas.Where(c => c.Zid == zonas);
                        }
                    }
                    else
                    {
                     filtro = visitas.Where(c => c.Did == delegacao);
                    }
                }
                else
                {
                   filtro = visitas.Where(c => c.Aid == area);
                }
            return (filtro.ToList());

        }
    }
}
