using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Validations
{
    public class AccountLoginAttribute : ValidationAttribute
    {
        private TESTE2TSContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext )
        {
            //melhorar essa lógica depois
            var optionsBuilder = new DbContextOptionsBuilder<TESTE2TSContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new TESTE2TSContext(optionsBuilder.Options);

            Account account = (Account)validationContext.ObjectInstance;

            if ( account.Tipo == "func")
            {
                var user = _context.Funcionários.Where(p => p.Login == account.Login).FirstOrDefault();

                if (user == null)
                {
                    return new ValidationResult("Não existe esse login de funcionário.");
                }
            }else
            {
                var cliente = _context.ClientesWeb.Where(c => c.Login == account.Login).FirstOrDefaultAsync();

                if (cliente == null)
                {
                    return new ValidationResult("Não existe esse login de cliente.");
                }
            }

            
            return ValidationResult.Success;
        }
    }
}
