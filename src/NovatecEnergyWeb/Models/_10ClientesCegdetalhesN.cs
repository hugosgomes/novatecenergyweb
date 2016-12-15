using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ClientesCegdetalhesN
    {
        public _10ClientesCegdetalhesN()
        {
            _10ClientesCegobs = new HashSet<_10ClientesCegobs>();
        }

        public int Id { get; set; }
        public int? Tema { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<_10ClientesCegobs> _10ClientesCegobs { get; set; }
    }
}
