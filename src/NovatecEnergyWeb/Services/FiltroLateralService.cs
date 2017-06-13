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

        public IActionResult GetZonas()
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

        public IActionResult GetDelegacao()
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

        public IActionResult GetArea()
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

        [HttpGet]
        public IActionResult GetLotes()
        {
            int? id = HttpContext.Session.GetInt32("UserId");
            int? zona = HttpContext.Session.GetInt32("Zona");
            int? delegacao = HttpContext.Session.GetInt32("Delegação");
            int? qtdArea = HttpContext.Session.GetInt32("QuantidadeArea");
            string tipo = HttpContext.Session.GetString("UserTipo");

            dynamic lotes = new ExpandoObject();

            if (tipo == "func")
            {
                lotes = _loteRepository.GetLotesJoinItems();
            }
            else
            { // regras para limitar a exibição de lotes de acordo com a Zona, Delegação e Área do cliente
                if (qtdArea != null && qtdArea > 0)
                {
                    var areasCliente = _areaRepository.GetAreasByClienteId((int)id);
                    lotes = _loteRepository.GetLoteJoinZonaDelegacaoArea(_areaRepository.GetAreasIds(areasCliente));
                }
                else
                {
                    if (delegacao != null)
                    {
                        var areas = _areaRepository.GetAreasByDelegacao(new List<int>(), (int)delegacao);
                        lotes = _loteRepository.GetLotes(_areaRepository.GetAreasIds(areas),0);
                    }
                    else
                    {
                        if (zona != null)
                        {
                            var delegacoes = _delegacaoRepository.GetDelegacaoIdsByZona((int)zona);
                            var areas = _areaRepository.GetAreasByDelegacao(delegacoes, 0);
                            lotes = _loteRepository.GetLotes(_areaRepository.GetAreasIds(areas),0);
                        }
                        else
                        {
                            lotes = _loteRepository.GetLotesJoinItems();
                        }
                    }
                }
            }
            return Json(lotes);
        }

        public IActionResult GetCampoVenda()
        {
            var venda = _context._00TabelasItems.Where(v => v.Tabela == 290 && v.Campo == "VENDA").ToList();
            return Json(venda);
        }

        public IActionResult GetD1D2()
        {
            var d1d2 = _context._00TabelasItems.Where(d => d.Tabela == 290 && d.Campo == "TIPO").ToList();
            return Json(d1d2);
        }

        public IActionResult GetTipoVisita()
        {
            var tipovisita = _context._00TabelasItems.Where(d => d.Tabela == 290 && d.Campo == "STATUS").ToList();
            return Json(tipovisita);
        }

        public IActionResult GetRejeicao()
        {
            var rejeicao = _context._11MotivosRej.Select(m => new
            {
                Id = m.Id,
                Motivo = m.Motivo
            }).ToList();

            return Json(rejeicao);
        }

        public IActionResult GetAgenteComercial()
        {
            var agcomercial = _context.Funcionários.Where(f => f.Setor == 4 && f.DataDeDemissão == null)
                .OrderBy(f => f.NomeCompleto).Select(f => new
                {
                    Id = f.Id,
                    NomeCompleto = f.NomeCompleto
                }).ToList();

            return Json(agcomercial);
        }

        public IActionResult GetStatusCond()
        {
            var statuscond = _context._00TabelasItems.Where(ti => ti.Tabela == 237 && ti.Campo == "STATUS")
                .OrderBy(ti => ti.Ordem).ToList().Select(ti => new
                {
                    Id = ti.Id,
                    Item = ti.Item
                });

            return Json(statuscond);
        }

        public IActionResult GetCondominio()
        {
            var condominio = (from c in _context._11Condominios
                              join ti in _context._00TabelasItems on c.Status equals ti.Id
                              join lo in _context._00Logradouro on c.Logradouro equals lo.Id
                              join b in _context._00Bairro on lo.Bairro equals b.Id
                              join a in _context._00Areas on b.Area equals a.Id
                              join d in _context._00Delegacao on a.Delegacao equals d.Id
                              join z in _context._00Zona on d.Zona equals z.Id
                              where ti.Campo == "STATUS" && ti.Tabela == 237
                              orderby z.Z, d.D, c.Nome
                              select new
                              {
                                  Id = c.Id,
                                  Nome = c.Nome,
                                  Num = c.Num,
                                  Complemento = c.Complemento,
                                  Item = ti.Item,
                                  Z =z.Z,
                                  D = d.D
                              }
                             ).ToList();
            return Json(condominio);
        }
    }
}
