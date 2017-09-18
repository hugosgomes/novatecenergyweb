using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class PcoEndereco
    {
        public Int64 Id { get; set; }
        public String Lote { get; set; }
        public string Z { get; set; }
        public string D { get; set; }
        public string AR { get; set; }
        public string Endereco { get; set; }
        public string Agente { get; set; }
        public int Potencial { get; set; }
        public int ? Visitas { get; set; }
        public int ? VisitasImpr { get; set; }
        public int ? VisitasAgendadas { get; set; }
        public int ? Entrevistas { get; set; }
        public int ? Ausencias { get; set; }
        public int Visitados { get; set; }
        public int Entrevistados { get; set; }
        public int ? Tratados { get; set; }
        public int Zid { get; set; }
        public int Did { get; set; }
        public int Aid { get; set; }
        public int IdLote { get; set; }
        public string EnderecoB { get; set; }
        public int Visitas0 { get; set; }
        public int Visitas1 { get; set; }
        public int Visitas2 { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
    }
}
