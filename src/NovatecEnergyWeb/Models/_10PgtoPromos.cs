using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10PgtoPromos
    {
        public int Cod { get; set; }
        public int Idpgto { get; set; }
        public int Cliente { get; set; }
        public int Promo { get; set; }

        public virtual Registro ClienteNavigation { get; set; }
        public virtual _10PgtoPromosId IdpgtoNavigation { get; set; }
    }
}
