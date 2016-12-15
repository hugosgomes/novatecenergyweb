using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ProtocoloTemp
    {
        public int Cod { get; set; }
        public int Prot { get; set; }
        public int Cliente { get; set; }
        public int Prop { get; set; }

        public virtual _10ProtocoloId ProtNavigation { get; set; }
    }
}
