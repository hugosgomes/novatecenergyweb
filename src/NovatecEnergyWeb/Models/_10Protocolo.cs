using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Protocolo
    {
        public int Cod { get; set; }
        public int Prot { get; set; }
        public int Cliente { get; set; }
        public int Prop { get; set; }

        public virtual Registro ClienteNavigation { get; set; }
    }
}
