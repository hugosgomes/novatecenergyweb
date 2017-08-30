using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models;

namespace NovatecEnergyWeb.Repository
{
    public class DelegacaoRepository : IDelegacaoRepository
    {
        private BDNVTContext _context;

        public DelegacaoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<int> GetDelegacaoIdsByZona(int zona)
        {
            var delegacoes = _context._00Delegacao.Where(d => d.Zona == zona).ToList();

            var ids = new List<int>();
            foreach (var item in delegacoes)
            {
                ids.Add(item.Id);
            }
            return ids;

        }

        //usado em GetLotesPco - FiltroLateralService
        public List<_00Delegação> GetDelegacaoByZonaId(int zona)
        {
            var delegacoes = _context._00Delegacao.Where(d => d.Zona == zona).ToList();

            return delegacoes;
        }
    }
}
