using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Familia
    {
        public _40Familia()
        {
            _40Produtos = new HashSet<_40Produtos>();
        }

        public int Cod { get; set; }
        public int? Grupo { get; set; }
        public int? Clase { get; set; }
        public string Familia { get; set; }

        public virtual ICollection<_40Produtos> _40Produtos { get; set; }
        public virtual _40Clase ClaseNavigation { get; set; }
        public virtual _40Grupo GrupoNavigation { get; set; }
    }
}
