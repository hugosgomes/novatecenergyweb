using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using Microsoft.AspNetCore.Http;

namespace NovatecEnergyWeb.Controllers
{
    public class AccountController : Controller
    {
        private TESTE2TSContext _context;

        public AccountController(TESTE2TSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.Account = new Account();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Senha, Login")] Account account)
        {
            if (ModelState.IsValid)
            {
                var funcionarioStored =_context.Funcionários.Where( p => p.Login == account.Login);

                IList<Funcionários> user = funcionarioStored.ToList();
                
                if ((user.Count == 1 ) && (Encryption.ValidateSHA1HashData(user[0].Senha,account.Senha)))
                {
                    HttpContext.Session.SetInt32("FuncionarioId", user[0].Id);
                    HttpContext.Session.SetString("Login", user[0].Login);

                    return RedirectToAction("Index", "Home");
                }else
                {
                    //criar logica
                    return RedirectToAction("Index", "Home");
                }  
            }
            else
            {
                ViewBag.Account = account;
                return View();
            }
  
        }


    }
}
