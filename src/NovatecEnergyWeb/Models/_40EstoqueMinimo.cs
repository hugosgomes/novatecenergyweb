using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40EstoqueMinimo
    {
        public int Id { get; set; }
        public int Centro { get; set; }
        public int Produto { get; set; }
        public decimal Qtde { get; set; }

        public virtual _40Centros CentroNavigation { get; set; }
        public virtual _40Produtos ProdutoNavigation { get; set; }
    }
}
