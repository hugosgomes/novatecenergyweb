using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Precert
    {
        public int Cod { get; set; }
        public int Npre { get; set; }
        public int? Cliente { get; set; }
        public decimal? Valorunit { get; set; }
        public string Cups { get; set; }

        public virtual Registro ClienteNavigation { get; set; }
        public virtual _10PrecertId NpreNavigation { get; set; }
    }
}
