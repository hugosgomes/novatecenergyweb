using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using Microsoft.AspNetCore.Hosting;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class TesteController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public TesteController (IHostingEnvironment hostingEnviroment)
        {
            _hostingEnvironment = hostingEnviroment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public FileResult ExportaExcel()
        {
            ExportadorDados eD = new ExportadorDados(_hostingEnvironment);
            byte[] fileBytes = eD.ExportarParaExcel();
            return File(fileBytes, "application/x-msdownload", eD.SFileName);
        }
    }
}
