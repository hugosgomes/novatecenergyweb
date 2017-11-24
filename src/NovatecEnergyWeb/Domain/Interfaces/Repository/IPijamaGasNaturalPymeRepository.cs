using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Models;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IPijamaGasNaturalPymeRepository
    {
        List<PijamaGasNaturalPyme> GetExportacaoPijamaPadraoGasNatural(int zona, int delegacao, int area, int lote, string endereco);
    }
}
