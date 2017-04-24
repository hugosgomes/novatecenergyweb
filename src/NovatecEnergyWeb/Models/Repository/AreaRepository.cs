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

        public List<_00Areas> GetAreas(List<int> delegacoes, int delegacao)
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
    }
}
