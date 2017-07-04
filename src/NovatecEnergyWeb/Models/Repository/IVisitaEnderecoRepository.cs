using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Repository
{
    public interface IVisitaEnderecoRepository
    {

        IEnumerable<VisitaEndereco> VisitasEnderecoFiltro(int zonas, int delegacao, int area, int lotes);


    }
}
