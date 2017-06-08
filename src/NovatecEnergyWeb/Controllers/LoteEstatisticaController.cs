using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.Repository;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AdesaoViewModels;
using NovatecEnergyWeb.Filters.ActionFilters;

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
        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuscaEstatistica(int idLote)
        {
            return Json(_loteEstatisticaRepository.GetLoteEstatisticaByLote(idLote));
        }

       [HttpGet]
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
            { // regras para limitar a exibição de lotes de acordo com a Zona, Delegação e Área do cliente
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
                lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(areasId);
            }
            else
            {
                if(delegacao != null)
                {
                    var areas = _areaRepository.GetAreasByDelegacao(new List<int>(), Convert.ToInt32(delegacao));
                    lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                }
                else
                {
                    var delegacoes = _delegacaoRepository.GetDelegacaoIdsByZona(Convert.ToInt32(zona));
                    var areas = _areaRepository.GetAreasByDelegacao(delegacoes, 0);
                    lotesTableSelect = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areas));
                }

            }
            return Json(lotesTableSelect);

        }

        public IActionResult getZonas()
        {
            var id = HttpContext.Session.GetInt32("UserId");
            var zonaCliente = HttpContext.Session.GetInt32("Zona");

            var zonas = new List<_00Zona>();

            if (zonaCliente != null)
            {
                zonas = _context._00Zona.Where(z => z.Id == zonaCliente).ToList();
            }
            else
            {
                zonas = _context._00Zona.Where(z => z.Id !=3).ToList();
            }

            return Json(zonas);
        }

        public IActionResult getDelegacao()
        {
            var zona = HttpContext.Session.GetInt32("Zona");
            var delegacaoId = HttpContext.Session.GetInt32("Delegação");

            var delegacao = new List<_00Delegação>();
            if (zona != null)
            {
                if (delegacaoId != null)
                    delegacao = _context._00Delegacao.Where(d => d.Id == Convert.ToInt32(delegacaoId)).ToList();
                else
                    delegacao = _context._00Delegacao.Where(d => d.Zona == Convert.ToInt32(zona)).ToList();
            }
            else
            {
                delegacao = _context._00Delegacao.ToList();
            }
                
            return Json(delegacao);
        }

        public IActionResult getArea()
        {
            var zona = HttpContext.Session.GetInt32("Zona");
            var delegacaoId = HttpContext.Session.GetInt32("Delegação");
            var id = HttpContext.Session.GetInt32("UserId");
            var tipo = HttpContext.Session.GetString("UserTipo");
            var qtdArea = HttpContext.Session.GetInt32("QuantidadeArea");
            var area = new List<_00Areas>();


            if (tipo == "cli")
            {
                if (qtdArea != null && qtdArea > 0)
                {
                    area = _areaRepository.GetAreasByClienteId((int)id);
                }
                else
                {
                    if (delegacaoId != null)
                    {
                        area = _areaRepository.GetAreasByDelegacao(new List<int>(), (int)delegacaoId);
                    }
                    else
                    {
                        if (zona != null)
                        {
                            var delegacoes = _delegacaoRepository.GetDelegacaoIdsByZona((int)zona);
                            area = _areaRepository.GetAreasByDelegacao(delegacoes, 0);
                        }
                    }
                }
            }
            else
            {
                area = _context._00Areas.ToList();
            }
            return Json(area);
        }
    }
}
