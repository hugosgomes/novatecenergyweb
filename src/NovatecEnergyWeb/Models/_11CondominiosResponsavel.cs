using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11CondominiosResponsavel
    {
        public _11CondominiosResponsavel()
        {
            _11CondominiosTemas = new HashSet<_11CondominiosTemas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<_11CondominiosTemas> _11CondominiosTemas { get; set; }
    }
}
