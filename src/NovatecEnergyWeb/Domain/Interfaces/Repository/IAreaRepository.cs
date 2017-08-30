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
        List<int> GetAreasIds(List<_00Areas> areas); // alterar/remover esse método numa futura refatoração
        List<_00Areas> GetAreasByClienteId(int idCliente);
        List<_00Areas> GetAreasByDelegacaoId(int delegacao);
        List<_00Areas> GetAreasByListDelegacao(List<_00Delegação> delegacoes);
    }
}
