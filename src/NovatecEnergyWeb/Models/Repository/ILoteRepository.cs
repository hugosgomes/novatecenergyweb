using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Repository
{
    public interface ILoteRepository
    {
        List<List<dynamic>> GetLotes(List<int> areas, int area);
        List<List<dynamic>> GetLotesJoinItems();
        List<List<dynamic>> GetLoteJoinZonaDelegacaoArea();
        List<List<dynamic>> GetLoteJoinZonaDelegacaoArea(List<int> areas);
    }
}
