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

        public List<PcoEndereco> VisitasPcoEndereco(int zona, int delegacao, int area, int lote, string endereco)
        {
            var visitas = _context.PcoEndereco.FromSql(" exec [dbo].[sp_13_Visita_Endereco]; ");


            // filtra as seguintes colunas
            if (zona != 0)
            {
                visitas = visitas.Where(v => v.Zid == zona);
            }
            if (delegacao != 0)
            {
                visitas = visitas.Where(v => v.Did == delegacao);
            }
            if (area != 0)
            {
                visitas = visitas.Where(v => v.Aid == area);
            }

            if (lote != 0)
            {
                visitas = visitas.Where(v => v.IdLote == lote);
            }

            if (!String.IsNullOrEmpty(endereco))
            {
                //alterado para buscar pelo enderecoB( Sem acento)
                visitas = visitas.Where(c => c.EnderecoB.Contains(endereco.ToUpper()));
            }

            return visitas.ToList();
        }
    }
}
