using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using NovatecEnergyWeb.Models.Repository;

namespace NovatecEnergyWeb.Services
{
    public class FiltroLateralServiceController : Controller, IFiltroLateralService
    {
        private BDNVTContext _context;
        private ILoteRepository _loteRepository;
        private IAreaRepository _areaRepository;
        private IDelegacaoRepository _delegacaoRepository;

        public FiltroLateralServiceController(BDNVTContext context, ILoteRepository loteRepository,
            IAreaRepository areaRepository, IDelegacaoRepository delegacaoRepository)
        {
            _context = context;
            _loteRepository = loteRepository;
            _areaRepository = areaRepository;
            _delegacaoRepository = delegacaoRepository;
        }

        public IActionResult AreaCascade(int lote)
        {
            throw new NotImplementedException();
        }

        public IActionResult DelegacaoCascade(int delegacao)
        {
            //area
            var AreasL = _context._00Areas.Where(c => c.Delegacao == delegacao).ToList();
            var listAreaInt = new List<int>();
            foreach (var item in AreasL)
            {
                listAreaInt.Add(item.Id);
            }

            dynamic retorno = new ExpandoObject();
            retorno.area = AreasL;

            return Json(retorno);
        }

        public IActionResult ZonaCascade(int zona)
        {
            //delegacao
            var delegacao = _context._00Delegacao.Where(c => c.Zona == zona)
                .Select(c => new _00Delegação { Id = c.Id, Delegacao = c.Delegacao, Zona = c.Zona })
            .ToList();

            var listint = new List<int>();
            foreach (var item in delegacao)
            {
                listint.Add(item.Id);
            }

            //area
            var areasL = _context._00Areas.Where(x => listint.Contains(Convert.ToInt32(x.Delegacao))).ToList();

            //lotes 
            var listAreaInt = new List<int>();
            foreach (var item in areasL)
            {
                listAreaInt.Add(item.Id);
            }

            dynamic retorno = new ExpandoObject();
            retorno.delegacao = delegacao;
            retorno.area = areasL;
            

            return Json(retorno);
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
                zonas = _context._00Zona.Where(z => z.Id != 3).ToList();
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
