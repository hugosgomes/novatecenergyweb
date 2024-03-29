﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public abstract class Lote
    {
        public int Id { get; set; }
        public string Ge { get; set; }
        public string LoteNum { get; set; }
        public DateTime? DataLote { get; set; }
        public DateTime? DataEntrega { get; set; }
        public int? Potencial { get; set; }
        public int? Meta { get; set; }
        public string UserSystem { get; set; }
        public DateTime? DataSystem { get; set; }
        public int Status { get; set; }
        public int Area { get; set; }

        public virtual _00TabelasItems StatusObj { get; set; }
        public virtual _00Areas AreaObj { get; set; }
    }
}
