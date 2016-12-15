using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10CargasAgendadasId
    {
        public _10CargasAgendadasId()
        {
            _10CargasAgendadasSub = new HashSet<_10CargasAgendadasSub>();
        }

        public int Id { get; set; }
        public int Zona { get; set; }
        public string Envio { get; set; }
        public int Numenvio { get; set; }
        public DateTime Dataenvio { get; set; }
        public string Userenvio { get; set; }
        public DateTime Datacargas { get; set; }

        public virtual ICollection<_10CargasAgendadasSub> _10CargasAgendadasSub { get; set; }
    }
}
