using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface ICondominioLoteAtivo
    {
        List<_11_LoteAtivos_Condominios> GetCondominios(List<int> areas, int area, int status);
        List<_11_LoteAtivos_Condominios> GetCondominios(int status);
    }
}
