using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50OpempreiteirasSub01
    {
        public int Cod { get; set; }
        public int Idop { get; set; }
        public int Iddesenv { get; set; }
        public decimal Valor { get; set; }

        public virtual _50OpempreiteirasId IdopNavigation { get; set; }
    }
}
