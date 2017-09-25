using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IVisitaEnderecoPcoRepository
    {
        List<PcoEndereco> VisitasPcoEndereco(int zona, int delegacao, int area, int lote, string bairro);
        
    }
}
