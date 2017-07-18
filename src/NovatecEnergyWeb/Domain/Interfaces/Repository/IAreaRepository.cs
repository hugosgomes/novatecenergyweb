using NovatecEnergyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IAreaRepository
    {
        List<_00Areas> GetAreasByDelegacao(List<int> delegacoes, int delegacao);
        List<int> GetAreasIds(List<_00Areas> areas);
        List<_00Areas> GetAreasByClienteId(int idCliente);
    }
}
