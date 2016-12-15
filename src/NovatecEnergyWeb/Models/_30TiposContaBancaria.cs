using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30TiposContaBancaria
    {
        public _30TiposContaBancaria()
        {
            Funcionários = new HashSet<Funcionários>();
        }

        public int Id { get; set; }
        public string Tipoconta { get; set; }
        public string Descrição { get; set; }

        public virtual ICollection<Funcionários> Funcionários { get; set; }
    }
}
