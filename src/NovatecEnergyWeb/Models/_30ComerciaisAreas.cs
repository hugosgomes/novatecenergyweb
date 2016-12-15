using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30ComerciaisAreas
    {
        public int Id { get; set; }
        public int? Comercial { get; set; }
        public int? Area { get; set; }

        public virtual _00Areas AreaNavigation { get; set; }
        public virtual _30Comerciais ComercialNavigation { get; set; }
    }
}
