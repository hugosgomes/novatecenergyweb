using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30SodexoParametros
    {
        public int Id { get; set; }
        public int? Empresa { get; set; }
        public int? Filial { get; set; }
        public int? Matricula { get; set; }
        public string Depnum { get; set; }
        public string Depnome { get; set; }
        public string Depresp { get; set; }

        public virtual _00Empresa EmpresaNavigation { get; set; }
        public virtual _00Filial FilialNavigation { get; set; }
    }
}
