using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10PgtoPromosId
    {
        public _10PgtoPromosId()
        {
            _10PgtoPromos = new HashSet<_10PgtoPromos>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }

        public virtual ICollection<_10PgtoPromos> _10PgtoPromos { get; set; }
    }
}
