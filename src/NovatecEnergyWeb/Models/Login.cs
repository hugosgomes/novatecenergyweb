using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public int? Funcionário { get; set; }
        public bool? Statussistema { get; set; }
        public string Ultimobanco { get; set; }
    }
}
