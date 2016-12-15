using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11CondominiosTemas
    {
        public _11CondominiosTemas()
        {
            _11CondominiosObs = new HashSet<_11CondominiosObs>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Responsável { get; set; }

        public virtual ICollection<_11CondominiosObs> _11CondominiosObs { get; set; }
        public virtual _11CondominiosResponsavel ResponsávelNavigation { get; set; }
    }
}
