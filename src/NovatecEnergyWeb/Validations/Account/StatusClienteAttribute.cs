using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Validations.Account
{
    public class StatusClienteAttribute :ValidationAttribute
    {
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BDNVTContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new BDNVTContext(optionsBuilder.Options);

            LoginViewModel account =(LoginViewModel)  validationContext.ObjectInstance;

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
