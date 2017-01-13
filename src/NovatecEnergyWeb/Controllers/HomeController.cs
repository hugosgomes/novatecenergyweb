using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Filters.ActionFilters;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.MetasViewModels;
using Microsoft.EntityFrameworkCore;


namespace NovatecEnergyWeb.Controllers
{
    public class HomeController : Controller
    {
        private BDNVTContext _context;

        public HomeController(BDNVTContext context)
        {
            _context = context;
        }

        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return View();
        }

        [AutenticacaoFilter]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Grafico()
        {
            return View();
        }


        public IActionResult TesteSP()
        {
            var retorno = _context._10_MetasCargas.FromSql("EXECUTE [dbo].[10_MetasCargas]").ToList();
            
            return Json(retorno);
        }
    }
}
