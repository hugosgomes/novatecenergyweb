using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class ClientesWeb
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool? StatusLogin { get; set; }
    }
}
