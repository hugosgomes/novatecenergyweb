using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class NfeInfCancelamento
    {
        public int CodigoIntInfCancelamento { get; set; }
        public int CodigoIntInfNotaFiscal { get; set; }
        public string AnfeNroProtocoloCancelamento { get; set; }
        public string AnfeDataHora { get; set; }
        public string AnfeJustificativa { get; set; }
    }
}
