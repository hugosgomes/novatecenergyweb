using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30CargosB
    {
        public _30CargosB()
        {
            _30Cargos = new HashSet<_30Cargos>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Orde { get; set; }

        public virtual ICollection<_30Cargos> _30Cargos { get; set; }
    }
}
