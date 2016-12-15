using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30EstadoCivil
    {
        public _30EstadoCivil()
        {
            Funcionários = new HashSet<Funcionários>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Funcionários> Funcionários { get; set; }
    }
}
