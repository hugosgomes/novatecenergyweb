using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Anos
    {
        public _30Anos()
        {
            _30PontoId = new HashSet<_30PontoId>();
            _30PontoPgtoId = new HashSet<_30PontoPgtoId>();
            _30SalariosId = new HashSet<_30SalariosId>();
        }

        public int Ano { get; set; }

        public virtual ICollection<_30PontoId> _30PontoId { get; set; }
        public virtual ICollection<_30PontoPgtoId> _30PontoPgtoId { get; set; }
        public virtual ICollection<_30SalariosId> _30SalariosId { get; set; }
    }
}
