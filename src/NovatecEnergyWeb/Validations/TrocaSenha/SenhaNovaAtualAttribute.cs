using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.AccountViewModels;

namespace NovatecEnergyWeb.Validations.TrocaSenha
{
    public class SenhaNovaAtualAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TrocaSenhaViewModel trocaSenha = (TrocaSenhaViewModel)validationContext.ObjectInstance;

            if (trocaSenha.SenhaAtual == trocaSenha.NovaSenha)
            {
                return new ValidationResult("A senha nova é igual a atual");
            }

            return ValidationResult.Success;
        }
    }
}
