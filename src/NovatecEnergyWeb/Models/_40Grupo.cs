using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Grupo
    {
        public _40Grupo()
        {
            _40Familia = new HashSet<_40Familia>();
        }

        public int Cod { get; set; }
        public string Grupo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<_40Familia> _40Familia { get; set; }
    }
}
