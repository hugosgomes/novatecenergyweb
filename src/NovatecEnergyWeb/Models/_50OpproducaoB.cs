using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50OpproducaoB
    {
        public int Cod { get; set; }
        public int Idop { get; set; }
        public int Funcionario { get; set; }
        public string Motivodesconto { get; set; }
        public decimal Totaldesconto { get; set; }

        public virtual Funcionários FuncionarioNavigation { get; set; }
        public virtual _50OpproducaoId IdopNavigation { get; set; }
    }
}
