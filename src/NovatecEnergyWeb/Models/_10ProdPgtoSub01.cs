using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ProdPgtoSub01
    {
        public _10ProdPgtoSub01()
        {
            _10OsServiços = new HashSet<_10OsServiços>();
        }

        public int Cod { get; set; }
        public int Id { get; set; }
        public int Os { get; set; }
        public int? Cliente { get; set; }
        public int Item { get; set; }
        public int Tipoprod { get; set; }
        public decimal Valorprod { get; set; }

        public virtual ICollection<_10OsServiços> _10OsServiços { get; set; }
        public virtual _10ProdPgtoId IdNavigation { get; set; }
    }
}
