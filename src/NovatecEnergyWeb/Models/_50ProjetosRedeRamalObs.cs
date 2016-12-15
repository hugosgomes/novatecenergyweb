using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50ProjetosRedeRamalObs
    {
        public int Id { get; set; }
        public string Protocolo { get; set; }
        public int Projeto { get; set; }
        public string Userabertura { get; set; }
        public DateTime? Dataabertura { get; set; }
        public int Tema { get; set; }
        public string Detalheobs { get; set; }
        public DateTime Dataagendada { get; set; }
        public int Conclusão { get; set; }
        public string Userconclusão { get; set; }
        public DateTime? Dataconclusão { get; set; }
        public int? Detalhenegativo { get; set; }
        public string Userlastedit { get; set; }
        public DateTime? Datalastedit { get; set; }

        public virtual _50ProjetosRedeRamalDetalheN DetalhenegativoNavigation { get; set; }
        public virtual _50ProjetosRedeRamalTema TemaNavigation { get; set; }
    }
}
