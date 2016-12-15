using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50OpempreiteirasSub02
    {
        public int Cod { get; set; }
        public int Id { get; set; }
        public int Saidamat { get; set; }
        public decimal Valormat { get; set; }

        public virtual _50OpempreiteirasId IdNavigation { get; set; }
        public virtual _40SaidasId SaidamatNavigation { get; set; }
    }
}
