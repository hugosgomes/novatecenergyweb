using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _60CertificacaoEquipamentosId
    {
        public _60CertificacaoEquipamentosId()
        {
            _60CertificacaoEquipamentos = new HashSet<_60CertificacaoEquipamentos>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Cert { get; set; }
        public int? Tipo { get; set; }
        public decimal? Procesada { get; set; }

        public virtual ICollection<_60CertificacaoEquipamentos> _60CertificacaoEquipamentos { get; set; }
    }
}
