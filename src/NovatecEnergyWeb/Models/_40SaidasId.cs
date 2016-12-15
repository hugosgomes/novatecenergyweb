using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40SaidasId
    {
        public _40SaidasId()
        {
            _40Saidas = new HashSet<_40Saidas>();
            _50OpempreiteirasSub02 = new HashSet<_50OpempreiteirasSub02>();
        }

        public int Saida { get; set; }
        public int Centro { get; set; }
        public int Clase { get; set; }
        public int Setor { get; set; }
        public double Transfer { get; set; }
        public int? Obra { get; set; }
        public DateTime? Datasaida { get; set; }
        public int Cliente { get; set; }
        public decimal? Desconto { get; set; }
        public string Observacoes { get; set; }
        public string Usuario { get; set; }
        public string Usuariosistema { get; set; }
        public DateTime? Datasistema { get; set; }
        public int? Pgtoemp { get; set; }
        public decimal? Totalsaida { get; set; }

        public virtual _10ProdPgtoSub02 _10ProdPgtoSub02 { get; set; }
        public virtual ICollection<_40Saidas> _40Saidas { get; set; }
        public virtual ICollection<_50OpempreiteirasSub02> _50OpempreiteirasSub02 { get; set; }
    }
}
