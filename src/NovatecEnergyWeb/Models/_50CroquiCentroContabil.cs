using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50CroquiCentroContabil
    {
        public _50CroquiCentroContabil()
        {
            _50Croquis = new HashSet<_50Croquis>();
            _50PrecertId = new HashSet<_50PrecertId>();
            _50ProjetosMetragem = new HashSet<_50ProjetosMetragem>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nome2 { get; set; }
        public string Id2 { get; set; }

        public virtual ICollection<_50Croquis> _50Croquis { get; set; }
        public virtual ICollection<_50PrecertId> _50PrecertId { get; set; }
        public virtual ICollection<_50ProjetosMetragem> _50ProjetosMetragem { get; set; }
    }
}
