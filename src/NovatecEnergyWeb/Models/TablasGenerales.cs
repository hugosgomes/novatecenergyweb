using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class TablasGenerales
    {
        public int Id { get; set; }
        public string NombreTabla { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
    }
}
