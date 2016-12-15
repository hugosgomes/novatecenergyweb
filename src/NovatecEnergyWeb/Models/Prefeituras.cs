using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Prefeituras
    {
        public int Idpm { get; set; }
        public int? CdIbge { get; set; }
        public string Municipio { get; set; }
        public string NfInfo { get; set; }
        public string NfOutInf { get; set; }
        public string Logopm { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
