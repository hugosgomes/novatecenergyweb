using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class _10_MetasCargas
    {
        public Int64 Id { get; set; }

        public int Ano { get; set; }

        public int Mes { get; set; }

        public string Zona { get; set; }

        public Double Meta { get; set; }

        public Double Res { get; set; }

        public int Cargas { get; set; }

        public int ZonaId { get; set; }
    }
}
