using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class PijamaGasNaturalPyme
    {
        public int IdPyme { get; set; }
        public int IdLote { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Produto { get; set; }
        public string PymeStatus { get; set; }
        public string UltimoMotivo { get; set; }
        public string AgenteUltimo { get; set; }
        public string DataUltima { get; set; }
        public string HoraUltima { get; set; }
        public string NomeTelefone { get; set; }
        public string Parentesco { get; set; }

    }
}
