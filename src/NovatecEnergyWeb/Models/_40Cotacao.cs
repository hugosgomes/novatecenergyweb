using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Cotacao
    {
        public int Codprod { get; set; }
        public int? Idcotacao { get; set; }
        public int? Produtoceg { get; set; }
        public string Descproduto { get; set; }
        public decimal? Qtde { get; set; }
        public int Unid { get; set; }
        public decimal? Valor1 { get; set; }
        public decimal? Valor2 { get; set; }
        public decimal? Valor3 { get; set; }
        public decimal? Valor4 { get; set; }

        public virtual _40CotacaoId IdcotacaoNavigation { get; set; }
        public virtual _40Produtos ProdutocegNavigation { get; set; }
        public virtual _40Unidades Un { get; set; }
    }
}
