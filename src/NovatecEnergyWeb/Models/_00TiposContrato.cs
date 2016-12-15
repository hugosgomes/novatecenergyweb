using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00TiposContrato
    {
        public _00TiposContrato()
        {
            _20Contratos = new HashSet<_20Contratos>();
            _50ItemsRedeRamal = new HashSet<_50ItemsRedeRamal>();
        }

        public int Id { get; set; }
        public string Contrato { get; set; }

        public virtual ICollection<_20Contratos> _20Contratos { get; set; }
        public virtual ICollection<_50ItemsRedeRamal> _50ItemsRedeRamal { get; set; }
    }
}
