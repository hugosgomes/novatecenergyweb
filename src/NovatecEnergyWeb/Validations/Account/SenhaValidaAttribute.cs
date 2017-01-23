using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AccountViewModels;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Validations
{
    public class SenhaValidaAttribute : ValidationAttribute
    {
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //melhorar essa lógica depois
            var optionsBuilder = new DbContextOptionsBuilder<BDNVTContext>();
            var connection = @"Server=NVTSERVER;DataBase=BDNVT;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);
            
            _context = new BDNVTContext(optionsBuilder.Options);

            LoginViewModel account = (LoginViewModel)validationContext.ObjectInstance;

            if (account.Tipo == "func")
            {
                var user = _context.Funcionários.Where(u => u.Login == account.Login).FirstOrDefault();

                if (user != null)
                {
                    if (user.Senha != account.Senha)
                    {
                        return new ValidationResult("Senha inválida");
                    }
                }
            }else
            {
                var cliente = _context.ClientesWeb.Where(c => c.Login == account.Login).FirstOrDefault();

                if (cliente != null)
                {
                    if (cliente.Senha != account.Senha)
                    {
                        return new ValidationResult("Senha inválida");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
