using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10CampanhaId
    {
        public _10CampanhaId()
        {
            _10Campanha = new HashSet<_10Campanha>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Descriçao { get; set; }
        public string Ativa { get; set; }

        public virtual ICollection<_10Campanha> _10Campanha { get; set; }
    }
}
