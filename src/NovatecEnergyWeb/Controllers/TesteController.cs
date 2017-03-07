using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class TesteController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private BDNVTContext _context;

        public TesteController (IHostingEnvironment hostingEnviroment,BDNVTContext context)
        {
            _hostingEnvironment = hostingEnviroment;
            _context = context;
        }

        public IActionResult Index()
        {
            var _11_condVisita = _context._11_CondVisitasB.FromSql("exec [dbo].[11_CondVisitasB]").ToList();
            return View();
        }

        public FileResult ExportaExcel()
        {
            ExportadorDadosTeste eD = new ExportadorDadosTeste(_hostingEnvironment);
            byte[] fileBytes = eD.ExportarParaExcel();
            return File(fileBytes, "application/x-msdownload", eD.SFileName);
        }
    }
}
