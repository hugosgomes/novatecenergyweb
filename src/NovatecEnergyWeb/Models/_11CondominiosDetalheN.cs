using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11CondominiosDetalheN
    {
        public _11CondominiosDetalheN()
        {
            _11CondominiosObs = new HashSet<_11CondominiosObs>();
        }

        public int Id { get; set; }
        public int? Tema { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<_11CondominiosObs> _11CondominiosObs { get; set; }
    }
}
