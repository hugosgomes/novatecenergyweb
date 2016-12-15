using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10PrecertId
    {
        public _10PrecertId()
        {
            _10Precert = new HashSet<_10Precert>();
        }

        public int Npre { get; set; }
        public string Ncertificacao { get; set; }
        public int Delegacao { get; set; }
        public int Tipocontrato { get; set; }
        public int? Municipio { get; set; }
        public DateTime? Emissao { get; set; }
        public string Anexo { get; set; }
        public string Usersistema { get; set; }
        public bool Validada { get; set; }
        public int? Nf { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAlb { get; set; }
        public int? Temp { get; set; }

        public virtual ICollection<_10Precert> _10Precert { get; set; }
    }
}
