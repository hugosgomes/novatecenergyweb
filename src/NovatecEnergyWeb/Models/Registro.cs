using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Registro
    {
        public Registro()
        {
            _10Certificados = new HashSet<_10Certificados>();
            _10ClientesCegobs = new HashSet<_10ClientesCegobs>();
            _10ComissoesPgtoSub = new HashSet<_10ComissoesPgtoSub>();
            _10PgtoPromos = new HashSet<_10PgtoPromos>();
            _10Precert = new HashSet<_10Precert>();
            _10Protocolo = new HashSet<_10Protocolo>();
        }

        public int CodCliente { get; set; }
        public int Casa { get; set; }
        public double? Ncliente { get; set; }
        public string Nsolicitacao { get; set; }
        public string Cups { get; set; }
        public string User { get; set; }
        public double? PropCeg { get; set; }
        public double? PropNvt { get; set; }
        public string PropGns { get; set; }
        public string NomeESobrenome { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Cpf { get; set; }
        public int Tipo { get; set; }
        public int? Procedencia { get; set; }
        public DateTime? Datacadastro { get; set; }
        public DateTime DataVenda { get; set; }
        public int Status { get; set; }
        public int Statusb { get; set; }
        public DateTime? DataStatus { get; set; }
        public int? Periodo { get; set; }
        public int TxInscrição { get; set; }
        public string Coordenador { get; set; }
        public int AgComercial { get; set; }
        public int FgAq { get; set; }
        public int Marcafogão { get; set; }
        public int Marcaaquecedor { get; set; }
        public string Conversãofogão { get; set; }
        public string Conversãoaquecedor { get; set; }
        public int? TarifaSocial { get; set; }
        public int? Campanha { get; set; }
        public double? Valorop { get; set; }
        public string Propcegnzeus { get; set; }
        public string Propnvtnzeus { get; set; }

        public virtual ICollection<_10Certificados> _10Certificados { get; set; }
        public virtual ICollection<_10ClientesCegobs> _10ClientesCegobs { get; set; }
        public virtual ICollection<_10ComissoesPgtoSub> _10ComissoesPgtoSub { get; set; }
        public virtual ICollection<_10PgtoPromos> _10PgtoPromos { get; set; }
        public virtual ICollection<_10Precert> _10Precert { get; set; }
        public virtual ICollection<_10Protocolo> _10Protocolo { get; set; }
        public virtual Funcionários AgComercialNavigation { get; set; }
        public virtual _11CondEstrutura CasaNavigation { get; set; }
    }
}
