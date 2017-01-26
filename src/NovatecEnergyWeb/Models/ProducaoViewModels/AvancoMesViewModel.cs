using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.ProducaoViewModels
{
    public class AvancoMesViewModel
    {
        public Int64 Id { get; set; }

        public string Z { get; set; }

        public string D { get; set; }

        public string Obra { get; set; }

        public string Natureza { get; set; }

        public Double DM { get; set; }

        public List<string>Meses { get; set; }

        public int Total { get; set; }
    }
}
