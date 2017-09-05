using NovatecEnergyWeb.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Core;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Repository
{
    public class LotePcoRepository : ILotePcoRepository
    {
        private BDNVTContext _context;

        public LotePcoRepository(BDNVTContext context)
        {
            _context = context;
        }
        public List<_13Lotes> GetLotes()
        {
            var lotes = (from l in _context._13Lotes.Include(l => l.StatusObj)
                         where l.Status == 207
                         select l).ToList();
            return lotes;
        }

        public List<_13Lotes> GetLotesByListArea(List<_00Areas> areas)
        {
            var areasId = new List<int>();
            foreach (var item in areas)
            {
                areasId.Add(item.Id);
            }

            var lotes = ( from l in _context._13Lotes.Include(l =>l.StatusObj)
                        where areasId.Contains(l.Area) && l.Status == 207
                          select l).ToList();
            return lotes;            
        }

        public List<_13Lotes> GetLotesByAreaId(int area)
        {
            var lotes = _context._13Lotes.Where(l => l.Area == area).ToList();
            return lotes;
        }
    }
}
