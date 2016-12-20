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
        

            if (ModelState.IsValid)
            {
                var buscaUser = from u in _context.Funcionários.AsEnumerable()
                                let compara = Encryption.ValidateSHA1HashData(u.Senha, funcionario.Senha)
                                where u.Login == funcionario.Login && compara
                                select u;

                IList<Funcionários> usuario = buscaUser.ToList();


                if (usuario.Count == 1){

                    HttpContext.Session.SetInt32("FuncionarioId", Convert.ToInt32(funcionario.Login.Split('|')[0].ToString()));
                    HttpContext.Session.SetString("Login", funcionario.Login.Split('|')[1].ToString());

                    return RedirectToRoute("home-index");
                }

               
            }
            else
            {
                funcionario.Id = Convert.ToInt32(funcionario.Login.Split('|')[0].ToString());

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
