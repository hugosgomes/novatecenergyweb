using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50PlanoTesteMat
    {
        public int Id { get; set; }
        public int? Material { get; set; }
        public int? Tipo { get; set; }
        public int? Diametro { get; set; }

        public virtual _40Produtos MaterialNavigation { get; set; }
    }
}
