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
    }
}
