using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Contas
    {
        public int Id { get; set; }
        public int Empresa { get; set; }
        public int Filial { get; set; }
        public int Setor { get; set; }
        public string User { get; set; }
        public int Agencia { get; set; }
        public int? IdCaixa { get; set; }
        public string IdCaixa2 { get; set; }
        public double? IdCaixa3 { get; set; }
        public int IdCaixa4 { get; set; }
        public int IdCaixa5 { get; set; }
        public DateTime DataDoc { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataMovimento { get; set; }
        public DateTime? Datamovvto { get; set; }
        public int Conta { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public int? Cliente { get; set; }
        public int? Favorecido { get; set; }
        public double? Contrato { get; set; }
        public string Histórico { get; set; }
        public double? Importe { get; set; }
        public double? Impostos { get; set; }
        public double? Descontos { get; set; }
        public int? Retenção { get; set; }
        public double? Retenções { get; set; }
        public double? Entrada { get; set; }
        public double? Saída { get; set; }
        public string Documento { get; set; }
        public string ComprovantePgto { get; set; }
        public string Observações { get; set; }
        public int? Npedido { get; set; }
        public int? Ncert { get; set; }
        public string SeriNf { get; set; }
        public string TipoNf { get; set; }
        public double? LoteNf { get; set; }
        public string NatopNf { get; set; }
        public string OpsnNf { get; set; }
        public string IcNf { get; set; }
        public string StatusRps { get; set; }
        public int? CodigoMunicipio { get; set; }
        public string CodigoTributacaoMunicipio { get; set; }
        public string RegimeEspecialTributacao { get; set; }
        public string CodigoCnae { get; set; }
        public double? ValorDeducoes { get; set; }
        public double? ValorPis { get; set; }
        public double? ValorCofins { get; set; }
        public double? ValorInss { get; set; }
        public double? ValorIr { get; set; }
        public double? ValorCsll { get; set; }
        public double? ValorIss { get; set; }
        public double? IssRetido { get; set; }
        public double? ValorIssRetido { get; set; }
        public double? OutrasRetencoes { get; set; }
        public double? BaseCalculo { get; set; }
        public double? Aliquota { get; set; }
        public double? DescontoCondicionado { get; set; }
        public double? ValorLiquido { get; set; }
        public int? Servico { get; set; }
        public string Discriminacao { get; set; }
        public double? Procesada { get; set; }
        public int? GnscertEquipamentos { get; set; }

        public virtual _20Agencias AgenciaNavigation { get; set; }
        public virtual Clientes ClienteNavigation { get; set; }
        public virtual TipoDeConta ContaNavigation { get; set; }
        public virtual _20Contratos ContratoNavigation { get; set; }
        public virtual _00Empresa EmpresaNavigation { get; set; }
        public virtual Favorecidos FavorecidoNavigation { get; set; }
        public virtual _00Filial FilialNavigation { get; set; }
        public virtual _20EntidadesBancarias IdCaixaNavigation { get; set; }
        public virtual _00Setores SetorNavigation { get; set; }
        public virtual TipoDeDocumento TipoDocNavigation { get; set; }
    }
}
