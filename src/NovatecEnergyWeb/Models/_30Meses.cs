using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Meses
    {
        public _30Meses()
        {
            _30PontoPgtoId = new HashSet<_30PontoPgtoId>();
            _30SalariosId = new HashSet<_30SalariosId>();
        }

        public int Num { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<_30PontoPgtoId> _30PontoPgtoId { get; set; }
        public virtual ICollection<_30SalariosId> _30SalariosId { get; set; }
    }
}
