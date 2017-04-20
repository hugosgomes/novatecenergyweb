using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Repository
{
    public class LoteRepository : ILoteRepository
    {
        private BDNVTContext _context;

        public LoteRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<List<dynamic>> GetLotes(List<int> areas, int area)
        {
            if (area != 0)
            {
                areas.Add(area);
            }

            var lotes = (from l in _context._11Lotes
                         where areas.Contains(l.Area)
                         join ti in _context._00TabelasItems on l.Status equals ti.Id
                         select new
                         {
                             Id = l.Id,
                             LoteNum = l.LoteNum,
                             Ge = l.Ge,
                             DataLote = l.DataLote, //.GetValueOrDefault().ToString("dd/MM/yyyy")
                             Item = ti.Item
                         }).ToList();

            var Lote = new List<List<dynamic>>();
            foreach (var item in lotes)
            {
                var d = new List<dynamic>();
                d.Add(item.Id);
                d.Add(item.LoteNum);
                d.Add(item.Ge);
                d.Add(item.DataLote.GetValueOrDefault().ToString("dd/MM/yyyy"));
                d.Add(item.Item);
                Lote.Add(d);
            }

            return Lote;
        }
    }
}
