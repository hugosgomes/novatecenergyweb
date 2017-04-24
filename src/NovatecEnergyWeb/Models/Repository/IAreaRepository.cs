using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Repository
{
    public interface IAreaRepository
    {
        List<_00Areas> GetAreas(List<int> delegacoes, int delegacao);
        List<int> GetAreasIds(List<_00Areas> areas);
        List<_00Areas> GetAreasAll();
    }
}
