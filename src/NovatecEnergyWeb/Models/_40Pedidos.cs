using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Pedidos
    {
        public int Cod { get; set; }
        public int Pedido { get; set; }
        public int Produto { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? Valorprod { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual _40PedidosId PedidoNavigation { get; set; }
        public virtual _40Produtos ProdutoNavigation { get; set; }
    }
}
