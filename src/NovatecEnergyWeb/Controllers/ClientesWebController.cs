using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class ClientesWebController : Controller
    {

        private TESTE2TSContext _context;

        public ClientesWebController(TESTE2TSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IList<ClientesWeb> lista = _context.ClientesWeb.ToList();

            return View(lista);
        }
    }
}
