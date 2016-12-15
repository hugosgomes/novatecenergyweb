using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10OsServiços
    {
        public int Id { get; set; }
        public int Protocolo { get; set; }
        public int? Os { get; set; }
        public int Item { get; set; }
        public decimal Qtde { get; set; }
        public int? P1 { get; set; }
        public int? P2 { get; set; }

        public virtual _10Serviços ItemNavigation { get; set; }
        public virtual _10ProdPgtoSub01 P1Navigation { get; set; }
        public virtual _10ClientesCegobs ProtocoloNavigation { get; set; }
    }
}
