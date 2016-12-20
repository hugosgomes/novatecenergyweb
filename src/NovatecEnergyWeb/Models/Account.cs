using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Senha { get; set; }
    }
}
