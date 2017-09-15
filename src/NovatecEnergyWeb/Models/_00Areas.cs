using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Areas
    {
        public _00Areas()
        {
            _00Bairro = new HashSet<_00Bairro>();
            _30ComerciaisAreas = new HashSet<_30ComerciaisAreas>();
        }

        public int Id { get; set; }
        public string Area { get; set; }
        public int? Delegacao { get; set; }
        public string Ge { get; set; }
        public string Go { get; set; }

        public virtual ICollection<_00Bairro> _00Bairro { get; set; }
        public virtual ICollection<_30ComerciaisAreas> _30ComerciaisAreas { get; set; }
        public virtual _00Delegação DelegacaoNavigation { get; set; }
        public virtual IEnumerable<ClientesAreas> ClientesAreas { get; set; }
        public virtual IEnumerable<_13Lotes> _13Lotes { get; set; }
        public virtual IEnumerable<_12Lotes> _12Lotes { get; set; }
    }
}
