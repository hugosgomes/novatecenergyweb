using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Validations.Account
{
    public class StatusClienteAttribute :ValidationAttribute
    {
        private TESTE2TSContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TESTE2TSContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new TESTE2TSContext(optionsBuilder.Options);

            Models.Account account =(Models.Account)  validationContext.ObjectInstance;

            if (account.Tipo == "cli")
            {
                var cliente = _context.ClientesWeb.Where(c => c.Login == account.Login).FirstOrDefault();

                if (cliente != null)
                {
                    if (cliente.StatusLogin == false)
                    {
                        return new ValidationResult("Esse usuário não tem autorização para fazer login");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
