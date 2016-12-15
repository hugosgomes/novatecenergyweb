using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProjetosRedeRamalTema
    {
        public _50ProjetosRedeRamalTema()
        {
            _50ProjetosRedeRamalObs = new HashSet<_50ProjetosRedeRamalObs>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Responsável { get; set; }

        public virtual ICollection<_50ProjetosRedeRamalObs> _50ProjetosRedeRamalObs { get; set; }
    }
}
