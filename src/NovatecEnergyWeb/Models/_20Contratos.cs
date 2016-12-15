using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _20Contratos
    {
        public _20Contratos()
        {
            Contas = new HashSet<Contas>();
        }

        public double Contrato { get; set; }
        public int Setor { get; set; }
        public int? Cliente { get; set; }
        public int? TipoDeConta { get; set; }
        public int? Tipo { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Descrição { get; set; }
        public string Ativo { get; set; }
        public int? Historico { get; set; }
        public double? Ngor { get; set; }
        public double? Nwk { get; set; }

        public virtual ICollection<Contas> Contas { get; set; }
        public virtual _00TiposContrato TipoNavigation { get; set; }
    }
}
