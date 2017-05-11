using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.AdesaoViewModels;
using System.Dynamic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NovatecEnergyWeb.Filters.ActionFilters;
using NovatecEnergyWeb.Models.Exportacao;
using NovatecEnergyWeb.Models.Repository;

namespace NovatecEnergyWeb.Controllers
{
    public class LotePorClienteController : Controller
    {
        private BDNVTContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        private IAreaRepository _areaRepository;
        private ILoteRepository _loteRepository;
        private ICondominioLoteAtivo _condominioRepository;
        private IMotivoRejeicao _motivoRejeicaoRepository;
        private IExcelExportaLotePorCliente _exportaExcelRepository;

        public LotePorClienteController(BDNVTContext context, IHostingEnvironment he, 
            IAreaRepository areaRepository, ILoteRepository loteRepository, 
            ICondominioLoteAtivo condominioRepository, IMotivoRejeicao motivoRejeicaoRepository,
            IExcelExportaLotePorCliente exportaExcelRepository)
        {
            _context = context;
            _hostingEnvironment = he;
            _areaRepository = areaRepository;
            _loteRepository = loteRepository;
            _condominioRepository = condominioRepository;
            _motivoRejeicaoRepository = motivoRejeicaoRepository;
            _exportaExcelRepository = exportaExcelRepository;
        }

        [AutenticacaoFilter]
        public IActionResult Index()
        {
            BindSelects();

            return View("Index", new List<LotePorCliente>());
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
            var areasL = _areaRepository.GetAreas(listint, 0);
            var listAreaInt = _areaRepository.GetAreasIds(areasL);

            dynamic retorno = new ExpandoObject();
            retorno.Delegacao = delegacao;
            retorno.Area = areasL;
            retorno.Lote = _loteRepository.GetLotes(listAreaInt, 0);
            retorno.Condominio = _condominioRepository.GetCondominios(listAreaInt,0,0);

            return Json(retorno);
        }

        public IActionResult DelegacaoCascade(int delegacao)
        {
            //áreas
            var areasList = _areaRepository.GetAreas(new List<int>(), delegacao);
            var listAreaInt = _areaRepository.GetAreasIds(areasList);

            dynamic retorno = new ExpandoObject();
            retorno.Area = areasList;
            retorno.Lote = _loteRepository.GetLotes(listAreaInt, 0);
            retorno.Condominio = _condominioRepository.GetCondominios(listAreaInt, 0, 0); 

            return Json(retorno);
        }

        public IActionResult AreaCascade(int area)
        {
            dynamic retorno = new ExpandoObject();
            retorno.Lote = _loteRepository.GetLotes(new List<int>(), area);
            retorno.Condominio = _condominioRepository.GetCondominios(null, area, 0); 
            return Json(retorno);
        }

        public IActionResult LoteCascade(int lote)
        {
            //area
            var loteParam = _context._11Lotes.Where(c => c.Id == lote).FirstOrDefault();

            dynamic retorno = new ExpandoObject();
            retorno.Condominio = _condominioRepository.GetCondominios(null, loteParam.Area, 0);
            return Json(retorno);
        }

        public IActionResult StatusCliCascade(int status, int area)
        {
            dynamic retorno = new ExpandoObject();
            if (area == 0)
            {
                retorno.Condominio = _condominioRepository.GetCondominios(status);
            }
            else
            {
                retorno.Condominio = _condominioRepository.GetCondominios(new List<int>(), area, status);
            }
            
            return Json(retorno);
        }

        public IActionResult AreasdoCliente()
        {
            int? id = HttpContext.Session.GetInt32("UserId");
            dynamic retorno = new ExpandoObject();

            if (id != null)
            {
                retorno.Area = _areaRepository.GetAreasByClienteId((int)id);
                retorno.Lote = _loteRepository.GetLotes(_areaRepository.GetAreasIds(retorno.Area),0);
                retorno.Condominio = _condominioRepository.GetCondominios(_areaRepository.GetAreasIds(retorno.Area), 0, 0);
            }else
            {
                retorno.Area = null;
                retorno.Lote = null;
                retorno.Condominio = null;
            }
            return Json(retorno);
        }

