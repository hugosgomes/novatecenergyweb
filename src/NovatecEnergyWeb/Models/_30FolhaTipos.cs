using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30FolhaTipos
    {
        public _30FolhaTipos()
        {
            _30SalariosId = new HashSet<_30SalariosId>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? Conta { get; set; }

        public virtual ICollection<_30SalariosId> _30SalariosId { get; set; }
    }
}
