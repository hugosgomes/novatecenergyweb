﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class _11_LoteAtivoB
    {
        public Int64 Id { get; set; }
        public string Lote { get; set; }
        public string Ar { get; set; }
        public string Localidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string Pt { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string UltMotivo { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string Agult { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string Dtult { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string Hrult { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string NomeTlf { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string Parentesco { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false, NullDisplayText = "")]
        public string CasaStatus2 { get; set; }

        public int? IdLote { get; set; }
    }
}