        public void BindSelects()
        {
            ViewBag.Lotes = new List<List<dynamic>>();
            ViewBag.Lotes = _loteRepository.GetLotesJoinItems();
            
            ViewBag.MotivosRejeicao = new List<_11MotivosRej>();
            ViewBag.MotivosRejeicao = _motivoRejeicaoRepository.GetMotivosProdutoSv();

            var zonas = _context._00Zona.Where(c => c.Id < 3).Select(c => new { c.Id, c.Zona }).ToList();
            ViewBag.Zonas = new List<_00Zona>();
            foreach (var item in zonas)
            {
                var z = new _00Zona();
                z.Id = item.Id;
                z.Zona = item.Zona;
                ViewBag.Zonas.Add(z);
            }

            var delegacao = _context._00Delegacao.Select(c => new { c.Id, c.Delegacao, c.Zona }).ToList();
            ViewBag.Delegacao = new List<_00Delegação>();
            foreach (var item in delegacao)
            {
                var d = new _00Delegação();
                d.Id = item.Id;
                d.Delegacao = item.Delegacao;
                d.Zona = item.Zona;
                ViewBag.Delegacao.Add(d);
            }

            var areas = _context._00Areas.Select(c => new { c.Id, c.Area }).ToList();
            ViewBag.Area = new List<_00Areas>();
            foreach (var item in areas)
            {
                var a = new _00Areas();
                a.Id = item.Id;
                a.Area = item.Area;
                ViewBag.Area.Add(a);
            }

            var statusCondominio = _context._00TabelasItems
                .Where(c => (c.Tabela == 237) && (c.Campo == "STATUS") && (c.Id != 25))
                .OrderBy(c => c.Ordem)
                .Select(c => new { c.Id, c.Item }).ToList();
            ViewBag.StatusCondominios = new List<_00TabelasItems>();
            foreach (var item in statusCondominio)
            {
                var sc = new _00TabelasItems();
                sc.Id = item.Id;
                sc.Item = item.Item;
                ViewBag.StatusCondominios.Add(sc);
            }


            var listCond = _context._11_LoteAtivo_Condominios.FromSql("exec [dbo].[11_LoteAtivo_Condominios]").ToList();
            ViewBag.ListaCondominios = new List<_11_LoteAtivos_Condominios>();
            foreach (var item in listCond)
            {
                var c = new _11_LoteAtivos_Condominios();
                c.Id = item.Id;
                c.Nome = item.Nome;
                c.Num = item.Num;
                c.Complemento = item.Complemento;
                c.Item = item.Item;
                c.Z = item.Z;
                c.D = item.D;
                ViewBag.ListaCondominios.Add(c);
            }


        }

        public IActionResult EnderecosVisitasAtivosTodos()
        {
            BindSelects();
            return GetListLoteAtivoView(null, true, "todos",0);
        }
     
        public List<LotePorCliente> GetListLoteAtivo([FromForm]FormFiltersVisitaClienteViewModels filtros)
        {
            string storedProcedure = HttpContext.Session.GetString("SP_Lote");
            int? id = HttpContext.Session.GetInt32("UserId");
            int ? delegacao = HttpContext.Session.GetInt32("Delegação");
            int ? zona = HttpContext.Session.GetInt32("Zona");
            string tipo = HttpContext.Session.GetString("UserTipo");
            int? area = HttpContext.Session.GetInt32("Área");

            IQueryable <LotePorCliente> ev;
            if (filtros == null)
            {
                ev = _context.LotePorCliente.FromSql("execute " + storedProcedure + " {0},{1},{2},{3},{4},{5},{6},{7},{8}," +
                    "{9},{10},{11},{12},{13},{14},{15},{16}", null,null,null,null,null,zona,delegacao, null,null, null, null, null, null, null, null,null, 
                    (tipo == "cli" && (area != null)) ? id : null);
            }
            else
            {
                ev = _context.LotePorCliente.FromSql("execute "+storedProcedure+" {0},{1},{2},{3},{4},{5}," +
                     "{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}",
                    filtros.IdLote, filtros.CasaStatus, filtros.IdultMotivo, filtros.Dtult,
                    filtros.ClId, ((zona != null)? zona.ToString(): (filtros.ZId != null) ? filtros.ZId.ToString() : null), 
                    ((delegacao !=null)? delegacao.ToString(): (filtros.DId != null) ? filtros.DId.ToString() : null),
                    filtros.AId , filtros.StatusId,filtros.CondId, filtros.CondNome, filtros.Localidade, filtros.Bairro,
                    filtros.Logradouro, filtros.Numero1, filtros.Numero2, (tipo == "cli" && (area != null))? id:null);
            }
            // return ev.Skip(0).Take(5).ToList();
            return ev.ToList();
        }

