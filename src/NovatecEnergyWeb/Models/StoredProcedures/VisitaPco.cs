using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class VisitaPco
    {
        public Int64 Id { get; set; }
        public string Z { get; set; }
        public string D { get; set; }
        public string Ar { get; set; }
        public string Pco { get; set; }
        public string Complemento { get; set; }
        public int? NegativaId { get; set; }
        public int Num { get; set; }
        public DateTime? DataHora { get; set; }
        public string AgVisita { get; set; }
        public string Obs { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string StatusPco { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Via { get; set; }
        public string Logradouro { get; set; }
        public int Interesse { get; set; }
        public int IdLote { get; set; }
        public int AgComercialId { get; set; }


    }
}
