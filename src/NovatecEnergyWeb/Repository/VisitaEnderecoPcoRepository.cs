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
    public class VisitaEnderecoPcoRepository : IVisitaEnderecoPcoRepository
    {
        private BDNVTContext _context;

        public VisitaEnderecoPcoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public IEnumerable<PcoEndereco> VisitasPcoEndereco(int zona, int delegacao, int area, int lote)
        {
            var visitas = _context.PcoEndereco.FromSql(" exec [dbo].[sp_13_visita_endereco]; ");

            // lote igual a zero
            if (lote <= 0)
            {
                // area igual a zero
                if (area <= 0)
                {
                    // delegacao igual a zero
                    if(delegacao <= 0)
                    {
                        // zona igual a zero
                        if(zona <= 0)
                        {
                            return visitas;
                        }
                        else
                        {
                            // filtra zona
                            return visitas.Where(v => v.Zid == zona);
                        }
                    }
                    else
                    {
                        // filtra delegacao
                        return visitas.Where(v => v.Did == delegacao);
                    }
                }
                else
                {
                    // filtra area
                    return visitas.Where(v => v.Aid == area);
                }
            }
            else
            {
                // filtra lote
                return visitas.Where(v => v.IdLote == lote);
            }
        }
    }
}
