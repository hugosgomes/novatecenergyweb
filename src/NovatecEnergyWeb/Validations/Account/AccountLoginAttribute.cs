using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;

namespace NovatecEnergyWeb.Validations
{
    public class AccountLoginAttribute : ValidationAttribute
    {
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext )
        {
            _context = AppSettings.contexto;

            LoginViewModel account = (LoginViewModel)validationContext.ObjectInstance;

            if ( account.Tipo == "func")
            {
                var user = _context.Funcionários.Where(p => p.Login == account.Login).FirstOrDefault();

                if (user == null)
                {
                    return new ValidationResult("Não existe esse login de funcionário.");
                }
            }else
            {
                var cliente = _context.ClientesWeb.Where(c => c.Login == account.Login).FirstOrDefault();

                if (cliente == null)
                {
                    return new ValidationResult("Não existe esse login de cliente.");
                }
            }

            
            return ValidationResult.Success;
        }
    }
}
