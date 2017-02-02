using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using NovatecEnergyWeb.Models;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.AccountViewModels;

namespace NovatecEnergyWeb.Validations.Account
{
    public class SistemaWebAttribute : ValidationAttribute
    {
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BDNVTContext>();
            var connection = @"Server=NVTSERVER;DataBase=BDNVT;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new BDNVTContext(optionsBuilder.Options);

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
