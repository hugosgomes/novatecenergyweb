using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class CodServiços
    {
        public string CodServiço { get; set; }
        public decimal? Valor { get; set; }
        public string Descrição { get; set; }
        public string Status { get; set; }
    }
}
