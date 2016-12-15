using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class NfseNotas
    {
        public int Idnf { get; set; }
        public string DtNf { get; set; }
        public double? NNf { get; set; }
        public double? LoteNf { get; set; }
        public string SeriNf { get; set; }
        public string TipoNf { get; set; }
        public string NatopNf { get; set; }
        public string OpsnNf { get; set; }
        public string IcNf { get; set; }
        public string StatusRps { get; set; }
        public double? ValorServicos { get; set; }
        public double? ValorLiquidoNfse { get; set; }
        public double? ValorDeducoes { get; set; }
        public double? ValorPis { get; set; }
        public double? ValorCofins { get; set; }
        public double? ValorInss { get; set; }
        public double? ValorIr { get; set; }
        public double? ValorCsll { get; set; }
        public double? IssRetido { get; set; }
        public double? ValorIss { get; set; }
        public double? ValorIssRetido { get; set; }
        public double? OutrasRetencoes { get; set; }
        public double? BaseCalculo { get; set; }
        public double? Aliquota { get; set; }
        public double? DescontoIncondicionado { get; set; }
        public double? DescontoCondicionado { get; set; }
        public string ItemListaServico { get; set; }
        public string CodigoTributacaoMunicipio { get; set; }
        public string Discriminacao { get; set; }
        public int? CodigoMunicipio { get; set; }
        public string CnpjPrest { get; set; }
        public string ImPrest { get; set; }
        public string CodigoCnae { get; set; }
        public string CnpjTom { get; set; }
        public string ImTom { get; set; }
        public string IeTom { get; set; }
        public string RazaoTom { get; set; }
        public string EndTom { get; set; }
        public string NunTom { get; set; }
        public string CompTom { get; set; }
        public string BairroTom { get; set; }
        public string MunicipTom { get; set; }
        public string CdmunicipioTom { get; set; }
        public string UfTom { get; set; }
        public string CepTom { get; set; }
        public string EmailTom { get; set; }
        public string TelTom { get; set; }
        public string RegimeEspecialTributacao { get; set; }
        public string StatusProc { get; set; }
        public string CdReDll { get; set; }
        public string HistEvent { get; set; }
        public string ProtocoloRec { get; set; }
        public string ProtocoloDataRec { get; set; }
        public string NNfse { get; set; }
        public float? NErr { get; set; }
        public string SNprotocolo { get; set; }
        public string SCdverificacao { get; set; }
        public string SDataHoraRetorno { get; set; }
        public string InfoCliente { get; set; }
        public int? Codigo { get; set; }
        public string NContrato { get; set; }
        public string Tipocontrato { get; set; }
        public DateTime? Datacontrato { get; set; }
        public bool? Baixado { get; set; }
        public bool? Atualizado { get; set; }
        public int? NConta { get; set; }
        public string CodigoObra { get; set; }
        public string Art { get; set; }
    }
}
