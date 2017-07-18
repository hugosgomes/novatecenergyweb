using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.ViewModels.AccountViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;

namespace NovatecEnergyWeb.Validations.TrocaSenha
{
    public class SenhaAtualInvalidaAttribute : ValidationAttribute
    {
        private BDNVTContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            _context = AppSettings.contexto;

            TrocaSenhaViewModel trocaSenha = (TrocaSenhaViewModel)validationContext.ObjectInstance;

            if (trocaSenha.Tipo == "func")
            {
                var func = _context.Funcionários.Find(trocaSenha.Id);
                        
                if ( (func != null) && (trocaSenha.SenhaAtual !=null)) // foi colocado esse AND porque essa critica de SenhaAtualInvalida está diparando primeiro( mesmo caso no cliente)
                {
                    if(!Encryption.ValidateSHA1HashData(trocaSenha.SenhaAtual, func.Senha))
                    {
                        return new ValidationResult("Senha atual inválida");
                    }
                }

            }else
            {
                var cli = _context.ClientesWeb.Find(trocaSenha.Id);
                                    
                if ( (cli != null) && (trocaSenha.SenhaAtual != null) )
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
