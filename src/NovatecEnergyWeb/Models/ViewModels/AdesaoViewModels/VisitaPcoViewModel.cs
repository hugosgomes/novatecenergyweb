using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels
{
    public class VisitaPcoViewModel
    {
        //usados no post para o servido(filtros)
        public int ZId { get; set; }
        public int DId { get; set; }
        public int AId { get; set; }
        public int IdLote { get; set; }
        public int Interesse { get; set; }
        public int AgComercialId { get; set; }
        public string Diavisita1 { get; set; }
        public string Diavisita2 { get; set; }
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int NegativaId { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Logradouro { get; set; }
        public string AgVisita { get; set; }
        public string Pco { get; set; }
    }
}
