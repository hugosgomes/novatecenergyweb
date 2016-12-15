using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30PontoId
    {
        public _30PontoId()
        {
            _30Ponto = new HashSet<_30Ponto>();
        }

        public int Id { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Empresa { get; set; }
        public int Filial { get; set; }

        public virtual ICollection<_30Ponto> _30Ponto { get; set; }
        public virtual _30Anos AnoNavigation { get; set; }
        public virtual _00Empresa EmpresaNavigation { get; set; }
        public virtual _00Filial FilialNavigation { get; set; }
    }
}
