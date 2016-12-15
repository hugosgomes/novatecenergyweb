using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50Precert
    {
        public int Cod { get; set; }
        public int Idpre { get; set; }
        public int? Numreg { get; set; }
        public int Croqui { get; set; }
        public string Item { get; set; }
        public decimal Atual { get; set; }
        public decimal Anterior { get; set; }
        public decimal? Total { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Valornvt { get; set; }

        public virtual _50Croquis CroquiNavigation { get; set; }
        public virtual _50ProcertAcres DescontoNavigation { get; set; }
        public virtual _50PrecertId IdpreNavigation { get; set; }
    }
}
