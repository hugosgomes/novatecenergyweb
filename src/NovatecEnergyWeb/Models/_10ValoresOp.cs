using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ValoresOp
    {
        public int Id { get; set; }
        public int Delegacao { get; set; }
        public int Produto { get; set; }
        public int Dx { get; set; }
        public double Valorop { get; set; }

        public virtual _00Delegação DelegacaoNavigation { get; set; }
        public virtual _00Produtos ProdutoNavigation { get; set; }
    }
}
