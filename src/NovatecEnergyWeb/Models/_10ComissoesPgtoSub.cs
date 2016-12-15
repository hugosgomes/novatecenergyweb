using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ComissoesPgtoSub
    {
        public int Cod { get; set; }
        public int Id { get; set; }
        public int Funcionario { get; set; }
        public int Cliente { get; set; }
        public decimal? Sat { get; set; }
        public decimal? Valorcom { get; set; }

        public virtual Registro ClienteNavigation { get; set; }
        public virtual _10ComissoesPgto IdNavigation { get; set; }
    }
}
