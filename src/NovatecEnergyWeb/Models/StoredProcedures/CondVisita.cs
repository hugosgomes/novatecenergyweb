using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class CondVisita
    {
        public Int64 Id { get; set; }
        public string Z { get; set; }
        public string D { get; set; }
        public string Ar { get; set; }
        public string Condominio { get; set; }
        public string Complemento { get; set; }
        public Decimal Num { get; set; }
        public DateTime? DataHora { get; set; }
        public string AgVisita { get; set; }
        public string Negativa { get; set; }
        public string Pt { get; set; }
        public string StatusCond { get; set; }
        public string TipoCond { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Via { get; set; }
        public string Logradouro { get; set; }
        public String Interesse { get; set; }
        public String Pco { get; set; }
        public int TarifaSocial { get; set; }
        public String Visitado { get; set; }

        public int Zid { get; set; }
        public int Did { get; set; }
        public int Aid { get; set; }

        public int IdLote { get; set; }
        public int CondId { get; set; }
        public int LocId { get; set; }
        public int BaId { get; set; }
        public int LogId { get; set; }
        public int StatusId { get; set; }
        public int PtId { get; set; }
        public int TipoVisitaId { get; set; }
        public int NegativaId { get; set; }
        public int AgId { get; set; }


    }
}
