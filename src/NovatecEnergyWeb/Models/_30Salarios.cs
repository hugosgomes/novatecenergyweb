using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Salarios
    {
        public int Cod { get; set; }
        public int? Idfolha { get; set; }
        public int? Funcionario { get; set; }
        public decimal? Salario { get; set; }
        public int? Idconta { get; set; }

        public virtual _30SalariosId IdfolhaNavigation { get; set; }
    }
}
