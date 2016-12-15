using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Produtos
    {
        public _40Produtos()
        {
            _40Cotacao = new HashSet<_40Cotacao>();
            _40EstoqueMinimo = new HashSet<_40EstoqueMinimo>();
            _40Local = new HashSet<_40Local>();
            _40Pedidos = new HashSet<_40Pedidos>();
            _40Saidas = new HashSet<_40Saidas>();
            _50PlanoTesteMat = new HashSet<_50PlanoTesteMat>();
        }

        public int Id { get; set; }
        public int Familia { get; set; }
        public int Unidmedida { get; set; }
        public string Produto { get; set; }
        public string Codigo { get; set; }
        public int? Patrimonio { get; set; }
        public string Descricao { get; set; }
        public string Anexo { get; set; }

        public virtual ICollection<_40Cotacao> _40Cotacao { get; set; }
        public virtual ICollection<_40EstoqueMinimo> _40EstoqueMinimo { get; set; }
        public virtual ICollection<_40Local> _40Local { get; set; }
        public virtual ICollection<_40Pedidos> _40Pedidos { get; set; }
        public virtual ICollection<_40Saidas> _40Saidas { get; set; }
        public virtual ICollection<_50PlanoTesteMat> _50PlanoTesteMat { get; set; }
        public virtual _40Familia FamiliaNavigation { get; set; }
    }
}
