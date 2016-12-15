using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProjetoMateriais
    {
        public int Id { get; set; }
        public int Croqui { get; set; }
        public int Lote { get; set; }
        public decimal? Qtde { get; set; }

        public virtual _50Croquis CroquiNavigation { get; set; }
    }
}
