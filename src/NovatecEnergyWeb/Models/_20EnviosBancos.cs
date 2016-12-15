using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _20EnviosBancos
    {
        public int Cod { get; set; }
        public int Idenvio { get; set; }
        public int? Conta { get; set; }
        public int? Salario { get; set; }
        public decimal? Dvalorpgto { get; set; }
        public DateTime? Ddatapgto { get; set; }
        public string Hocorrencias { get; set; }
        public string Docorrencias { get; set; }
        public string Tocorrencias { get; set; }
        public string Hlote { get; set; }
        public string Hregistro { get; set; }
        public string Dinfo { get; set; }
        public string Tqtdereg { get; set; }
        public decimal? Tvalorpgtos { get; set; }
        public bool? Baixado { get; set; }

        public virtual _20EnviosBancosId IdenvioNavigation { get; set; }
    }
}
