using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AccountViewModels;
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
            ViewBag.Account = new LoginViewModel();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Senha, Login,Tipo")] LoginViewModel account)
        {
            if (ModelState.IsValid)
            {

                if (account.Tipo == "func")
                {
                    var funcionarioStored = _context.Funcionários.Where(p => p.Login == account.Login);
                    IList<Funcionários> user = funcionarioStored.ToList();

                    if ((user.Count == 1))
                    {
                        HttpContext.Session.SetInt32("UserId", user[0].Id);
                        HttpContext.Session.SetString("Login", user[0].Login);
                    }
                }
                else
                {
                    var clientesWeb = _context.ClientesWeb.Where(c => c.Login == account.Login);
                    IList<ClientesWeb> cliente = clientesWeb.ToList();

                    if ((cliente.Count == 1))
                    {
                        HttpContext.Session.SetInt32("UserId", cliente[0].Id);
                        HttpContext.Session.SetString("Login", cliente[0].Login);
                    }

                }
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Account = account;
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("Login");

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult TrocaSenha()
        {
            // TrocaSenhaViewModel trocaSenha = _context. HttpContext.Session.GetInt32("UserId");
            ViewBag.Account = new TrocaSenhaViewModel();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TrocaSenha(TrocaSenhaViewModel trocaSenha)
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }
    }
}
