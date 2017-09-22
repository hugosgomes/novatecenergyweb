using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces
{ 

    public interface IExcelExporterLotePorClienteApartamento
    {
        string FileName { get; set; }
        byte[] ExportaPadraoNovatec(List<LotePorCliente> data);
        byte[] ExportaPadraoGasNatural(List<_11_LoteAtivoB> data, IEnumerable<dynamic> lote);
        byte[] ExportaPadraoNovatecVisitaPco(List<VisitaPco> data); // mudar método depois
        byte[] ExportaAgendaEnderecoPco(List<PcoEndereco> data,
              List<PcoEndereco_ExportaAgendaAdesao> data2, _13Lotes lote, string mes, string ano);
    }
}
