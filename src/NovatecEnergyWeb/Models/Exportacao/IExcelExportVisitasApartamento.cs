using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Exportacao
{
    public interface IExcelExportVisitasApartamento
    {

        string FileName { get; set; }
        byte[] ExportaPadraoNovatec(List<Visitas> data);

    }
}
