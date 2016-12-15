using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _60CertificacaoEquipamentos
    {
        public int Cod { get; set; }
        public int? Id { get; set; }
        public decimal? Numcliente { get; set; }
        public string Numos { get; set; }
        public string Nomeos { get; set; }
        public string Nomecliente { get; set; }
        public string Endereçocliente { get; set; }
        public string Num { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Cpfcnpj { get; set; }
        public decimal? Valorcert { get; set; }
        public string Certificacao { get; set; }
        public string Uf { get; set; }
        public string Empresa { get; set; }
        public string Filial { get; set; }
        public string User { get; set; }
        public int? Agencia { get; set; }
        public string IdCaixa { get; set; }
        public string DataDoc { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataMovimento { get; set; }
        public double? Conta { get; set; }
        public string TipoDoc { get; set; }
        public decimal? NumDoc { get; set; }
        public decimal? Contrato { get; set; }
        public string Histórico { get; set; }
        public decimal? ValorDescontoIncPercent { get; set; }
        public double? Descontos { get; set; }
        public decimal? Retenção { get; set; }
        public double? Retenções { get; set; }
        public string SeriNf { get; set; }
        public string TipoNf { get; set; }
        public decimal? LoteNf { get; set; }
        public string NatopNf { get; set; }
        public string OpsnNf { get; set; }
        public string IcNf { get; set; }
        public string StatusRps { get; set; }
        public string CodigoMunicipio { get; set; }
        public string CodigoTributacaoMunicipio { get; set; }
        public string RegimeEspecialTributacao { get; set; }
        public string CodigoCnae { get; set; }
        public decimal? ValorDeducoesPercent { get; set; }
        public double? ValorDeducoes { get; set; }
        public decimal? ValorPisPercent { get; set; }
        public double? ValorPis { get; set; }
        public decimal? ValorCofinsPercent { get; set; }
        public double? ValorCofins { get; set; }
        public decimal? ValorInssPercent { get; set; }
        public double? ValorInss { get; set; }
        public decimal? ValorIrPercent { get; set; }
        public double? ValorIr { get; set; }
        public decimal? ValorCsllPercent { get; set; }
        public double? ValorCsll { get; set; }
        public decimal? IssRetido { get; set; }
        public double? ValorIssRetido { get; set; }
        public double? ValorIss { get; set; }
        public decimal? OutrasRetencoesPercent { get; set; }
        public double? OutrasRetencoes { get; set; }
        public decimal? Aliquota { get; set; }
        public double? BaseCalculo { get; set; }
        public double? ValorLiquido { get; set; }
        public decimal? DescontoCondicionadoPercent { get; set; }
        public double? DescontoCondicionado { get; set; }
        public string Servico { get; set; }
        public string Discriminacao { get; set; }
        public string CnpjPrest { get; set; }
        public string ImPrest { get; set; }
        public string Email { get; set; }
        public string CdmunicipioTom { get; set; }

        public virtual _60CertificacaoEquipamentosId IdNavigation { get; set; }
    }
}
