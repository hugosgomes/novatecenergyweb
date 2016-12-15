using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Rj11rj45
    {
        public int Id { get; set; }
        public int? Ramal { get; set; }
        public string Posto { get; set; }
        public double? Dados { get; set; }
        public double? Telefone { get; set; }
        public string TipoLinha { get; set; }
    }
}
