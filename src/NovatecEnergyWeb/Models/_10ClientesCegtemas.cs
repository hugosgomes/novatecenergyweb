using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ClientesCegtemas
    {
        public _10ClientesCegtemas()
        {
            _10ClientesCegobs = new HashSet<_10ClientesCegobs>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Responsável { get; set; }

        public virtual ICollection<_10ClientesCegobs> _10ClientesCegobs { get; set; }
        public virtual _10ClientesCegresponsável ResponsávelNavigation { get; set; }
    }
}
