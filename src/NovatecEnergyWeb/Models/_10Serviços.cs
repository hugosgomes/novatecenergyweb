using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Serviços
    {
        public _10Serviços()
        {
            _10OsServiços = new HashSet<_10OsServiços>();
        }

        public int Id { get; set; }
        public string Item { get; set; }
        public string Descrição { get; set; }
        public decimal Valorsub { get; set; }
        public bool Status { get; set; }
        public int Tipo { get; set; }

        public virtual ICollection<_10OsServiços> _10OsServiços { get; set; }
    }
}
