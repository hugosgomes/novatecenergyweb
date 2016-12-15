using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProcertAcres
    {
        public _50ProcertAcres()
        {
            _50Precert = new HashSet<_50Precert>();
        }

        public decimal Id { get; set; }

        public virtual ICollection<_50Precert> _50Precert { get; set; }
    }
}
