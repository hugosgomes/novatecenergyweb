using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00TipoLog2
    {
        public _00TipoLog2()
        {
            _00TipoLogradouro = new HashSet<_00TipoLogradouro>();
        }

        public int Id { get; set; }
        public string Tipo2 { get; set; }
        public string AbrevCeg { get; set; }

        public virtual ICollection<_00TipoLogradouro> _00TipoLogradouro { get; set; }
    }
}
