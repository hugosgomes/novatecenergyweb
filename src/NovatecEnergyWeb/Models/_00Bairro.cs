using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Bairro
    {
        public _00Bairro()
        {
            _00Logradouro = new HashSet<_00Logradouro>();
        }

        public int Id { get; set; }
        public string Bairro { get; set; }
        public int Loc { get; set; }
        public int? Area { get; set; }

        public virtual ICollection<_00Logradouro> _00Logradouro { get; set; }
        public virtual _00Areas AreaNavigation { get; set; }
        public virtual _00Localidade LocNavigation { get; set; }
    }
}
