using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Localidade
    {
        public _00Localidade()
        {
            _00Bairro = new HashSet<_00Bairro>();
        }

        public int Id { get; set; }
        public string Localidade { get; set; }
        public int Uf { get; set; }
        public string Municipioad { get; set; }
        public string Municipiok4 { get; set; }
        public string Ibge { get; set; }

        public virtual ICollection<_00Bairro> _00Bairro { get; set; }
        public virtual _00Estado UfNavigation { get; set; }
    }
}
