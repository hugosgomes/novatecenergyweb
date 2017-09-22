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

        public List<_13Lotes> GetLotesById(int idlote)
        {
            var lotes = (from l in _context._13Lotes
                         where l.Id == idlote
                         select l).ToList();
            return lotes;
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
            var lotes = _context._13Lotes.Include(l => l.StatusObj)
                .Where(l => l.Area == area && (l.Status == 207)).ToList();
            return lotes;
        }

        public List<List<dynamic>> GetLotes(List<int> areas, int area)
        {
            if (area != 0)
            {
                areas.Add(area);
            }

            var lotes = (from l in _context._13Lotes
                         where areas.Contains(l.Area) && l.Status == 207
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

        public List<List<dynamic>> GetLotesJoinItems()
        {
            var lotes = (from l in _context._13Lotes
                         join ti in _context._00TabelasItems on l.Status equals ti.Id
                         where l.Status == 207
                         select new
                         {
                             Id = l.Id,
                             LoteNum = l.LoteNum,
                             Ge = l.Ge,
                             DataLote = l.DataLote,
                             Item = ti.Item
                         }).ToList();

            var Lotes = new List<List<dynamic>>();
            foreach (var item in lotes)
            {
                var d = new List<dynamic>();
                d.Add(item.Id);
                d.Add(item.LoteNum);
                d.Add(item.Ge);
                d.Add(item.DataLote.GetValueOrDefault().ToString("dd/MM/yyyy"));
                d.Add(item.Item);
                Lotes.Add(d);
            }

            return Lotes;
        }

        public List<List<dynamic>> GetLoteJoinZonaDelegacaoArea()
        {
            var lotes = (from l in _context._13Lotes
                         join a in _context._00Areas on l.Area equals a.Id
                         join d in _context._00Delegacao on (int)a.Delegacao equals d.Id
                         join z in _context._00Zona on d.Zona equals z.Id
                         where l.Status == 207
                         select new
                         {
                             IdLote = l.Id,
                             Lote = l.LoteNum,
                             Z = z.Z,
                             D = d.D,
                             Ar = a.Area

                         }).ToList();

            var Lotes = new List<List<dynamic>>();
            foreach (var item in lotes)
            {
                var d = new List<dynamic>();
                d.Add(item.IdLote);
                d.Add(item.Lote);
                d.Add(item.Z);
                d.Add(item.D);
                d.Add(item.Ar);
                Lotes.Add(d);
            }
            return Lotes;
        }

        public List<List<dynamic>> GetLoteJoinZonaDelegacaoArea(List<int> areas)
        {
            var lotes = (from l in _context._13Lotes
                         join a in _context._00Areas on l.Area equals a.Id
                         join d in _context._00Delegacao on (int)a.Delegacao equals d.Id
                         join z in _context._00Zona on d.Zona equals z.Id
                         where areas.Contains(l.Area) && l.Status == 207
                         select new
                         {
                             IdLote = l.Id,
                             Lote = l.LoteNum,
                             Z = z.Z,
                             D = d.D,
                             Ar = a.Area

                         }).ToList();

            var Lotes = new List<List<dynamic>>();
            foreach (var item in lotes)
            {
                var d = new List<dynamic>();
                d.Add(item.IdLote);
                d.Add(item.Lote);
                d.Add(item.Z);
                d.Add(item.D);
                d.Add(item.Ar);
                Lotes.Add(d);
            }
            return Lotes;
        }
    }
}
