using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30SalariosId
    {
        public _30SalariosId()
        {
            _30Salarios = new HashSet<_30Salarios>();
            _30SalariosTemp = new HashSet<_30SalariosTemp>();
        }

        public int Id { get; set; }
        public int Empresa { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public DateTime Datadoc { get; set; }
        public DateTime Datapgto { get; set; }
        public int Tipopgto { get; set; }
        public decimal? Folha { get; set; }
        public int Tipo { get; set; }
        public string Observacoes { get; set; }
        public string Usersystem { get; set; }
        public DateTime? Datasystem { get; set; }
        public decimal Procesada { get; set; }

        public virtual ICollection<_30Salarios> _30Salarios { get; set; }
        public virtual ICollection<_30SalariosTemp> _30SalariosTemp { get; set; }
        public virtual _30Anos AnoNavigation { get; set; }
        public virtual _30Meses MesNavigation { get; set; }
        public virtual _30FolhaTipos TipoNavigation { get; set; }
    }
}
