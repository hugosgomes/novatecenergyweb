using NovatecEnergyWeb.Validations.ClientesWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class ClientesWeb
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Digite o login")]
        [LoginRepetido]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do cliente")]
        public string Senha { get; set; }

        [Display(Name = "Digite a senha de confirmação")]
        public string ConfirmaSenha { get; set; }

        public bool? StatusLogin { get; set; }
    }
}
