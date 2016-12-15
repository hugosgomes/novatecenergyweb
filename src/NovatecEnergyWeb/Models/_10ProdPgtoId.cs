using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ProdPgtoId
    {
        public _10ProdPgtoId()
        {
            _10ProdPgtoSub01 = new HashSet<_10ProdPgtoSub01>();
            _10ProdPgtoSub02 = new HashSet<_10ProdPgtoSub02>();
        }

        public int Id { get; set; }
        public DateTime DataCert { get; set; }
        public int Empresa { get; set; }
        public decimal Desconto { get; set; }
        public decimal Totalprod { get; set; }
        public decimal Totalmat { get; set; }
        public decimal? Totalcert { get; set; }
        public string Observações { get; set; }
        public bool Temp { get; set; }
        public int? Idconta { get; set; }
        public string Anexo { get; set; }
        public string Usersystem { get; set; }

        public virtual ICollection<_10ProdPgtoSub01> _10ProdPgtoSub01 { get; set; }
        public virtual ICollection<_10ProdPgtoSub02> _10ProdPgtoSub02 { get; set; }
    }
}
