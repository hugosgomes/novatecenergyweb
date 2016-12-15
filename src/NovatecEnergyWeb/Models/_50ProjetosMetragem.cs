using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProjetosMetragem
    {
        public int Id { get; set; }
        public int Projeto { get; set; }
        public int? Conta { get; set; }
        public int Diametro { get; set; }
        public decimal Metragem { get; set; }

        public virtual _50CroquiCentroContabil ContaNavigation { get; set; }
        public virtual _50Tubos DiametroNavigation { get; set; }
    }
}
