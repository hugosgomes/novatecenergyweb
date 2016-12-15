using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProjetosRedeRamalDetalheN
    {
        public _50ProjetosRedeRamalDetalheN()
        {
            _50ProjetosRedeRamalObs = new HashSet<_50ProjetosRedeRamalObs>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Tema { get; set; }

        public virtual ICollection<_50ProjetosRedeRamalObs> _50ProjetosRedeRamalObs { get; set; }
    }
}
