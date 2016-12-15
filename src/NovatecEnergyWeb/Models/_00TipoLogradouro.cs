using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00TipoLogradouro
    {
        public _00TipoLogradouro()
        {
            _00Logradouro = new HashSet<_00Logradouro>();
        }

        public string Tipo { get; set; }
        public int? Tipo2 { get; set; }
        public string Abreviatura { get; set; }
        public string AbrevCeg { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<_00Logradouro> _00Logradouro { get; set; }
        public virtual _00TipoLog2 Tipo2Navigation { get; set; }
    }
}
