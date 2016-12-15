using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50DiasTrabalho
    {
        public _50DiasTrabalho()
        {
            _50DiasTrabalhoObras = new HashSet<_50DiasTrabalhoObras>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }

        public virtual ICollection<_50DiasTrabalhoObras> _50DiasTrabalhoObras { get; set; }
    }
}
