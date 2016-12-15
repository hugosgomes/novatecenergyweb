using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProjetoDesenvolvimento
    {
        public int Id { get; set; }
        public int Croqui { get; set; }
        public string Item { get; set; }
        public int Empresa { get; set; }
        public decimal? Medant { get; set; }
        public decimal? Meddia { get; set; }
        public decimal? Medtotal { get; set; }
        public double? Desconto { get; set; }

        public virtual _50Croquis CroquiNavigation { get; set; }
        public virtual _40Parceiros EmpresaNavigation { get; set; }
        public virtual _50ItemsRedeRamal ItemNavigation { get; set; }
    }
}
