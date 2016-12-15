using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Escolaridade
    {
        public _30Escolaridade()
        {
            Funcionários = new HashSet<Funcionários>();
        }

        public int Id { get; set; }
        public string Escolaridade { get; set; }

        public virtual ICollection<Funcionários> Funcionários { get; set; }
    }
}
