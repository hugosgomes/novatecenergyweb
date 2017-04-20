using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Repository
{
    public class AreaRepository : IAreaRepository
    {
        public List<_00Areas> GetAreas(List<int> delegacoes, int delegacao)
        {
            if (delegacao != 0)
            {
                delegacoes.Add(delegacao);
            }

            // continuar olhando método ZonaCascade
            var areasL = _context._00Areas.Where(x => listint.Contains(Convert.ToInt32(x.Delegacao))).ToList();


        }
    }
}
