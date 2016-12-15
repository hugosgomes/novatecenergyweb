using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30FormaPgtoVtvr
    {
        public _30FormaPgtoVtvr()
        {
            _30PontoPgtoId = new HashSet<_30PontoPgtoId>();
        }

        public int Id { get; set; }
        public string Formapgto { get; set; }

        public virtual ICollection<_30PontoPgtoId> _30PontoPgtoId { get; set; }
    }
}
