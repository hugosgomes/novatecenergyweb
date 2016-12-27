using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Validations.TrocaSenha
{
    public class SenhaAtualInvalidaAttribute : ValidationAttribute
    {
        private TESTE2TSContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TESTE2TSContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new TESTE2TSContext(optionsBuilder.Options);

            TrocaSenhaViewModel trocaSenha = (TrocaSenhaViewModel)validationContext.ObjectInstance;

            if (trocaSenha.Tipo == "func")
            {
                var func = _context.Funcionários.Find(trocaSenha.Id);

                if (func != null)
                {
                    if(func.Senha != trocaSenha.SenhaAtual)
                    {
                        return new ValidationResult("Senha atual inválida");
                    }
                }

            }else
            {
                var cli = _context.ClientesWeb.Find(trocaSenha.Id);

                if (cli != null)
                {
                    if (!Encryption.ValidateSHA1HashData(trocaSenha.SenhaAtual, cli.Senha))
                    {
                        return new ValidationResult("Senha atual inválida");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
