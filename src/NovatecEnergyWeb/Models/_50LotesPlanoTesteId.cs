using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50LotesPlanoTesteId
    {
        public _50LotesPlanoTesteId()
        {
            _50LotesPlanoTeste = new HashSet<_50LotesPlanoTeste>();
        }

        public int Id { get; set; }
        public int Obra { get; set; }
        public int? Nret { get; set; }
        public DateTime? Datasystem { get; set; }
        public string Usersystem { get; set; }

        public virtual ICollection<_50LotesPlanoTeste> _50LotesPlanoTeste { get; set; }
    }
}
