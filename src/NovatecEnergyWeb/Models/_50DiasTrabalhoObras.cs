using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50DiasTrabalhoObras
    {
        public _50DiasTrabalhoObras()
        {
            _50DiasTrabalhoMo = new HashSet<_50DiasTrabalhoMo>();
        }

        public int Cod { get; set; }
        public int? Id { get; set; }
        public int? Obra { get; set; }

        public virtual ICollection<_50DiasTrabalhoMo> _50DiasTrabalhoMo { get; set; }
        public virtual _50DiasTrabalho IdNavigation { get; set; }
    }
}
