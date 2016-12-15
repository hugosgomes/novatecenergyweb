using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Empresa
    {
        public _00Empresa()
        {
            _30Cargos = new HashSet<_30Cargos>();
            _30PontoId = new HashSet<_30PontoId>();
            _30PontoPgtoId = new HashSet<_30PontoPgtoId>();
            _30SodexoParametros = new HashSet<_30SodexoParametros>();
            Contas = new HashSet<Contas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string RazãoSocial { get; set; }
        public string Logotipo { get; set; }
        public string Cnpj { get; set; }
        public string Im { get; set; }
        public string Ie { get; set; }
        public string Site { get; set; }
        public string Email { get; set; }
        public int Estado { get; set; }
        public int Localidade { get; set; }
        public int Bairro { get; set; }
        public int Tipo { get; set; }
        public int Logradouro { get; set; }
        public string Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public string Comp { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Observações { get; set; }
        public string Raiz { get; set; }

        public virtual ICollection<_30Cargos> _30Cargos { get; set; }
        public virtual ICollection<_30PontoId> _30PontoId { get; set; }
        public virtual ICollection<_30PontoPgtoId> _30PontoPgtoId { get; set; }
        public virtual ICollection<_30SodexoParametros> _30SodexoParametros { get; set; }
        public virtual ICollection<Contas> Contas { get; set; }
        public virtual _00Logradouro LogradouroNavigation { get; set; }
    }
}
