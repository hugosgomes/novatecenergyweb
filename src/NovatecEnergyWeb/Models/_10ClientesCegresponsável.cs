using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ClientesCegresponsável
    {
        public _10ClientesCegresponsável()
        {
            _10ClientesCegtemas = new HashSet<_10ClientesCegtemas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<_10ClientesCegtemas> _10ClientesCegtemas { get; set; }
    }
}
