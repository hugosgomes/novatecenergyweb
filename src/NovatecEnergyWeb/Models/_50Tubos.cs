using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50Tubos
    {
        public _50Tubos()
        {
            _50ProjetosMetragem = new HashSet<_50ProjetosMetragem>();
        }

        public int Id { get; set; }
        public decimal? Diametro { get; set; }
        public string Polegadas { get; set; }

        public virtual ICollection<_50ProjetosMetragem> _50ProjetosMetragem { get; set; }
    }
}
