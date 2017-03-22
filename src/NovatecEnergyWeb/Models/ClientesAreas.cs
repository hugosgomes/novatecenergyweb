using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class ClientesAreas
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdArea { get; set; }

        public virtual ClientesWeb ClienteObj { get; set; }
        public virtual _00Areas AreaObj { get; set; }
    }
}
