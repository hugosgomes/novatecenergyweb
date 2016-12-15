using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11CondEstrutura
    {
        public _11CondEstrutura()
        {
            Registro = new HashSet<Registro>();
        }

        public int Id { get; set; }
        public int Idcond { get; set; }
        public double? Bloco { get; set; }
        public double? Apt { get; set; }

        public virtual ICollection<Registro> Registro { get; set; }
        public virtual _11Condominios IdcondNavigation { get; set; }
    }
}
