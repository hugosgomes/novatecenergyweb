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
    public class PijamaGasNaturalPymeRepository : IPijamaGasNaturalPymeRepository
    {
        private BDNVTContext _context;

        public PijamaGasNaturalPymeRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<PijamaGasNaturalPyme> GetExportacaoPijamaPadraoGasNatural(int zona, int delegacao, int area, int lote, string endereco)
        {
            var exportacao = _context.PijamaGasNaturalPyme.FromSql("execute [dbo].[sp_13_PijamaGasNaturalPCO] ");

            // Joins com Zona, del, e área
            var exportacaoZonaDelegacaoArea = from l in _context._13Lotes
                                              join e in exportacao on l.Id equals e.IdLote
                                              join a in _context._00Areas on l.Area equals a.Id
                                              join d in _context._00Delegacao on a.Delegacao equals d.Id
                                              join z in _context._00Zona on d.Zona equals z.Id
                                              select new
                                              {
                                                  IdPco = e.IdPyme,
                                                  Zid = z.Id,
                                                  Did = d.Id,
                                                  Aid = a.Id
                                              };
             
            if( lote != 0)
            {
                exportacao = exportacao.Where(e => e.IdLote == lote);

                // fazer filtro de zona, delegacao e area

                if ( zona != 0)
                {
                    exportacaoZonaDelegacaoArea = exportacaoZonaDelegacaoArea.Where(e => e.Zid == zona);
                    var pymes = exportacaoZonaDelegacaoArea.Select(e => e.IdPco).ToList(); // trás os pymes filtrados
                    exportacao = exportacao.Where(e => pymes.Contains(e.IdPyme)); // "select in exportacaoZOnaDelegacao"
                }


                if (delegacao != 0)
                {
                    exportacaoZonaDelegacaoArea = exportacaoZonaDelegacaoArea.Where(e => e.Did == delegacao);
                    var pymes = exportacaoZonaDelegacaoArea.Select(e => e.IdPco).ToList(); // trás os pymes filtrados
                    exportacao = exportacao.Where(e => pymes.Contains(e.IdPyme));
                }

                if( area != 0)
                {
                    exportacaoZonaDelegacaoArea = exportacaoZonaDelegacaoArea.Where(e => e.Aid == area);
                    var pymes = exportacaoZonaDelegacaoArea.Select(e => e.IdPco).ToList(); // trás os pymes filtrados
                    exportacao = exportacao.Where(e => pymes.Contains(e.IdPyme));
                }

            }

            if ( !String.IsNullOrEmpty(endereco))
            {
                exportacao = exportacao.Where(e => e.Endereco == endereco);
            }

            return exportacao.ToList();
        }
    }
}
