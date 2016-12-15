using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Parceiros
    {
        public _40Parceiros()
        {
            _50OpempreiteirasId = new HashSet<_50OpempreiteirasId>();
            _50ProjetoDesenvolvimento = new HashSet<_50ProjetoDesenvolvimento>();
        }

        public int Id { get; set; }
        public string Parceiro { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Endereço { get; set; }
        public string Num { get; set; }
        public string Bloco { get; set; }
        public string Apt { get; set; }
        public string Comp { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string Observações { get; set; }

        public virtual ICollection<_50OpempreiteirasId> _50OpempreiteirasId { get; set; }
        public virtual ICollection<_50ProjetoDesenvolvimento> _50ProjetoDesenvolvimento { get; set; }
    }
}
