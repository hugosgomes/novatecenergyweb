using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class LoteEstatisticaController : Controller
    {
        private BDNVTContext _context;
        private ILoteEstatisticaRepository _loteEstatisticaRepository;
        private ILoteRepository _loteRepository;

        public LoteEstatisticaController(BDNVTContext context, ILoteEstatisticaRepository loteEstatisticaRepository, ILoteRepository loteRepository)
        {
            _context = context;
            _loteEstatisticaRepository = loteEstatisticaRepository;
            _loteRepository = loteRepository;
        }

        public IActionResult Index()
        {
            ViewBag.LoteSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea();
            return View();
        }
    }
}
