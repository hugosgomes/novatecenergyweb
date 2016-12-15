using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Local
    {
        public int Id { get; set; }
        public int Localização { get; set; }
        public int Produto { get; set; }

        public virtual _40Localização LocalizaçãoNavigation { get; set; }
        public virtual _40Produtos ProdutoNavigation { get; set; }
    }
}
