using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Validations.ClientesWeb
{
    public class LoginRepetidoAttribute : ValidationAttribute
    {
        private TESTE2TSContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TESTE2TSContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new TESTE2TSContext(optionsBuilder.Options);

            Models.ClientesWeb clientesWeb = (Models.ClientesWeb)validationContext.ObjectInstance;

            //var cliente = _context.ClientesWeb.Where(c => c.Login == clientesWeb.Login).FirstOrDefault();

            var cliente = _context.ClientesWeb
                .Where(c => c.Login == clientesWeb.Login)
                .Select(c => new { c.Id, c.NomeCompleto, c.Login, c.Senha, c.StatusLogin })
                .FirstOrDefault();

            if (cliente != null)
            {
                return new ValidationResult("Já existe cliente com esse login");
            }

            return ValidationResult.Success;
        }
    }
}
