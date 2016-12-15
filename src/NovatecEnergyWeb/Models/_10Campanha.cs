using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Campanha
    {
        public int Cod { get; set; }
        public int Campanha { get; set; }
        public int Promoção { get; set; }

        public virtual _10CampanhaId CampanhaNavigation { get; set; }
        public virtual _10Promos PromoçãoNavigation { get; set; }
    }
}
