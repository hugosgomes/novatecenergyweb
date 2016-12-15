using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            _00Delegação = new HashSet<_00Delegação>();
            Contas = new HashSet<Contas>();
        }

        public int Cliente { get; set; }
        public string Nome { get; set; }
        public double? Fisicajuridica { get; set; }
        public string Cnpjcpf { get; set; }
        public string Razaosocial { get; set; }
        public int? Estado { get; set; }
        public int? Localidade { get; set; }
        public int? Bairro { get; set; }
        public int? Tipo { get; set; }
        public int? Logradouro { get; set; }
        public string Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public string Comp { get; set; }
        public string Cep { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Observações { get; set; }
        public string Inscricaoestadual { get; set; }
        public string Inscricaomunicipal { get; set; }
        public bool? Gnf { get; set; }

        public virtual ICollection<_00Delegação> _00Delegação { get; set; }
        public virtual ICollection<Contas> Contas { get; set; }
    }
}
