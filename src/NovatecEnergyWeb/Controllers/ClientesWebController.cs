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
            IList<ClientesWeb> lista = _context.ClientesWeb
                .Where(c => c.StatusLogin == false)
                .ToList();

            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ClientesWeb = new ClientesWeb();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClientesWeb clienteWeb)
        {
            if (ModelState.IsValid)
            {
                var senhaHash = Encryption.GetSHA1HashData(clienteWeb.Senha);
                clienteWeb.Senha = senhaHash;

                clienteWeb.StatusLogin = false;

                _context.ClientesWeb.Add(clienteWeb);
                _context.SaveChanges();

                var emailSender = new Email();
                emailSender.Enviar();

                return RedirectToAction("Login", "Account");
            }

            ViewBag.ClientesWeb = clienteWeb;
            return View();
        }

        public IActionResult AtivaClienteCadastrado(int clienteId)
        {
            var clienteWeb = _context.ClientesWeb.Find(clienteId);
            clienteWeb.StatusLogin = true;

            var clienteretorno = new ClientesWeb();
            clienteretorno.Id = clienteWeb.Id;
            clienteretorno.NomeCompleto = clienteWeb.NomeCompleto;

            _context.SaveChanges();

            var emailSender = new Email();
            emailSender.Enviar();

            return Json(clienteretorno);
        }
    }
}
