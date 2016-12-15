using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class Favorecidos
    {
        public Favorecidos()
        {
            Contas = new HashSet<Contas>();
        }

        public int Favorecido { get; set; }
        public string Nome { get; set; }
        public double Tipofavorecido { get; set; }
        public int? Estado { get; set; }
        public int? Localidade { get; set; }
        public int? Bairro { get; set; }
        public int? Tipo { get; set; }
        public int? Logradouro { get; set; }
        public string Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public string Comp { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Observações { get; set; }
        public int? Banco { get; set; }
        public string Agencia { get; set; }
        public string Dva { get; set; }
        public string Numeroconta { get; set; }
        public string Dvc { get; set; }
        public string ContaBancária { get; set; }
        public int? Tipoconta { get; set; }
        public int? Funcionarioid { get; set; }
        public int? Parceiroid { get; set; }

        public virtual ICollection<Contas> Contas { get; set; }
    }
}
