using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class VisitaPcoController : Controller
    {
        private BDNVTContext _context;

        private ICondVisitasRepository _condVisitasRepository;
        private IAreaRepository _areaRepository;
        private ILoteRepository _loteRepository;
        private ICondominioLoteAtivo _condominioRepository;
        private IMotivoRejeicao _motivoRejeicaoRepository;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
