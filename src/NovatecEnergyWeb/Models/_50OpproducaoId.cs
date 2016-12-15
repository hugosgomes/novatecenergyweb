using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50OpproducaoId
    {
        public _50OpproducaoId()
        {
            _50OpproducaoA = new HashSet<_50OpproducaoA>();
            _50OpproducaoB = new HashSet<_50OpproducaoB>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal? Totalprod { get; set; }
        public decimal? Totaldesc { get; set; }
        public double? Totalop { get; set; }
        public string Obs { get; set; }
        public bool? Temp { get; set; }
        public string Usercreate { get; set; }
        public string Usersave { get; set; }
        public int? Idconta { get; set; }

        public virtual ICollection<_50OpproducaoA> _50OpproducaoA { get; set; }
        public virtual ICollection<_50OpproducaoB> _50OpproducaoB { get; set; }
    }
}
