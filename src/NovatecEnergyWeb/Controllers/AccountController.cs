using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AccountViewModels;
using Microsoft.AspNetCore.Http;
using NovatecEnergyWeb.Filters.ActionFilters;

namespace NovatecEnergyWeb.Controllers
{
    public class AccountController : Controller
    {
        private BDNVTContext _context;

        public AccountController(BDNVTContext context)
        {
            _context = context;
        }

        [HttpGet]
        [PosLoginFilter]
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
                        HttpContext.Session.SetString("UserTipo", account.Tipo);
                        HttpContext.Session.SetInt32("Grupo", Convert.ToInt32(user[0].Grupo));
                        //user[0].Grupo == 1 ? "diretoria" : ""
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
                        HttpContext.Session.SetString("UserTipo", account.Tipo);
                        HttpContext.Session.SetInt32("Grupo", -1); // cliente não possui grupo e 0 é grupo de TI
                        HttpContext.Session.SetInt32("Zona", cliente[0].Zona);
                        HttpContext.Session.SetInt32("Delegação", cliente[0].Delegacao);
                        

                    }

                }
                TempData["mensagem"] = "Login realizado com sucesso!";

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Account = account;
            return View();
        }

        [HttpGet]
        [AutenticacaoFilter]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("Login");
            HttpContext.Session.Remove("UserTipo");
            HttpContext.Session.Remove("Grupo");
            HttpContext.Session.Remove("Zona");
            HttpContext.Session.Remove("Delegação");

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        [AutenticacaoFilter]
        public IActionResult TrocaSenha()
        {
            string tipo = HttpContext.Session.GetString("UserTipo");
            int id = (int)HttpContext.Session.GetInt32("UserId");
            string login = HttpContext.Session.GetString("Login");

            ViewBag.Account = new TrocaSenhaViewModel();
            ViewBag.Account.Tipo = tipo;
            ViewBag.Account.Id = id;
            ViewBag.Account.Usuario = login;            
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AutenticacaoFilter]
        public IActionResult TrocaSenha(TrocaSenhaViewModel trocaSenha)
        {
            if (ModelState.IsValid)
            {
                if (trocaSenha.Tipo == "func")
                {
                    var funcionario = _context.Funcionários.Find(trocaSenha.Id);
                    funcionario.Senha = Encryption.GetSHA1HashData(trocaSenha.NovaSenha);

                }else
                {
                    var cliente = _context.ClientesWeb.Find(trocaSenha.Id);
                    cliente.Senha = Encryption.GetSHA1HashData(trocaSenha.NovaSenha);
                }
                _context.SaveChanges();

                TempData["mensagem"] = "Senha alterada com sucesso!";

                return RedirectToAction("Index", "Home");
            }
            ViewBag.Account = trocaSenha;
            return View();
        }
    }
}
