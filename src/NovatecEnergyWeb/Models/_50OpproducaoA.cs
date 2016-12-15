using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50OpproducaoA
    {
        public int Cod { get; set; }
        public int Idop { get; set; }
        public int Funcionario { get; set; }
        public int Item { get; set; }
        public decimal? Totalitem { get; set; }

        public virtual Funcionários FuncionarioNavigation { get; set; }
        public virtual _50OpproducaoId IdopNavigation { get; set; }
    }
}
