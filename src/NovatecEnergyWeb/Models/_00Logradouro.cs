using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Logradouro
    {
        public _00Logradouro()
        {
            _00Empresa = new HashSet<_00Empresa>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Tipo2 { get; set; }
        public string Logradouro { get; set; }
        public string TipoAvbr { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Local { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? Bairro { get; set; }

        public virtual ICollection<_00Empresa> _00Empresa { get; set; }
        public virtual _00Bairro BairroNavigation { get; set; }
        public virtual _00TipoLogradouro TipoNavigation { get; set; }
    }
}
