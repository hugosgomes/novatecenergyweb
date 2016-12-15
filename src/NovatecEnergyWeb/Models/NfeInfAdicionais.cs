using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class NfeInfAdicionais
    {
        public int CodigoIntInfAdicionais { get; set; }
        public string BnfeNNf { get; set; }
        public int? CodigoIntInfNotaFiscal { get; set; }
        public string AdInfAdFisco { get; set; }
        public string AdInfCpl { get; set; }
        public string AdXCampoContr { get; set; }
        public string AdXTextoContr { get; set; }
        public string AdXCampoFisco { get; set; }
        public string AdXTextoFisco { get; set; }
        public string AdNProc { get; set; }
        public string AdIndProc { get; set; }
        public string AdCfop { get; set; }
        public string AdIpi { get; set; }
        public string AdIcms { get; set; }
    }
}
