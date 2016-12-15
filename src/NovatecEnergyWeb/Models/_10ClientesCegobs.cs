using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ClientesCegobs
    {
        public _10ClientesCegobs()
        {
            _10CargasAgendadasSub = new HashSet<_10CargasAgendadasSub>();
            _10Osmateriais = new HashSet<_10Osmateriais>();
            _10OsServiços = new HashSet<_10OsServiços>();
        }

        public int Id { get; set; }
        public string Protocolo { get; set; }
        public int Cliente { get; set; }
        public string Userabertura { get; set; }
        public DateTime? Dataabertura { get; set; }
        public int Responsável { get; set; }
        public int Tema { get; set; }
        public string Detalheobs { get; set; }
        public DateTime Dataagendada { get; set; }
        public string Turno { get; set; }
        public int Conclusao { get; set; }
        public string Userconclusão { get; set; }
        public DateTime? Dataconclusão { get; set; }
        public int? Detalhenegativo { get; set; }
        public string Userlastedit { get; set; }
        public DateTime? Datalastedit { get; set; }
        public string Numos { get; set; }
        public DateTime? Dataservico { get; set; }
        public string Encarregado { get; set; }
        public string Instalador { get; set; }
        public string Instalador02 { get; set; }
        public int? Empresa { get; set; }

        public virtual ICollection<_10CargasAgendadasSub> _10CargasAgendadasSub { get; set; }
        public virtual ICollection<_10Osmateriais> _10Osmateriais { get; set; }
        public virtual ICollection<_10OsServiços> _10OsServiços { get; set; }
        public virtual Registro ClienteNavigation { get; set; }
        public virtual _10ClientesCegdetalhesN DetalhenegativoNavigation { get; set; }
        public virtual _10ClientesCegtemas TemaNavigation { get; set; }
    }
}
