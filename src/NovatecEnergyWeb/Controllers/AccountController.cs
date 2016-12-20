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
            //IList<Funcionarios> funcionarios = _context.Funcionarios.OrderBy(c => c.Login).ToList();
            return RetornaFuncionarios(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Funcionários funcionario)
        {

            funcionario.Id = Convert.ToInt32(funcionario.Login.Split('|')[0].ToString());
            funcionario.Login = funcionario.Login.Split('|')[1].ToString();

            if (ModelState.IsValid)
            {
                Funcionários funcionarioStored = _context.Funcionários.Find(funcionario.Id);

                if (Encryption.ValidateSHA1HashData(funcionarioStored.Senha,funcionario.Senha))
                {
                    HttpContext.Session.SetInt32("FuncionarioId", funcionario.Id);
                    HttpContext.Session.SetString("Login", funcionario.Login);

                    return RedirectToAction("Index", "Home");
                }else
                {
                    return RedirectToAction("Index", "Home");
                }  
            }
            else
            {
               
                ViewBag.Funcionario = funcionario;
                IList<Funcionários> funcionarios = _context.Funcionários
                .OrderBy(c => c.Login)
                .Where(c => (c.Login != null))
                .Where(c => (c.DataDeDemissão == null))
                .ToList();

                return View("Index",funcionarios);
            }
  
        }

        public IActionResult RetornaFuncionarios(Boolean isView)
        {
            var consulta = _context.Funcionários
                .OrderBy(c => c.Login)
                .Where(c => (c.Login != null))
                .Where(c => (c.DataDeDemissão == null))
                .ToList();

            if (isView)
            {
                return View(consulta);
            }else
            {
                return Json(consulta);
            }
        }

        public IActionResult TrocaTipoUsuario(string control)
        {
            IList<Funcionários> list = new List<Funcionários>();
            if (control.Equals("cli"))
            {
                Funcionários f = new Funcionários();
                f.Id = 1;
                f.Login = "AnaAmelia";
                f.Senha = "123";
                Funcionários f2 = new Funcionários();
                f2.Id = 2;
                f2.Login = "Jorge";
                f.Senha = "www";

             
                list.Add(f);
                list.Add(f2);
                return Json(list);
            }else
            {
               return RetornaFuncionarios(false);
            }
            
        }
    }
}
