using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Clase
    {
        public _40Clase()
        {
            _40Familia = new HashSet<_40Familia>();
        }

        public int Cod { get; set; }
        public string Clase { get; set; }
        public string Produnico { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<_40Familia> _40Familia { get; set; }
    }
}
