using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11CondVisitas
    {
        public int Id { get; set; }
        public int Idcondestrutura { get; set; }
        public string Obs { get; set; }
        public int? Venda { get; set; }
        public int? Tipo { get; set; }
        public int? D2 { get; set; }
        public int? Resultado { get; set; }
        public int? Idusuario { get; set; }
        public DateTime? Datahora { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? Status { get; set; }
        public int? Idusuarioagendamento { get; set; }
        public string Obsagendamento { get; set; }
        public DateTime? Dataagendamento { get; set; }
    }
}
