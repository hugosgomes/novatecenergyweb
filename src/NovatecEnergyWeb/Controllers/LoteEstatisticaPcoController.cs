using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Filters.ActionFilters;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using NovatecEnergyWeb.Models.AdesaoViewModels;


namespace NovatecEnergyWeb.Controllers
{
    public class LoteEstatisticaPcoController : Controller
    {
        private BDNVTContext _context;
        private ILoteEstatisticaPcoRepository _loteEstatisticaPcoRepository;
        private ILotePcoRepository _lotePcoRepository;
        private IAreaRepository _areaRepository;
        private IDelegacaoRepository _delegacaoRepository;

        public LoteEstatisticaPcoController(BDNVTContext context,
            ILoteEstatisticaPcoRepository loteEstatisticaPcoRepository, ILotePcoRepository lotePcoRepository,
            IAreaRepository areaRepository, IDelegacaoRepository delegacaoRepository)
        {
            _context = context;
            _loteEstatisticaPcoRepository = loteEstatisticaPcoRepository;
            _lotePcoRepository = lotePcoRepository;
            _areaRepository = areaRepository;
            _delegacaoRepository = delegacaoRepository;
        }
        [HttpGet]
        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuscaEstatistica(int idLote)
        {
            return Json(_loteEstatisticaPcoRepository.GetLoteEstatisticaPcoByLote(idLote));
        }

        [HttpGet]
        public IActionResult BuscaLotes(int zona, int delegacao, int area)
        {
            int? id = HttpContext.Session.GetInt32("UserId");
            string tipo = HttpContext.Session.GetString("UserTipo");

            dynamic lotesTableSelect = new ExpandoObject();

            if (tipo == "func")
            {
                lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea();
            }
            else
            { // regras para limitar a exibição de lotes de acordo com a Zona, Delegação e Área do cliente
                if (area != null && area > 0)
                {
                    var areasCliente = _areaRepository.GetAreasByClienteId((int)id);
                    lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areasCliente));
                }
                else
                {
                    if (delegacao != null)
                    {
                        var areas = _areaRepository.GetAreasByDelegacao(new List<int>(), (int)delegacao);
                        lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                    }
                    else
                    {
                        if (zona != null)
                        {
                            var delegacoes = _delegacaoRepository.GetDelegacaoIdsByZona((int)zona);
                            var areas = _areaRepository.GetAreasByDelegacao(delegacoes, 0);
                            lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                        }
                        else
                        {
                            lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea();
                        }
                    }
                }
            }
            return Json(lotesTableSelect);
        }

        [HttpPost]
        public IActionResult BuscaLotes([FromForm]LoteEstatisticaViewModel filtros)
        {
            var zona = filtros.ZId;
            var delegacao = filtros.DId;
            var area = filtros.AId;
            dynamic lotesTableSelect = new ExpandoObject();

            if (area != null)
            {
                var areasId = new List<int>();
                areasId.Add(Convert.ToInt32(area));
                lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea(areasId);
            }
            else
            {
                if (delegacao != null)
                {
                    var areas = _areaRepository.GetAreasByDelegacao(new List<int>(), Convert.ToInt32(delegacao));
                    lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                }
                else
                {
                    var delegacoes = _delegacaoRepository.GetDelegacaoIdsByZona(Convert.ToInt32(zona));
                    var areas = _areaRepository.GetAreasByDelegacao(delegacoes, 0);
                    lotesTableSelect = _lotePcoRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                }
            }
            return Json(lotesTableSelect);
        }
    }
}
