using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30PontoPgto
    {
        public int Cod { get; set; }
        public int Id { get; set; }
        public int Funcionário { get; set; }
        public int Vt { get; set; }
        public decimal? Vtvalor { get; set; }
        public int Vr { get; set; }
        public decimal? Vrvalor { get; set; }
        public int? Idconta { get; set; }

        public virtual _30PontoPgtoId IdNavigation { get; set; }
    }
}
