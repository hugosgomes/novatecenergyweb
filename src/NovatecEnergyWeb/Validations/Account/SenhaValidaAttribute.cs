using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NovatecEnergyWeb.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Validations
{
    public class SenhaValidaAttribute : ValidationAttribute
    {
        private TESTE2TSContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //melhorar essa lógica depois
            var optionsBuilder = new DbContextOptionsBuilder<TESTE2TSContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new TESTE2TSContext(optionsBuilder.Options);

            Account account = (Account)validationContext.ObjectInstance;

            var user = _context.Funcionários.Where(u => u.Login == account.Login).FirstOrDefault();

            if(!Encryption.ValidateSHA1HashData(user.Senha, account.Senha))
            {
                return new ValidationResult("Senha inválida.");
            }
            return ValidationResult.Success;
        }
    }
}
