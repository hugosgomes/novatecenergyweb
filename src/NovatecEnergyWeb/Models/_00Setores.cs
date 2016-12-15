using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Setores
    {
        public _00Setores()
        {
            _30Cargos = new HashSet<_30Cargos>();
            _40InternaId = new HashSet<_40InternaId>();
            Contas = new HashSet<Contas>();
        }

        public int Código { get; set; }
        public string Setor { get; set; }
        public int? Tipo { get; set; }

        public virtual ICollection<_30Cargos> _30Cargos { get; set; }
        public virtual ICollection<_40InternaId> _40InternaId { get; set; }
        public virtual ICollection<Contas> Contas { get; set; }
    }
}
