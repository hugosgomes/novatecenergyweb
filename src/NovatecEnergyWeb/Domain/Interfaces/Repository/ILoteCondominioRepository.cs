using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface ILoteCondominioRepository
    {
        List<_12Lotes> GetLotes();
        List<_12Lotes> GetLotesByListArea(List<_00Areas> areas);
        List<_12Lotes> GetLotesByAreaId(int area);
    }
}
