﻿using System;
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
                //.Where(c => c.StatusLogin == false)
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

                //email para diretoria
                var emailSender = new EmailDiretoria(clienteWeb.NomeCompleto);
                emailSender.Enviar();

                TempData["mensagem"] = "Cliente criado com sucesso!";

                return RedirectToAction("Login", "Account");
            }

            ViewBag.ClientesWeb = clienteWeb;
            return View();
        }

        public IActionResult AtivaClienteCadastrado(int clienteId)
        {
            var clienteWeb = _context.ClientesWeb.Find(clienteId);
            if ((bool)clienteWeb.StatusLogin)
                clienteWeb.StatusLogin = false;
            else
                clienteWeb.StatusLogin = true;

            _context.SaveChanges();

            var clienteretorno = new ClientesWeb();
            clienteretorno.Id = clienteWeb.Id;
            clienteretorno.NomeCompleto = clienteWeb.NomeCompleto;
            clienteretorno.StatusLogin = clienteWeb.StatusLogin;

            //enviar instruções falando para o cliente que ele já pode logar
            if ((bool)clienteretorno.StatusLogin)
            {
                var emailSender = new EmailCliente(clienteWeb.Email);
                emailSender.Enviar();
            }

            return Json(clienteretorno);
        }
    }
}
