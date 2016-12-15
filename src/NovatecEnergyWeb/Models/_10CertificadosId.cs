using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10CertificadosId
    {
        public _10CertificadosId()
        {
            _10Certificados = new HashSet<_10Certificados>();
        }

        public int Id { get; set; }
        public int Delegacao { get; set; }
        public string Usersystem { get; set; }
        public DateTime? Datasystem { get; set; }
        public string Anexo { get; set; }

        public virtual ICollection<_10Certificados> _10Certificados { get; set; }
    }
}
