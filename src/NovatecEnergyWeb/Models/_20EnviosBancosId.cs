using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _20EnviosBancosId
    {
        public _20EnviosBancosId()
        {
            _20EnviosBancos = new HashSet<_20EnviosBancos>();
        }

        public int Id { get; set; }
        public int? Hempresa { get; set; }
        public int? Hbanco { get; set; }
        public int? Hagencia { get; set; }
        public string T05qtdelotes { get; set; }
        public string T06qtderegs { get; set; }
        public bool? Procesado { get; set; }

        public virtual ICollection<_20EnviosBancos> _20EnviosBancos { get; set; }
    }
}
