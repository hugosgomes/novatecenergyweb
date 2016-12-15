using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _40Centros
    {
        public _40Centros()
        {
            _40EstoqueMinimo = new HashSet<_40EstoqueMinimo>();
            _40InternaId = new HashSet<_40InternaId>();
            _40Localização = new HashSet<_40Localização>();
        }

        public int Id { get; set; }
        public string Centro { get; set; }
        public string Descrição { get; set; }

        public virtual ICollection<_40EstoqueMinimo> _40EstoqueMinimo { get; set; }
        public virtual ICollection<_40InternaId> _40InternaId { get; set; }
        public virtual ICollection<_40Localização> _40Localização { get; set; }
    }
}
