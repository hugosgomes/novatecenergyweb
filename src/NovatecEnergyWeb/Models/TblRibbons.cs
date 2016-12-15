using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class TblRibbons
    {
        public int Id { get; set; }
        public string RibbonName { get; set; }
        public string RibbonXml { get; set; }
        public int? Versao { get; set; }
    }
}
