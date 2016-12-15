using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Tecnicos
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Codigo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
