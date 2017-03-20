using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Zona
    {
        public _00Zona()
        {
            _00Delegação = new HashSet<_00Delegação>();
        }

        public int Id { get; set; }
        public string Zona { get; set; }
        public string Z { get; set; }

        public virtual ICollection<_00Delegação> _00Delegação { get; set; }
        public IEnumerable<ClientesWeb> ClientesWeb { get;  set; }
    }
}
