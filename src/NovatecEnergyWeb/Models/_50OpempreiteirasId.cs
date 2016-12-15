using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50OpempreiteirasId
    {
        public _50OpempreiteirasId()
        {
            _50OpempreiteirasSub01 = new HashSet<_50OpempreiteirasSub01>();
            _50OpempreiteirasSub02 = new HashSet<_50OpempreiteirasSub02>();
        }

        public int Id { get; set; }
        public int Empresa { get; set; }
        public int Obra { get; set; }
        public DateTime Data { get; set; }
        public decimal Desconto { get; set; }
        public string Obs { get; set; }
        public int? Idconta { get; set; }
        public decimal Totalprod { get; set; }
        public decimal Totalmat { get; set; }
        public decimal? Totalcert { get; set; }
        public bool Temp { get; set; }
        public string Anexo { get; set; }
        public string Usersystem { get; set; }

        public virtual ICollection<_50OpempreiteirasSub01> _50OpempreiteirasSub01 { get; set; }
        public virtual ICollection<_50OpempreiteirasSub02> _50OpempreiteirasSub02 { get; set; }
        public virtual _40Parceiros EmpresaNavigation { get; set; }
    }
}
