using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class TipoDeConta
    {
        public TipoDeConta()
        {
            Contas = new HashSet<Contas>();
        }

        public int Cod { get; set; }
        public string TipoDeConta1 { get; set; }
        public string Tipopgto { get; set; }

        public virtual ICollection<Contas> Contas { get; set; }
    }
}
