using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40PedidosId
    {
        public _40PedidosId()
        {
            _40Pedidos = new HashSet<_40Pedidos>();
        }

        public int Id { get; set; }
        public int Centro { get; set; }
        public int Setor { get; set; }
        public double Transfer { get; set; }
        public DateTime? Datapedido { get; set; }
        public int? Solicitante { get; set; }
        public int? Obra { get; set; }
        public bool? Aprovado { get; set; }
        public string Autorizacao { get; set; }
        public bool? Reprovado { get; set; }
        public DateTime? Dataaprovado { get; set; }
        public int? Fornecedor { get; set; }
        public string Fornecedorescolhido { get; set; }
        public DateTime? Dataentrada { get; set; }
        public DateTime? Datasolicitacao { get; set; }
        public int Cotação { get; set; }
        public string Observacao { get; set; }
        public string Usuariosistema { get; set; }
        public DateTime? Datasistema { get; set; }

        public virtual ICollection<_40Pedidos> _40Pedidos { get; set; }
    }
}
