using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.Exportacao
{
    public interface IExcelExportVisitaEnderecoCondominio
    {

        string FileName { get; set; }
       byte[] ExportaAgendaGasNaturalEnderecoCondominio(List<VisitaEndereco> data,
              List<CondEnderecoExportaAgendaAdesao> data2, _12Lotes lote, string mes, string ano);
        byte[] ExportaPadraoNovatecCondVisita(List<CondVisita> data);
        byte[] ExportaPadraoNovatecPco(List<Pco> data);

    }
}
