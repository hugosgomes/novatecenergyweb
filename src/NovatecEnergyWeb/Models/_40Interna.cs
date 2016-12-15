using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Interna
    {
        public int Cod { get; set; }
        public int? Interna { get; set; }
        public int Produto { get; set; }
        public int Quantidade { get; set; }

        public virtual _40InternaId InternaNavigation { get; set; }
    }
}
