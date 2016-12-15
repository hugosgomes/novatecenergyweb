using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50DiasTrabalhoMo
    {
        public int Cod { get; set; }
        public int? Coddia { get; set; }
        public int? Funcionario { get; set; }

        public virtual _50DiasTrabalhoObras CoddiaNavigation { get; set; }
    }
}
