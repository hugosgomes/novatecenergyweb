using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.Repository;
using System.Dynamic;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class LoteEstatisticaController : Controller
    {
        private BDNVTContext _context;
        private ILoteEstatisticaRepository _loteEstatisticaRepository;
        private ILoteRepository _loteRepository;
        private IAreaRepository _areaRepository;

        public LoteEstatisticaController(BDNVTContext context,
            ILoteEstatisticaRepository loteEstatisticaRepository, ILoteRepository loteRepository,
            IAreaRepository areaRepository)
        {
            _context = context;
            _loteEstatisticaRepository = loteEstatisticaRepository;
            _loteRepository = loteRepository;
            _areaRepository = areaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.LoteSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea();
            return View();
        }

        public IActionResult BuscaEstatistica(int idLote)
        {
            return Json(_loteEstatisticaRepository.GetLoteEstatisticaByLote(idLote));
        }

        public IActionResult LotesDoCliente()
        {
            int? id = HttpContext.Session.GetInt32("UserId");
            dynamic lotesTableSelect = new ExpandoObject();

            if (id != null)
            {
                var areasCliente  = _areaRepository.GetAreasByClienteId((int)id);
                lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areasCliente));
            }else
            {
                lotesTableSelect = null;
            }

            return Json(lotesTableSelect);
        }
    }
}
