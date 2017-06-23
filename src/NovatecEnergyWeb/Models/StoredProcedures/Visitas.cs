using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class Visitas
    {
        public Int64 Id { get; set; }
        public string Z { get; set; }
        public string D { get; set; }
        public string Ar { get; set; }
        public string Condominio { get; set; }
        public string Complemento { get; set; }
        public Decimal Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public DateTime? DataHora { get; set; }
        public string Venda { get; set; }
        public string AgVisita { get; set; }
        public string TipoVisita { get; set; }
        public string Negativa { get; set; }
        public string Dx { get; set; }
        public string TipoD2 { get; set; }
        public string Obs { get; set; }
        public string Pt { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string ObsAgendamento { get; set; }
        public string StatusCond { get; set; }
        public string TipoCond { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Via { get; set; }
        public string Logradouro { get; set; }
        public string Cliente { get; set; }

        public int Zid { get; set; }
        public int Did { get; set; }
        public int Aid { get; set; }
        public int Condid { get; set; }
        public int Vendaid { get; set; }
        public int TipoVisitaid { get; set; }
        public int Negativaid { get; set; }
        public int Dxid { get; set; }
        public int Statusid { get; set; }
    }
}
