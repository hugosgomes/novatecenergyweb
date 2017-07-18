using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.ViewModels.MetasViewModels
{
    public class ResultadosViewModel
    {
        public int Id { get; set; }

        public string Zona { get; set; }

        public List<string> Meses { get; set; }

        public int  Trim1 { get; set; }

        public int  Trim2 { get; set; }

        public int  Trim3 { get; set; }

        public int  Trim4 { get; set; }

        public int Anual { get; set; }

        public void AcrescentaMesesQueFaltam()
        {
            //acrescenta os meses que faltam com zero
            if (this.Meses.Count < 12)
            {
                var quantidadeAtual = 12 - this.Meses.Count;
                for (int i = 0; i < quantidadeAtual; i++)
                {
                    this.Meses.Add("");
                }
            }
           
        }
    }
}
