using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40InternaId
    {
        public _40InternaId()
        {
            _40Interna = new HashSet<_40Interna>();
        }

        public int Id { get; set; }
        public int Centro { get; set; }
        public int Setor { get; set; }
        public string Quementrega { get; set; }
        public int Quemrecebe { get; set; }
        public DateTime Dataentrega { get; set; }
        public DateTime? Datadevolucao { get; set; }

        public virtual ICollection<_40Interna> _40Interna { get; set; }
        public virtual _40Centros CentroNavigation { get; set; }
        public virtual _00Setores SetorNavigation { get; set; }
    }
}
