using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _20Agencias
    {
        public _20Agencias()
        {
            Contas = new HashSet<Contas>();
        }

        public int Id { get; set; }
        public int Empresa { get; set; }
        public int? Entidade { get; set; }
        public string Nome { get; set; }
        public string Nconvenio { get; set; }
        public int? Agencia { get; set; }
        public string Dva { get; set; }
        public int? Numeroconta { get; set; }
        public string Dvc { get; set; }

        public virtual ICollection<Contas> Contas { get; set; }
    }
}
