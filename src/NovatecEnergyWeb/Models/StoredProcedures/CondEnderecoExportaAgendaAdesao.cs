﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class CondEnderecoExportaAgendaAdesao
    {
        public Int64 Id { get; set; }
        public int IdLote { get;set; }
        public string Endereco { get; set; }
        public DateTime Datah { get; set; }
        public int Entrevistas { get; set; }
        public int EntrevistasD2 { get; set; }
        public string EnderecoB { get; set; }

    }
}
