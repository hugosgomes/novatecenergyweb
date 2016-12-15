using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class CodVendas
    {
        public string CodVenda { get; set; }
        public decimal? Valor { get; set; }
        public string Descrição { get; set; }
        public string Status { get; set; }
    }
}
