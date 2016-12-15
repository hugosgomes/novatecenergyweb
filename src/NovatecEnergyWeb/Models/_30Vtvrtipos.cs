using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Vtvrtipos
    {
        public _30Vtvrtipos()
        {
            Funcionários = new HashSet<Funcionários>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Codsodexo { get; set; }

        public virtual ICollection<Funcionários> Funcionários { get; set; }
    }
}
