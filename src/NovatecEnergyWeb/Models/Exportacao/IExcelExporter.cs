using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Exportacao
{
    public interface IExcelExportaLotePorCliente
    {
        string FileName { get; set; }
        byte[] ExportaPadraoNovatec(List<LotePorCliente> data);
        byte[] ExportaPadraoGasNatural(List<_11_LoteAtivoB> data, IEnumerable<dynamic> lote);
    }
}
