using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Osmateriais
    {
        public int Id { get; set; }
        public int? Protocolo { get; set; }
        public int? Os { get; set; }
        public int Produto { get; set; }
        public decimal Qtde { get; set; }

        public virtual _10ClientesCegobs ProtocoloNavigation { get; set; }
    }
}
