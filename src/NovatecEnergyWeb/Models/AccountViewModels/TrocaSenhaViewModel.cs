using NovatecEnergyWeb.Validations.TrocaSenha;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.AccountViewModels
{
    public class TrocaSenhaViewModel
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Tipo { get; set; }

        [Required(ErrorMessage = "Digite a senha atual")]
        [SenhaAtualInvalida]
        public string SenhaAtual { get; set; }

        [StringLength(20, MinimumLength = 4, ErrorMessage = "Nova senha deve ter entre 4 a 20 caracteres")]
        [Required(ErrorMessage = "Digite a nova senha")]
        [SenhaNovaAtual]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Digite a senha de confirmação")]
        [Compare("NovaSenha", ErrorMessage = "As senhas não coincidem")]
        public string ConfirmaSenha { get; set; }
    }
}