        //fornece os dados para Exportação padrão Gás Natural
        public List<_11_LoteAtivoB> GetListLoteAtivoB(FormFiltersVisitaClienteViewModels filtros)
        {
            int? area = HttpContext.Session.GetInt32("Área");
            int? delegacao = HttpContext.Session.GetInt32("Delegação");
            int? zona = HttpContext.Session.GetInt32("Zona");

            IQueryable<_11_LoteAtivoB> lb;
            // lb = _context._11_LoteAtivoB.FromSql("exec [dbo].[11_LoteAtivoB]");

            /* lb = _context._11_LoteAtivoB.FromSql("exec [dbo].[11_LoteAtivoB] {0},{1},{2},{3},{4},{5}," +
                      "{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}",
                     filtros.IdLote, filtros.CasaStatus, filtros.IdultMotivo, filtros.Dtult,
                     filtros.ClId, ((zona != null) ? zona.ToString() : (filtros.ZId != null) ? filtros.ZId.ToString() : null),
                     ((delegacao != null) ? delegacao.ToString() : (filtros.DId != null) ? filtros.DId.ToString() : null),
                     ((area != null) ? area.ToString() : (filtros.AId != null) ? filtros.AId : null), filtros.StatusId,
                     filtros.CondId, filtros.CondNome, filtros.Localidade, filtros.Bairro,
                     filtros.Logradouro, filtros.Numero1, filtros.Numero2); */

            lb = _context._11_LoteAtivoB.FromSql("exec [dbo].[11_LoteAtivoB] {0}",  filtros.IdLote);


            return lb.ToList();
        }

