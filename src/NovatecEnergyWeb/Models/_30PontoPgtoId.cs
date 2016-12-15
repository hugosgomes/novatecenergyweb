using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30PontoPgtoId
    {
        public _30PontoPgtoId()
        {
            _30PontoPgto = new HashSet<_30PontoPgto>();
        }

        public int Id { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Empresa { get; set; }
        public int Filial { get; set; }
        public int Tipo { get; set; }
        public DateTime Data { get; set; }
        public decimal? Totalpedido { get; set; }
        public int Formapgto { get; set; }
        public DateTime? Datavto { get; set; }
        public decimal Procesada { get; set; }
        public string Useraprova { get; set; }
        public string Dataaprova { get; set; }

        public virtual ICollection<_30PontoPgto> _30PontoPgto { get; set; }
        public virtual _30Anos AnoNavigation { get; set; }
        public virtual _00Empresa EmpresaNavigation { get; set; }
        public virtual _00Filial FilialNavigation { get; set; }
        public virtual _30FormaPgtoVtvr FormapgtoNavigation { get; set; }
        public virtual _30Meses MesNavigation { get; set; }
        public virtual _30Vtvr TipoNavigation { get; set; }
    }
}
