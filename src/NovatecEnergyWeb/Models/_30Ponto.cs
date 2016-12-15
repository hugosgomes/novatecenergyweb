using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Ponto
    {
        public int Cod { get; set; }
        public int Id { get; set; }
        public int Funcionário { get; set; }
        public decimal H50 { get; set; }
        public decimal H70 { get; set; }
        public decimal H100 { get; set; }
        public int Diastrabalhados { get; set; }
        public int Faltasjust { get; set; }
        public int Faltasinjust { get; set; }
        public int? Diasferias { get; set; }
        public int? Diasfolga { get; set; }

        public virtual _30PontoId IdNavigation { get; set; }
    }
}
