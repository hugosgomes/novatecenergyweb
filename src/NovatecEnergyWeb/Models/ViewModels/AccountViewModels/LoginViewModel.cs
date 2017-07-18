using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Validations;
using NovatecEnergyWeb.Validations.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace NovatecEnergyWeb.Models.ViewModels.AccountViewModels
{ 
    public class LoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        [AccountLogin]
        [StatusCliente]
        [SistemaWeb]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        [SenhaValida]
        public string Senha { get; set; }


        public string Tipo { get; set; }
        
      
    }
}
