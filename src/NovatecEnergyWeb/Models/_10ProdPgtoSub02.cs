using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ProdPgtoSub02
    {
        public int Cod { get; set; }
        public int Id { get; set; }
        public int Saidamat { get; set; }
        public decimal Valormat { get; set; }

        public virtual _10ProdPgtoId IdNavigation { get; set; }
        public virtual _40SaidasId SaidamatNavigation { get; set; }
    }
}
