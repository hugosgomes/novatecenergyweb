using NovatecEnergyWeb.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Repository
{
    public class AreaRepository : IAreaRepository
    {
        private BDNVTContext _context;
        public AreaRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<_00Areas> GetAreasByDelegacao(List<int> delegacoes, int delegacao)
        {
            if (delegacao != 0)
            {
                delegacoes.Add(delegacao);
            }

            // continuar olhando método ZonaCascade
            var areasL = _context._00Areas.Where(x => delegacoes.Contains(Convert.ToInt32(x.Delegacao))).ToList();

            return areasL;

        }

        public List<int> GetAreasIds(List<_00Areas> areas)
        {
            var listAreaInt = new List<int>();
            foreach (var item in areas)
            {
                listAreaInt.Add(item.Id);
            }

            return listAreaInt;
        }

        public List<_00Areas> GetAreasByClienteId(int idCliente)
        {
            var areas = (from ca in _context.ClientesAreas
                         where ca.IdCliente == Convert.ToInt32(idCliente)
                         join a in _context._00Areas on ca.IdArea equals a.Id
                         select new _00Areas
                         {
                             Id = a.Id,
                             Area = a.Area,
                             Delegacao = a.Delegacao,
                             Ge = a.Ge
                         }).ToList();

            return areas;
        }
    }
}
