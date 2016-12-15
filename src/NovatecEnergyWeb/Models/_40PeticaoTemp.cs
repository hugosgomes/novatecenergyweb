using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40PeticaoTemp
    {
        public int Id { get; set; }
        public int Cotid { get; set; }
        public string Itemceg { get; set; }
        public decimal? Qtde { get; set; }

        public virtual _40CotacaoId Cot { get; set; }
    }
}
