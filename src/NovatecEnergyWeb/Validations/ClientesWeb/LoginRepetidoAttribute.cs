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
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BDNVTContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTETS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new BDNVTContext(optionsBuilder.Options);

            Models.ClientesWeb clientesWeb = (Models.ClientesWeb)validationContext.ObjectInstance;

            //var cliente = _context.ClientesWeb.Where(c => c.Login == clientesWeb.Login).FirstOrDefault();

            var cliente = _context.ClientesWeb
                .Where(c => c.Login == clientesWeb.Login)
                .Select(c => new { c.Id, c.NomeCompleto, c.Login, c.Senha, c.StatusLogin, c.Email })
                .FirstOrDefault();

            if (cliente != null)
            {
                return new ValidationResult("Já existe esse login");
            }

            var funcionario = _context.Funcionários
                .Where(f => f.Login == clientesWeb.Login)
                .FirstOrDefault();

            if (funcionario != null)
            {
                return new ValidationResult("Já existe esse login");
            }

            return ValidationResult.Success;
        }
    }
}
