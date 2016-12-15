using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Comerciais
    {
        public _30Comerciais()
        {
            _30ComerciaisAreas = new HashSet<_30ComerciaisAreas>();
        }

        public int Id { get; set; }
        public int? Funcionario { get; set; }
        public string Produto { get; set; }
        public bool? Expgas { get; set; }
        public DateTime? _1admissao { get; set; }
        public string Tempogas { get; set; }
        public string _1empresa { get; set; }
        public int? Qtdempresas { get; set; }

        public virtual ICollection<_30ComerciaisAreas> _30ComerciaisAreas { get; set; }
        public virtual Funcionários FuncionarioNavigation { get; set; }
    }
}
