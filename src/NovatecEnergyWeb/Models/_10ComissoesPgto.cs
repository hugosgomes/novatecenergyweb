using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ComissoesPgto
    {
        public _10ComissoesPgto()
        {
            _10ComissoesPgtoSub = new HashSet<_10ComissoesPgtoSub>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Usersistema { get; set; }
        public int? Temp { get; set; }
        public decimal? Total { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<_10ComissoesPgtoSub> _10ComissoesPgtoSub { get; set; }
    }
}
