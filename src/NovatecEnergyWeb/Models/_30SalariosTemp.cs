using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30SalariosTemp
    {
        public int Cod { get; set; }
        public int? Idfolha { get; set; }
        public string Contadorid { get; set; }
        public decimal? Salariobruto { get; set; }
        public decimal? Salarioliquido { get; set; }
        public int Empresa { get; set; }

        public virtual _30SalariosId IdfolhaNavigation { get; set; }
    }
}
