using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50PrecertId
    {
        public _50PrecertId()
        {
            _50Precert = new HashSet<_50Precert>();
        }

        public int Id { get; set; }
        public int Nsequencial { get; set; }
        public int? Nseq2 { get; set; }
        public string Ncertificacao { get; set; }
        public int? Delegacao { get; set; }
        public int? Centrocontabil { get; set; }
        public int? TipoDeContrato { get; set; }
        public int Codprojeto { get; set; }
        public string Ncroquis { get; set; }
        public DateTime Emissao { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? Acrescimonum { get; set; }
        public decimal? Atualantecipo { get; set; }
        public decimal? Totalantecipo { get; set; }
        public decimal? Atual { get; set; }
        public decimal? Total { get; set; }
        public string Anexo { get; set; }
        public int Tipo { get; set; }
        public int? Nf { get; set; }
        public decimal? TotalAlb { get; set; }
        public decimal? Temp { get; set; }

        public virtual ICollection<_50Precert> _50Precert { get; set; }
        public virtual _50CroquiCentroContabil CentrocontabilNavigation { get; set; }
        public virtual _00Delegação DelegacaoNavigation { get; set; }
        public virtual _50PrecertTipo TipoNavigation { get; set; }
    }
}
