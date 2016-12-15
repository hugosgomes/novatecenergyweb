using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class TipoDeDocumento
    {
        public TipoDeDocumento()
        {
            Contas = new HashSet<Contas>();
        }

        public string Cod { get; set; }
        public string TipoDoc { get; set; }

        public virtual ICollection<Contas> Contas { get; set; }
    }
}