        public IActionResult GetListLoteAtivoView([FromForm]FormFiltersVisitaClienteViewModels filtros,  bool eIndex,string Botao, int PaginaClicada)
        {
            setFiltrosSessao(filtros, Botao); // salva os filtros na sessão

            //executa a SP e tras os valores filtrados
            var evList = GetListLoteAtivo(filtros);

            ViewBag.Visitados = evList.Sum(c => c.Visitado);
            ViewBag.VisitadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Visitados), Convert.ToDecimal(evList.Count())) * 100):0;
            ViewBag.NaoVisitados = evList.Count() - ViewBag.Visitados;
            ViewBag.NaoVisitadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.NaoVisitados), Convert.ToDecimal(evList.Count())) * 100):0;
            //ok
          
            ViewBag.Contratados = evList.Sum(c => c.Contratado);
            ViewBag.ContratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Contratados), Convert.ToDecimal(evList.Count())) * 100):0;
            ViewBag.NaoContratados = evList.Count() - ViewBag.Contratados;
            ViewBag.NaoContratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.NaoContratados), Convert.ToDecimal(evList.Count())) * 100):0;
            //ok

            ViewBag.D2 = evList.Sum(e => e.D2);
            ViewBag.D2Percent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.D2), Convert.ToDecimal(evList.Count())) * 100) : 0;
            ViewBag.Svg = evList.Sum(e => e.Svg);
            ViewBag.SvgPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Svg), Convert.ToDecimal(evList.Count())) * 100) : 0;
            ViewBag.Sve = evList.Sum(e => e.Sve);
            ViewBag.SvePercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Sve), Convert.ToDecimal(evList.Count())) * 100) : 0;
            //ok

            ViewBag.Visitas = evList.Sum(c => c.Visitas);
            ViewBag.VisitasComResposta = evList.Sum(c => c.Entrevistas);
            ViewBag.VisitasComRespostaPercent = (ViewBag.Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.VisitasComResposta), Convert.ToDecimal(ViewBag.Visitas)) * 100) : 0;
            ViewBag.VisitasImprodutivas = evList.Sum(c => c.VisitasImpr);
            ViewBag.VisitasImprodutivasPercent = (ViewBag.Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.VisitasImprodutivas), Convert.ToDecimal(ViewBag.Visitas)) * 100) : 0;
            ViewBag.Ausentes = evList.Sum(c => c.Ausencias);
            ViewBag.AusentesPercent = (ViewBag.Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Ausentes), Convert.ToDecimal(ViewBag.Visitas)) * 100) : 0;

            ViewBag.NovaVisitaAgendada = evList.Sum(e => e.VisitasAgendadas);
            
            

            if (eIndex)
                return View("Index",evList);
            else
            {
                dynamic jsonModel = new ExpandoObject();
                jsonModel.Numeracoes = new List<string>();
                jsonModel.Porcentagens = new List<string>();

                jsonModel.Numeracoes.Add(evList.Count().ToString()); //e0
                jsonModel.Numeracoes.Add(ViewBag.Visitados.ToString()); //e1
                jsonModel.Numeracoes.Add(ViewBag.NaoVisitados.ToString());//e2
                jsonModel.Numeracoes.Add(ViewBag.Contratados.ToString());//e3
                jsonModel.Numeracoes.Add(ViewBag.NaoContratados.ToString());//e4
                jsonModel.Numeracoes.Add(ViewBag.D2.ToString());//e5
                jsonModel.Numeracoes.Add(ViewBag.Svg.ToString());//e6
                jsonModel.Numeracoes.Add(ViewBag.Sve.ToString());//e7
                jsonModel.Numeracoes.Add(ViewBag.Visitas.ToString());//e8
                jsonModel.Numeracoes.Add(ViewBag.VisitasComResposta.ToString());//e9
                jsonModel.Numeracoes.Add(ViewBag.VisitasImprodutivas.ToString());//e10
                jsonModel.Numeracoes.Add(ViewBag.Ausentes.ToString());//e11
                jsonModel.Numeracoes.Add(ViewBag.NovaVisitaAgendada.ToString());//e12

                jsonModel.Porcentagens.Add(ViewBag.VisitadosPercent.ToString()); //ep0
                jsonModel.Porcentagens.Add(ViewBag.NaoVisitadosPercent.ToString()); //ep1
                jsonModel.Porcentagens.Add(ViewBag.ContratadosPercent.ToString());//ep2               
                jsonModel.Porcentagens.Add(ViewBag.NaoContratadosPercent.ToString());//ep3
                jsonModel.Porcentagens.Add(ViewBag.D2Percent.ToString());//ep4
                jsonModel.Porcentagens.Add(ViewBag.SvgPercent.ToString());//ep5
                jsonModel.Porcentagens.Add(ViewBag.SvePercent.ToString());//ep6
                jsonModel.Porcentagens.Add(ViewBag.VisitasComRespostaPercent.ToString());//ep7
                jsonModel.Porcentagens.Add(ViewBag.VisitasImprodutivasPercent.ToString());//ep8
                jsonModel.Porcentagens.Add(ViewBag.AusentesPercent.ToString());//ep9

                // jsonModel.EV = evList;
                var pagina = 0;
                if (PaginaClicada != 0)
                {
                     pagina = (PaginaClicada - 1) * 45;
                }
                jsonModel.EV = evList.Skip(pagina).Take(45);
                jsonModel.QuantasPaginasExistem = (evList.Count() != 0) ? Math.Ceiling(decimal.Divide(Convert.ToDecimal(evList.Count()),45)) : 0;

                return Json(jsonModel);
            }
        }

        public IActionResult LimpaFiltros(string Botao)
        {
            return GetListLoteAtivoView(null, false, Botao,0);
        }

        public IActionResult LimpaSelects(bool LimpaFiltro)
        {
            BindSelects();
            var i = ViewBag.Lotes;

            dynamic jsonModel = new ExpandoObject();
            jsonModel.Lotes = ViewBag.Lotes;
            jsonModel.MotivosRejeicao = ViewBag.MotivosRejeicao;
            jsonModel.Zonas = ViewBag.Zonas;
            jsonModel.Delegacao = ViewBag.Delegacao;
            jsonModel.Area = ViewBag.Area;
            jsonModel.StatusCondominios = ViewBag.StatusCondominios;
            jsonModel.ListaCondominios = ViewBag.ListaCondominios;

            return Json(jsonModel);
        }

        private void setFiltrosSessao(FormFiltersVisitaClienteViewModels data, string Botao)
        {
            if (data != null)
            {
                HttpContext.Session.SetString("IdLote",  (data.IdLote == null)?"": data.IdLote);
                HttpContext.Session.SetString("CasaStatus", (data.CasaStatus == null) ? "" : data.CasaStatus);
                HttpContext.Session.SetString("IdultMotivo", (data.IdultMotivo == null) ? "" : data.IdultMotivo);
                HttpContext.Session.SetString("Dtult", (data.Dtult == null) ? "" : data.Dtult);
                HttpContext.Session.SetString("ClId", (data.ClId == null) ? "" : data.ClId);
                HttpContext.Session.SetString("ZId", (data.ZId == null) ? "" : data.ZId);
                HttpContext.Session.SetString("DId", (data.DId == null) ? "" : data.DId);
                HttpContext.Session.SetString("AId", (data.AId == null) ? "" : data.AId);
                HttpContext.Session.SetString("StatusId", (data.StatusId == null) ? "" : data.StatusId);
                HttpContext.Session.SetString("CondId", (data.CondId == null) ? "" : data.CondId);
                HttpContext.Session.SetString("CondNome", (data.CondNome == null) ? "" : data.CondNome);
                HttpContext.Session.SetString("Localidade", (data.Localidade == null) ? "" : data.Localidade);
                HttpContext.Session.SetString("Bairro", (data.Bairro == null) ? "" : data.Bairro);
                HttpContext.Session.SetString("Logradouro", (data.Logradouro == null) ? "" : data.Logradouro);
                HttpContext.Session.SetString("Numero1", (data.Numero1 == null) ? "" : data.Numero1);
                HttpContext.Session.SetString("Numero2", (data.Numero2 == null) ? "" : data.Numero2);
            }

            // Removido os botões de Lote Ativos; Sem Lotes, Todos e Não, não há necessidade da lógica abaixo
           /* string valorSP = "";

            switch (Botao)
            {
                case "ativos":
                    valorSP = "[dbo].[LotesPorCliente_Ativos]";
                    break;
                case "todos":
                    valorSP = "[dbo].[LotesPorCliente_Todos]";
                    break;
                case "semLoteTodos":
                    valorSP = "[dbo].[11_LoteNao]";
                    break;
                case "semLoteNao":
                    valorSP = ""; //lembrar de implementar
                    break;
            }*/

            HttpContext.Session.SetString("SP_Lote", "[dbo].[LotesPorCliente_Todos]");
        }

        private FormFiltersVisitaClienteViewModels GetFiltrosSessao()
        {
            var ffvm = new FormFiltersVisitaClienteViewModels();
            ffvm.IdLote =  (HttpContext.Session.GetString("IdLote") == "")?null: HttpContext.Session.GetString("IdLote");
            ffvm.CasaStatus = (HttpContext.Session.GetString("CasaStatus") == "") ? null : HttpContext.Session.GetString("CasaStatus");
            ffvm.IdultMotivo = (HttpContext.Session.GetString("IdultMotivo") == "") ? null : HttpContext.Session.GetString("IdultMotivo");
            ffvm.Dtult = (HttpContext.Session.GetString("Dtult") == "") ? null : HttpContext.Session.GetString("Dtult");
            ffvm.ClId = (HttpContext.Session.GetString("ClId") == "") ? null: HttpContext.Session.GetString("ClId");
            ffvm.ZId = (HttpContext.Session.GetString("ZId") == "") ? null:  HttpContext.Session.GetString("ZId");
            ffvm.DId = (HttpContext.Session.GetString("DId") == "") ? null : HttpContext.Session.GetString("DId");
            ffvm.AId = (HttpContext.Session.GetString("AId") == "") ? null : HttpContext.Session.GetString("AId");
            ffvm.StatusId = (HttpContext.Session.GetString("StatusId") == "") ? null : HttpContext.Session.GetString("StatusId");
            ffvm.CondId = (HttpContext.Session.GetString("CondId") == "") ? null : HttpContext.Session.GetString("CondId");
            ffvm.CondNome = (HttpContext.Session.GetString("CondNome") == "") ? null : HttpContext.Session.GetString("CondNome");
            ffvm.Localidade = (HttpContext.Session.GetString("Localidade") == "") ? null : HttpContext.Session.GetString("Localidade");
            ffvm.Bairro = (HttpContext.Session.GetString("Bairro") == "") ? null : HttpContext.Session.GetString("Bairro");
            ffvm.Logradouro = (HttpContext.Session.GetString("Logradouro") == "") ? null : HttpContext.Session.GetString("Logradouro");
            ffvm.Numero1 = (HttpContext.Session.GetString("Numero1") == "") ? null : HttpContext.Session.GetString("Numero1");
            ffvm.Numero2 = (HttpContext.Session.GetString("Numero2") == "") ? null : HttpContext.Session.GetString("Numero2");

            return ffvm;
        }

        public IActionResult ExportaExcel()
        {
            var ev = GetListLoteAtivo(GetFiltrosSessao());
            
            byte[] fileBytes = _exportaExcelRepository.ExportaPadraoNovatec(ev);

            return File(fileBytes, "application/x-msdownload", _exportaExcelRepository.FileName);
        }

        public IActionResult ExportaPadraoGasNatural()
        {
            var filtros = GetFiltrosSessao();
          
            var data = GetListLoteAtivoB(filtros);

            var lote = (from l in _context._11Lotes
                        where l.Id == Convert.ToInt32(filtros.IdLote)
                        join ti in _context._00TabelasItems on l.Status equals ti.Id
                        select new
                        {
                            Id = l.Id,
                            LoteNum = l.LoteNum,
                            Ge = l.Ge,
                            DataLote = l.DataLote,
                            Item = ti.Item,
                            Potencial = l.Potencial,
                            DataEntrega = l.DataEntrega,
                            Meta = l.Meta
                        });

            byte[] fileBytes = _exportaExcelRepository.ExportaPadraoGasNatural(data, lote);

            return File(fileBytes, "application/x-msdownload", _exportaExcelRepository.FileName);

        }
        
    }
}
