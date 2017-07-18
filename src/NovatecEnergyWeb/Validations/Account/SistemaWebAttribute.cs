using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using NovatecEnergyWeb.Models;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.ViewModels.AccountViewModels;
using NovatecEnergyWeb.Core;

namespace NovatecEnergyWeb.Validations.Account
{
    public class SistemaWebAttribute : ValidationAttribute
    {
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            _context = AppSettings.contexto;

            LoginViewModel account = (LoginViewModel)validationContext.ObjectInstance;

            if (account.Tipo == "func")
            {
                var funcionario = _context.Funcionários.Where(c => c.Login == account.Login).FirstOrDefault();

                if (funcionario != null)
                {
                    if (funcionario.SistemaWeb == 0)
                    {
                        return new ValidationResult("Esse usuário não tem autorização para fazer login");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
