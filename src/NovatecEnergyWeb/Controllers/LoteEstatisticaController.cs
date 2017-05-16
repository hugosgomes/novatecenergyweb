﻿using System;
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
        private IDelegacaoRepository _delegacaoRepository;

        public LoteEstatisticaController(BDNVTContext context,
            ILoteEstatisticaRepository loteEstatisticaRepository, ILoteRepository loteRepository,
            IAreaRepository areaRepository, IDelegacaoRepository delegacaoRepository)
        {
            _context = context;
            _loteEstatisticaRepository = loteEstatisticaRepository;
            _loteRepository = loteRepository;
            _areaRepository = areaRepository;
            _delegacaoRepository = delegacaoRepository;
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

        public IActionResult BuscaLotes()
        {
            int? id = HttpContext.Session.GetInt32("UserId");
            int? zona = HttpContext.Session.GetInt32("Zona");
            int? delegacao = HttpContext.Session.GetInt32("Delegação");
            int? qtdArea = HttpContext.Session.GetInt32("QuantidadeArea");
            string tipo = HttpContext.Session.GetString("UserTipo");

            dynamic lotesTableSelect = new ExpandoObject();
            
            if(tipo == "func")
            {
                lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea();
            }
            else
            {
                if (qtdArea !=null && qtdArea > 0)
                {
                    var areasCliente = _areaRepository.GetAreasByClienteId((int)id);
                    lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areasCliente));
                }else 
                {
                    if(delegacao != null)
                    {
                       var areas = _areaRepository.GetAreasByDelegacao(new List<int>(), (int)delegacao);
                       lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                    }else
                    {
                        if(zona != null)
                        {
                            var delegacoes = _delegacaoRepository.GetDelegacaoIdsByZona((int)zona);
                            var areas = _areaRepository.GetAreasByDelegacao(delegacoes, 0);
                            lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                        }
                        else
                        {
                            lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea();
                        }
                    }
                }
            }
            return Json(lotesTableSelect);
        }
    }
}
