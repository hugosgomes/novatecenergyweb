using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Estado
    {
        public _00Estado()
        {
            _00Localidade = new HashSet<_00Localidade>();
        }

        public int Id { get; set; }
        public string Uf { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<_00Localidade> _00Localidade { get; set; }
    }
}
