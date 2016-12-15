using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10Certificados
    {
        public int Cod { get; set; }
        public int? Id { get; set; }
        public int? Cliente { get; set; }

        public virtual Registro ClienteNavigation { get; set; }
        public virtual _10CertificadosId IdNavigation { get; set; }
    }
}
