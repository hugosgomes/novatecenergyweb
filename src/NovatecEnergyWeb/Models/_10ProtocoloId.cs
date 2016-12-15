using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _10ProtocoloId
    {
        public _10ProtocoloId()
        {
            _10ProtocoloTemp = new HashSet<_10ProtocoloTemp>();
        }

        public int Id { get; set; }
        public int Delegacao { get; set; }
        public int Tipo { get; set; }
        public DateTime Data { get; set; }
        public string Observacoes { get; set; }
        public string Usersistema { get; set; }
        public int Status { get; set; }
        public string Anexo { get; set; }

        public virtual ICollection<_10ProtocoloTemp> _10ProtocoloTemp { get; set; }
    }
}
