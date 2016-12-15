using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40CotacaoId
    {
        public _40CotacaoId()
        {
            _40Cotacao = new HashSet<_40Cotacao>();
            _40PeticaoTemp = new HashSet<_40PeticaoTemp>();
        }

        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Fornecedor1 { get; set; }
        public string Fornecedor2 { get; set; }
        public string Fornecedor3 { get; set; }
        public string Fornecedor4 { get; set; }
        public string Fornecedorproposto { get; set; }
        public string Orcamentofornecedor1 { get; set; }
        public string Orcamentofornecedor2 { get; set; }
        public string Orcamentofornecedor3 { get; set; }
        public string Orcamentofornecedor4 { get; set; }
        public string Formapgto1 { get; set; }
        public string Formapgto2 { get; set; }
        public string Formapgto3 { get; set; }
        public string Formapgto4 { get; set; }
        public int? Prazo1 { get; set; }
        public int? Prazo2 { get; set; }
        public int? Prazo3 { get; set; }
        public int? Prazo4 { get; set; }
        public string Obs1 { get; set; }
        public string Obs2 { get; set; }
        public string Obs3 { get; set; }
        public string Obs4 { get; set; }
        public int? Peticaoceg { get; set; }
        public int? Obra { get; set; }
        public int? Conta { get; set; }

        public virtual ICollection<_40Cotacao> _40Cotacao { get; set; }
        public virtual ICollection<_40PeticaoTemp> _40PeticaoTemp { get; set; }
    }
}
