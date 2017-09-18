using NovatecEnergyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface ILotePcoRepository
    {
        List<_13Lotes> GetLotesById(int idlote);
        List<_13Lotes> GetLotes();
        List<_13Lotes> GetLotesByListArea(List<_00Areas> areas);
        List<_13Lotes> GetLotesByAreaId(int area);
        List<List<dynamic>> GetLotes(List<int> areas, int area);
        List<List<dynamic>> GetLotesJoinItems();
        List<List<dynamic>> GetLoteJoinZonaDelegacaoArea();
        List<List<dynamic>> GetLoteJoinZonaDelegacaoArea(List<int> areas);
    }
}
