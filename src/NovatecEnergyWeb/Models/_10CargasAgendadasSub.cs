using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10CargasAgendadasSub
    {
        public int Cod { get; set; }
        public int? Id { get; set; }
        public int? Protocolonvt { get; set; }

        public virtual _10CargasAgendadasId IdNavigation { get; set; }
        public virtual _10ClientesCegobs ProtocolonvtNavigation { get; set; }
    }
}
