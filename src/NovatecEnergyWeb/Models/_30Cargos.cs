using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _30Cargos
    {
        public _30Cargos()
        {
            Funcionários = new HashSet<Funcionários>();
        }

        public int Id { get; set; }
        public int? Setor { get; set; }
        public string TituloFunção { get; set; }
        public int? Titulob { get; set; }
        public string Tituloigape { get; set; }
        public string Tituloceg { get; set; }
        public string Agenteexterno { get; set; }
        public int Empresa { get; set; }
        public int Filial { get; set; }
        public decimal Salário { get; set; }
        public string Bota { get; set; }
        public string Calça { get; set; }
        public string Blusa { get; set; }
        public string Aso { get; set; }
        public string Glicemia { get; set; }
        public string HemogramaCompleto { get; set; }
        public string RaiosXTóraxApPerfil { get; set; }
        public string Eeg { get; set; }
        public string Ecg { get; set; }
        public string GamaGt { get; set; }

        public virtual ICollection<Funcionários> Funcionários { get; set; }
        public virtual _00Empresa EmpresaNavigation { get; set; }
        public virtual _00Filial FilialNavigation { get; set; }
        public virtual _00Setores SetorNavigation { get; set; }
        public virtual _30CargosB TitulobNavigation { get; set; }
    }
}
