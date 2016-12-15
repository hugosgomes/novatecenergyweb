using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ItemsRedeRamal
    {
        public _50ItemsRedeRamal()
        {
            _50ProjetoDesenvolvimento = new HashSet<_50ProjetoDesenvolvimento>();
        }

        public string Item { get; set; }
        public int? Cliente { get; set; }
        public int? Tipocontrato { get; set; }
        public int? Tipo { get; set; }
        public string Codigo { get; set; }
        public string Descrição { get; set; }
        public int? Diametro { get; set; }
        public int? Ud { get; set; }
        public double? Valorbase { get; set; }
        public string Unidade { get; set; }
        public string Ccontabil { get; set; }
        public double? Knvt { get; set; }
        public double? Valornvt { get; set; }
        public double? Valorsub { get; set; }
        public string Uso { get; set; }
        public int? D1 { get; set; }
        public int? D2 { get; set; }
        public double? D3 { get; set; }

        public virtual ICollection<_50ProjetoDesenvolvimento> _50ProjetoDesenvolvimento { get; set; }
        public virtual _00TiposContrato TipocontratoNavigation { get; set; }
    }
}
