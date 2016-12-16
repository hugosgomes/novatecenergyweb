using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;

namespace NovatecEnergyWeb.Controllers
{
    public class LoginController : Controller
    {
        private TESTE2TSContext _context;

        public LoginController(TESTE2TSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //IList<Funcionarios> funcionarios = _context.Funcionarios.OrderBy(c => c.Login).ToList();
            return RetornaFuncionarios(true);
        }

        [HttpPost]
        public IActionResult Login()
        {
            //criar lógica de login
            return RedirectToAction("Index");
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
                return View(consulta);
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
