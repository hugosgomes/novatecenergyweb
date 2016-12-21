﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        private string _login;
        private TESTE2TSContext _context;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext )
        {
            //melhorar essa lógica depois
            var optionsBuilder = new DbContextOptionsBuilder<TESTE2TSContext>();
            var connection = @"Server=NVTSERVER;DataBase=TESTE2TS;Uid=NVT;Pwd=1;";
            optionsBuilder.UseSqlServer(connection);

            _context = new TESTE2TSContext(optionsBuilder.Options);

            Account account = (Account)validationContext.ObjectInstance;

            var user = _context.Funcionários.Where(p => p.Login == account.Login).FirstOrDefault();

            if (user == null)
            {
                return new ValidationResult("Usuário não existe.");
            }
            return ValidationResult.Success;
        }
    }
}
