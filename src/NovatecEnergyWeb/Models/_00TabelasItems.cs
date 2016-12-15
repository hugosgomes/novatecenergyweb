using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00TabelasItems
    {
        public int Id { get; set; }
        public int Tabela { get; set; }
        public string Campo { get; set; }
        public int? Ordem { get; set; }
        public string Item { get; set; }
    }
}
