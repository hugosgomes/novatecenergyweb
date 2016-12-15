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
            
            return View(_context.Funcionários
                .OrderBy(c => c.Login)
                .Where(c => (c.Login != null) )
                .Where(c => (c.DataDeDemissão == null))
                .ToList());
        }

        [HttpPost]
        public IActionResult Login()
        {
            //criar lógica de login
            return RedirectToAction("Index");
        }

        public IActionResult TrocaTipoUsuario(string value)
        {
            Funcionários f = new Funcionários();
            f.Id = 1;
            f.Login = "AnaAmelia";
            f.Senha = "123";
            Funcionários f2 = new Funcionários();
            f2.Id = 2;
            f2.Login = "Jorge";
            f.Senha = "www";

            IList<Funcionários> list = new List<Funcionários>();
            list.Add(f);
            list.Add(f2);

            return Json(list);
        }
    }
}
