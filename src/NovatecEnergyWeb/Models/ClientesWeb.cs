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

        [StringLength(20,MinimumLength =4,ErrorMessage ="Senha deve ter entre 4 a 20 caracteres")]
        [Required(ErrorMessage = "Digite a senha do cliente")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite a senha de confirmação")]
        [Compare("Senha",ErrorMessage ="As senhas não coincidem")]
        public string ConfirmaSenha { get; set; }

        public bool? StatusLogin { get; set; }
    }
}
