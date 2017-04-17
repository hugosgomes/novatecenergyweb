using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.AdesaoViewModels
{
    public class FormFiltersAgendaVisitaEnderecosViewModel
    {
        public string Ano { get; set; }
        public string Mes { get; set; }
        public enum meses
        {
            Janeiro = 1,
            Fevereiro = 2,
            Março = 3,
            Abril = 4,
            Maio = 5,
            Junho = 6,
            Julho = 7,
            Agosto = 8,
            Setembro = 9,
            Outubro = 10,
            Novembro = 11, 
            Dezembro = 12
        }
    }
}
