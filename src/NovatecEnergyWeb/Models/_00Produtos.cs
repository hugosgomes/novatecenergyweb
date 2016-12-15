using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00Produtos
    {
        public _00Produtos()
        {
            _10ValoresOp = new HashSet<_10ValoresOp>();
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public int? Agrup { get; set; }

        public virtual ICollection<_10ValoresOp> _10ValoresOp { get; set; }
    }
}
