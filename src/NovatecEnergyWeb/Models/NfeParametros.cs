using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class NfeParametros
    {
        public int CodigoInt { get; set; }
        public int? Tipo { get; set; }
        public string Cnaefiscal { get; set; }
        public float? CodigoIbge { get; set; }
        public string CdUf { get; set; }
        public string CnpjCpf { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Logradouro { get; set; }
        public string NLogra { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Muncipio { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public double? RgTributario { get; set; }
        public string WebService { get; set; }
        public string SiglaWebService { get; set; }
        public string VersaoSchema { get; set; }
        public string IdentificacaoAmbiente { get; set; }
        public string Certificado { get; set; }
        public string LicencaDll { get; set; }
        public string Proxy { get; set; }
        public string UsuarioProxy { get; set; }
        public string SenhaProxy { get; set; }
        public double? ModelNf { get; set; }
        public string TipoCert { get; set; }
        public string Certifiadora { get; set; }
        public string LogoMarca { get; set; }
        public bool? Logo { get; set; }
        public string Smtp { get; set; }
        public string SmtpPorta { get; set; }
        public string SmtpSsl { get; set; }
        public string SmtpUsuario { get; set; }
        public string SmtpSenha { get; set; }
        public string SmtpMail { get; set; }
        public string EnvHtml { get; set; }
        public string EnvConf { get; set; }
        public string Envimsm { get; set; }
        public string DanfeAut { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
