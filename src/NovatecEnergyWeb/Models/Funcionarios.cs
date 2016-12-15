using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Funcionários
    {
        public Funcionários()
        {
            _30Comerciais = new HashSet<_30Comerciais>();
            _50CroquisDesenhistaNavigation = new HashSet<_50Croquis>();
            _50CroquisEncanadorNavigation = new HashSet<_50Croquis>();
            _50CroquisEncarregadoNavigation = new HashSet<_50Croquis>();
            _50CroquisSoldadorNavigation = new HashSet<_50Croquis>();
            _50OpproducaoA = new HashSet<_50OpproducaoA>();
            _50OpproducaoB = new HashSet<_50OpproducaoB>();
            Registro = new HashSet<Registro>();
        }

        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int Empresa { get; set; }
        public int Filial { get; set; }
        public int Setor { get; set; }
        public int Estado { get; set; }
        public int Localidade { get; set; }
        public int Bairro { get; set; }
        public int Tipo { get; set; }
        public int Logradouro { get; set; }
        public string Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public string Comp { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime? Datarg { get; set; }
        public string Ufrg { get; set; }
        public string ÓrgaoEmisor { get; set; }
        public string Pis { get; set; }
        public DateTime? CadastroPis { get; set; }
        public string Nomemae { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public int? Estadocivil { get; set; }
        public string TlfFixoPessoal { get; set; }
        public string CelPessoal { get; set; }
        public string CelPessoal2 { get; set; }
        public string EMailPessoal { get; set; }
        public int Escolaridade { get; set; }
        public string CarteiraProfissional { get; set; }
        public int TituloFunção { get; set; }
        public string NºDoTítulo { get; set; }
        public DateTime? ExpediçãoTítulo { get; set; }
        public string EMailCorporativo { get; set; }
        public int? Ramal { get; set; }
        public int? Pc { get; set; }
        public int? Tipovt { get; set; }
        public decimal? Vt { get; set; }
        public int? Tipovr { get; set; }
        public decimal? Vr { get; set; }
        public string Blusa { get; set; }
        public double? Calça { get; set; }
        public double? Bota { get; set; }
        public DateTime? DataDeAdmissão { get; set; }
        public DateTime? DataDeDemissão { get; set; }
        public decimal? Motivodeslig { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int? Grupo { get; set; }
        public bool? Master { get; set; }
        public int? Banco { get; set; }
        public string Agencia { get; set; }
        public string Dva { get; set; }
        public string Numeroconta { get; set; }
        public string Dvc { get; set; }
        public string ContaBancária { get; set; }
        public int? Tipoconta { get; set; }
        public decimal? Produto { get; set; }
        public decimal? Experienciagas { get; set; }
        public string Contadorid { get; set; }
        public string LocalFoto { get; set; }
        public int Status { get; set; }
        public string Riocardmat { get; set; }
        public string Riocardcart { get; set; }
        public bool? Sistema { get; set; }

        public virtual ICollection<_30Comerciais> _30Comerciais { get; set; }
        public virtual ICollection<_50Croquis> _50CroquisDesenhistaNavigation { get; set; }
        public virtual ICollection<_50Croquis> _50CroquisEncanadorNavigation { get; set; }
        public virtual ICollection<_50Croquis> _50CroquisEncarregadoNavigation { get; set; }
        public virtual ICollection<_50Croquis> _50CroquisSoldadorNavigation { get; set; }
        public virtual ICollection<_50OpproducaoA> _50OpproducaoA { get; set; }
        public virtual ICollection<_50OpproducaoB> _50OpproducaoB { get; set; }
        public virtual ICollection<Registro> Registro { get; set; }
        public virtual _20EntidadesBancarias BancoNavigation { get; set; }
        public virtual _30Escolaridade EscolaridadeNavigation { get; set; }
        public virtual _30EstadoCivil EstadocivilNavigation { get; set; }
        public virtual _30TiposContaBancaria TipocontaNavigation { get; set; }
        public virtual _30Vtvrtipos TipovrNavigation { get; set; }
        public virtual _30Cargos TituloFunçãoNavigation { get; set; }
    }
}
