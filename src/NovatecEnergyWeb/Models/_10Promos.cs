using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Promos
    {
        public _10Promos()
        {
            _10Campanha = new HashSet<_10Campanha>();
        }

        public int Cod { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Descrição { get; set; }
        public string Seguimento { get; set; }

        public virtual ICollection<_10Campanha> _10Campanha { get; set; }
    }
}
