using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11MotivosRej
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public string Obs { get; set; }
        public int Produto { get; set; } // sv ou sh
        public int Grupo { get; set; }
        public int Ordem { get; set; }
    }
}
