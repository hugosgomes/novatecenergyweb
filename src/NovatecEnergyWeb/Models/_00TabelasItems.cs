﻿using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _00TabelasItems
    {
        public int Id { get; set; }
        public int Tabela { get; set; }
        public string Campo { get; set; }
        public int? Ordem { get; set; }
        public string Item { get; set; }

        public virtual List<_13Lotes> _13Lotes { get; set; }
        public virtual List<_12Lotes> _12Lotes { get; set; }
        public virtual List<_11Lotes> _11Lotes { get; set; }
    }
}
