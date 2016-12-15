using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _20EntidadesBancarias
    {
        public _20EntidadesBancarias()
        {
            Contas = new HashSet<Contas>();
            Funcionários = new HashSet<Funcionários>();
        }

        public int Conta { get; set; }
        public string Cod { get; set; }
        public string Nome { get; set; }
        public string Banco { get; set; }
        public int? Tipocontae { get; set; }
        public int? Tipocontas { get; set; }
        public bool? Uso { get; set; }

        public virtual ICollection<Contas> Contas { get; set; }
        public virtual ICollection<Funcionários> Funcionários { get; set; }
    }
}
