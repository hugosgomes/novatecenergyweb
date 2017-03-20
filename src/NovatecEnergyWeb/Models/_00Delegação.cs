using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Delegação
    {
        public _00Delegação()
        {
            _00Areas = new HashSet<_00Areas>();
            _10ValoresOp = new HashSet<_10ValoresOp>();
            _50PrecertId = new HashSet<_50PrecertId>();
        }

        public int Id { get; set; }
        public string Delegacao { get; set; }
        public int Zona { get; set; }
        public int? Cliente { get; set; }
        public string Delegacaok4 { get; set; }
        public string D { get; set; }

        public virtual ICollection<_00Areas> _00Areas { get; set; }
        public virtual ICollection<_10ValoresOp> _10ValoresOp { get; set; }
        public virtual ICollection<_50PrecertId> _50PrecertId { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual _00Zona ZonaNavigation { get; set; }
        public IEnumerable<ClientesWeb> ClientesWeb { get;  set; }
    }
}
