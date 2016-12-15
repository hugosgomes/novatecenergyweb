using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Filial
    {
        public _00Filial()
        {
            _30Cargos = new HashSet<_30Cargos>();
            _30PontoId = new HashSet<_30PontoId>();
            _30PontoPgtoId = new HashSet<_30PontoPgtoId>();
            _30SodexoParametros = new HashSet<_30SodexoParametros>();
            Contas = new HashSet<Contas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Estado { get; set; }
        public int Localidade { get; set; }
        public int Bairro { get; set; }
        public int Tipovia { get; set; }
        public int Logradouro { get; set; }
        public double Num { get; set; }
        public string Comp { get; set; }

        public virtual ICollection<_30Cargos> _30Cargos { get; set; }
        public virtual ICollection<_30PontoId> _30PontoId { get; set; }
        public virtual ICollection<_30PontoPgtoId> _30PontoPgtoId { get; set; }
        public virtual ICollection<_30SodexoParametros> _30SodexoParametros { get; set; }
        public virtual ICollection<Contas> Contas { get; set; }
    }
}
