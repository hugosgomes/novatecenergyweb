using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50LotesPlanoTeste
    {
        public int Cod { get; set; }
        public int? Id { get; set; }
        public int? Croqui { get; set; }

        public virtual _50Croquis CroquiNavigation { get; set; }
        public virtual _50LotesPlanoTesteId IdNavigation { get; set; }
    }
}
