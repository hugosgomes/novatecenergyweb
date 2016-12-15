using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Unidades
    {
        public _40Unidades()
        {
            _40Cotacao = new HashSet<_40Cotacao>();
        }

        public int Cod { get; set; }
        public string Unidade { get; set; }

        public virtual ICollection<_40Cotacao> _40Cotacao { get; set; }
    }
}
