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
    public class LoteCondominioRepository : ILoteCondominioRepository
    {
        private BDNVTContext _context;

        public LoteCondominioRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<_12Lotes> GetLotes()
        {
            var lotes = (from l in _context._12Lotes.Include(l => l.StatusObj)
                         where l.Status == 136
                         select l).ToList();
            return lotes;
        }

        public List<_12Lotes> GetLotesByAreaId(int area)
        {
            var lotes = _context._12Lotes.Include(l => l.StatusObj)
               .Where(l => l.Area == area && (l.Status == 136)).ToList();
            return lotes;
        }

        public List<_12Lotes> GetLotesByListArea(List<_00Areas> areas)
        {
            var areasId = new List<int>();
            foreach (var item in areas)
            {
                areasId.Add(item.Id);
            }

            var lotes = (from l in _context._12Lotes.Include(l => l.StatusObj)
                         where areasId.Contains(l.Area) && l.Status == 136
                         select l).ToList();
            return lotes;
        }

        public List<_12Lotes> GetLotesById(int lote)
        {
            var lotes = (from l in _context._12Lotes
                         where l.Id == lote
                         select l).ToList();
            return lotes;
        }
    }
}
