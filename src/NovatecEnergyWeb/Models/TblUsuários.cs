using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class TblUsuários
    {
        public int IdUsuario { get; set; }
        public byte? Grupo { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? Administrador { get; set; }
        public bool? Registros { get; set; }
        public bool? Ativo { get; set; }
    }
}
