using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10EquipeVendas
    {
        public int Id { get; set; }
        public DateTime Emissao { get; set; }
        public int Agente { get; set; }
        public int Supervisor { get; set; }
        public int? Lider { get; set; }
    }
}
