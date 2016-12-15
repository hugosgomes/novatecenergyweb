using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Localização
    {
        public _40Localização()
        {
            _40Local = new HashSet<_40Local>();
        }

        public int Cod { get; set; }
        public int Centro { get; set; }
        public string Localizacao { get; set; }
        public string Descriçao { get; set; }

        public virtual ICollection<_40Local> _40Local { get; set; }
        public virtual _40Centros CentroNavigation { get; set; }
    }
}
