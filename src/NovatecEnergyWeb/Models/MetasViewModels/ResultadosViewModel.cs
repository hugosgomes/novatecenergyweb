using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.MetasViewModels
{
    public class ResultadosViewModel
    {
        public int Id { get; set; }

        public string Zona { get; set; }

        public List<int> Meses { get; set; }

        public int  Trim1 { get; set; }

        public int  Trim2 { get; set; }

        public int  Trim3 { get; set; }

        public int  Trim4 { get; set; }

        public int Anual { get; set; }


    }
}
