using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class LotePorCliente
    {
        public Int64 Id { get; set; }
        public string Lote { get; set; }
        public string Z { get; set; }
        public string D { get; set; }
        public string Ar { get; set; }
        public string Condominio { get; set; }
        public string Complemento { get; set; }
        public Decimal Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public string Pt { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Via { get; set; }
        public string Logradouro { get; set; }
        public string LocalidadeB { get; set; }
        public string BairroB { get; set; }
        public string LogradouroB { get; set; }
        public string CasaStatus { get; set; }
        public string UltMotivo { get; set; }
        public String Agult { get; set; }
        public DateTime? Dtult { get; set; }
        public Double? Ncliente { get; set; }
        public String StatusCl { get; set; }
        public DateTime? DtStatusCl { get; set; }
        public string Procedencia { get; set; }
        public string NomeResp { get; set; }
        public string TlfResp { get; set; }
        public int? Visitas { get; set; }
        public int? VisitasImpr { get; set; }
        public int? VisitasAgendadas { get; set; }
        public int? Entrevistas { get; set; }
        public int? Ausencias { get; set; }
        public int? D2 { get; set; }
        public int? Svg { get; set; }
        public int? Sve { get; set; }
        public int? Visitado { get; set; }
        public int? Entrevistado { get; set; }
        public int? Contratado { get; set; }
        public int? IdultMotivo { get; set; }
        public int? IdAgult { get; set; }
        public int? Casa { get; set; }
        public int? Zid { get; set; }
        public int? Did { get; set; }
        public int? Aid { get; set; }
        public int? CondId { get; set; }
        public int? PtId { get; set; }
        public int? IdLote { get; set; }
        public int? StatusClid { get; set; }
        public int? ClId { get; set; }
        public int? CondStatus { get; set; }
        public int? IdCasaStatus{ get; set; }
        public int? Tratado { get; set; }

    }
}
