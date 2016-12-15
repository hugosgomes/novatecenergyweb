using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50PrecertTipo
    {
        public _50PrecertTipo()
        {
            _50PrecertId = new HashSet<_50PrecertId>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<_50PrecertId> _50PrecertId { get; set; }
    }
}
