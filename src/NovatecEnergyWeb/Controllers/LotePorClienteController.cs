using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels;
using System.Dynamic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using NovatecEnergyWeb.Filters.ActionFilters;
using NovatecEnergyWeb.Models.Exportacao;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Domain.Interfaces;

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
        private IExcelExporterLotePorClienteApartamento _exportaExcelLotePorCliente;

        public LotePorClienteController(BDNVTContext context, IHostingEnvironment he, 
            IAreaRepository areaRepository, ILoteRepository loteRepository, 
            ICondominioLoteAtivo condominioRepository, IMotivoRejeicao motivoRejeicaoRepository,
            IExcelExporterLotePorClienteApartamento exportaExcelLotePorCliente)
        {
            _context = context;
            _hostingEnvironment = he;
            _areaRepository = areaRepository;
            _loteRepository = loteRepository;
            _condominioRepository = condominioRepository;
            _motivoRejeicaoRepository = motivoRejeicaoRepository;
            _exportaExcelLotePorCliente = exportaExcelLotePorCliente;
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
            var areasL = _areaRepository.GetAreasByDelegacao(listint, 0);
            var listAreaInt = _areaRepository.GetAreasIds(areasL);

            dynamic retorno = new ExpandoObject();
            retorno.Delegacao = delegacao;
            retorno.Area = areasL;
            retorno.Lotes = _loteRepository.GetLotes(listAreaInt, 0);
            retorno.Condominio = _condominioRepository.GetCondominios(listAreaInt,0,0);

            return Json(retorno);
        }



        public IActionResult DelegacaoCascade(int delegacao)
        {
            //áreas
            var areasList = _areaRepository.GetAreasByDelegacao(new List<int>(), delegacao);
            var listAreaInt = _areaRepository.GetAreasIds(areasList);

            dynamic retorno = new ExpandoObject();
            retorno.Area = areasList;
            retorno.Lotes = _loteRepository.GetLotes(listAreaInt, 0);
            retorno.Condominio = _condominioRepository.GetCondominios(listAreaInt, 0, 0); 

            return Json(retorno);
        }

        public IActionResult AreaCascade(int area)
        {
            dynamic retorno = new ExpandoObject();
            retorno.Lotes = _loteRepository.GetLotes(new List<int>(), area);
            retorno.Condominio = _condominioRepository.GetCondominios(null, area, 0); 
            return Json(retorno);
        }

        public IActionResult LoteCascade(int lote)
        {
            //area
            var loteParam = _context._11Lotes.Where(c => c.Id == lote)
                .Select( c => new  { Area = c.Area })
                .FirstOrDefault();

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
                retorno.Lotes = _loteRepository.GetLotes(_areaRepository.GetAreasIds(retorno.Area),0);
                retorno.Condominio = _condominioRepository.GetCondominios(_areaRepository.GetAreasIds(retorno.Area), 0, 0);
            }else
            {
                retorno.Area = null;
                retorno.Lotes = null;
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

            // dropdown status condominio : GASIFICANDO, COMERCIALIZANDO...
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
     
        public List<LotePorCliente> GetLotePorCliente([FromForm]FormFiltersVisitaClienteViewModels filtros)
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
            lb = _context._11_LoteAtivoB.FromSql("exec [dbo].[LotesPorCliente_ExportacaoGasNatural] {0}",  filtros.IdLote);


            return lb.ToList();
        }

        public IActionResult GetLotePorClienteEstatistica([FromForm]FormFiltersVisitaClienteViewModels filtros,  bool eIndex,string Botao, int PaginaClicada)
        {
            setFiltrosSessao(filtros, Botao); // salva os filtros na sessão

            //executa a SP e tras os valores filtrados
            var evList = GetLotePorCliente(filtros);

            var Tratados = evList.Sum(c => c.Tratado);// tratados recebe 1 nao tratados recebe 0
            var TratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Tratados), Convert.ToDecimal(evList.Count())) * 100) : 0;
            var NaoTratados = evList.Count() - Tratados;
            var NaoTratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(NaoTratados), Convert.ToDecimal(evList.Count())) * 100) : 0;


            var c0Visita = evList.Count(c => c.Tratado == 0 && c.Visitas == 0);
            var c0VisitaPercent = (NaoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(c0Visita), Convert.ToDecimal(NaoTratados)) * 100) : 0;

            var c1Visita = evList.Count(c => c.Tratado == 0 && c.Visitas == 1);
            var c1VisitaPercent = (NaoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(c1Visita), Convert.ToDecimal(NaoTratados)) * 100) : 0;

            var c2Visita = evList.Count(c => c.Tratado == 0 && c.Visitas == 2);
            var c2VisitaPercent = (NaoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(c2Visita), Convert.ToDecimal(NaoTratados)) * 100) : 0;

            var Visitados = evList.Sum(c => c.Visitado);
            var VisitadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitados), Convert.ToDecimal(evList.Count())) * 100):0;
            var NaoVisitados = evList.Count() - Visitados;
            var NaoVisitadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(NaoVisitados), Convert.ToDecimal(evList.Count())) * 100):0;
            //ok
          
            var Contratados = evList.Sum(c => c.Contratado);
            var ContratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Contratados), Convert.ToDecimal(evList.Count())) * 100):0;
            var NaoContratados = evList.Count() - Contratados;
            var NaoContratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(NaoContratados), Convert.ToDecimal(evList.Count())) * 100):0;
            //ok

            var D2 = evList.Sum(e => e.D2);
            var D2Percent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(D2), Convert.ToDecimal(evList.Count())) * 100) : 0;
            var Svg = evList.Sum(e => e.Svg);
            var SvgPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Svg), Convert.ToDecimal(evList.Count())) * 100) : 0;
            var Sve = evList.Sum(e => e.Sve);
            var SvePercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Sve), Convert.ToDecimal(evList.Count())) * 100) : 0;
            //ok

            var Visitas = evList.Sum(c => c.Visitas);
            var VisitasComResposta = evList.Sum(c => c.Entrevistas);
            var VisitasComRespostaPercent = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(VisitasComResposta), Convert.ToDecimal(Visitas)) * 100) : 0;
            var VisitasImprodutivas = evList.Sum(c => c.VisitasImpr);
            var VisitasImprodutivasPercent = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(VisitasImprodutivas), Convert.ToDecimal(Visitas)) * 100) : 0;
            var Ausentes = evList.Sum(c => c.Ausencias);
            var AusentesPercent = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Ausentes), Convert.ToDecimal(Visitas)) * 100) : 0;

            var NovaVisitaAgendada = evList.Sum(e => e.VisitasAgendadas);
            
            

            if (eIndex)
                return View("Index",evList);
            else
            {
                dynamic jsonModel = new ExpandoObject();
                jsonModel.Numeracoes = new List<dynamic>();
                jsonModel.Porcentagens = new List<dynamic>();

                jsonModel.Numeracoes.Add(evList.Count()); //e0          
                jsonModel.Numeracoes.Add(Visitados); //e1
                jsonModel.Numeracoes.Add(NaoVisitados);//e2
                jsonModel.Numeracoes.Add(Contratados);//e3
                jsonModel.Numeracoes.Add(NaoContratados);//e4
                jsonModel.Numeracoes.Add(D2);//e5
                jsonModel.Numeracoes.Add(Svg);//e6
                jsonModel.Numeracoes.Add(Sve);//e7
                jsonModel.Numeracoes.Add(Visitas);//e8
                jsonModel.Numeracoes.Add(VisitasComResposta);//e9
                jsonModel.Numeracoes.Add(VisitasImprodutivas);//e10
                jsonModel.Numeracoes.Add(Ausentes);//e11
                jsonModel.Numeracoes.Add(NovaVisitaAgendada);//e12
                jsonModel.Numeracoes.Add(Tratados); //e13
                jsonModel.Numeracoes.Add(NaoTratados); //e14
                jsonModel.Numeracoes.Add(c0Visita); //e15
                jsonModel.Numeracoes.Add(c1Visita); //e16
                jsonModel.Numeracoes.Add(c2Visita); //e17

                jsonModel.Porcentagens.Add(VisitadosPercent); //ep0
                jsonModel.Porcentagens.Add(NaoVisitadosPercent); //ep1
                jsonModel.Porcentagens.Add(ContratadosPercent);//ep2               
                jsonModel.Porcentagens.Add(NaoContratadosPercent);//ep3
                jsonModel.Porcentagens.Add(D2Percent);//ep4
                jsonModel.Porcentagens.Add(SvgPercent);//ep5
                jsonModel.Porcentagens.Add(SvePercent);//ep6
                jsonModel.Porcentagens.Add(VisitasComRespostaPercent);//ep7
                jsonModel.Porcentagens.Add(VisitasImprodutivasPercent);//ep8
                jsonModel.Porcentagens.Add(AusentesPercent);//ep9
                jsonModel.Porcentagens.Add(TratadosPercent);//ep10
                jsonModel.Porcentagens.Add(NaoTratadosPercent);//ep11
                jsonModel.Porcentagens.Add(c0VisitaPercent);//ep12
                jsonModel.Porcentagens.Add(c1VisitaPercent);//ep13
                jsonModel.Porcentagens.Add(c2VisitaPercent);//ep14

                // jsonModel.EV = evList;
                var pagina = 0;
                if (PaginaClicada != 0)
                {
                     pagina = (PaginaClicada - 1) * 20;
                }
                jsonModel.EV = evList.Skip(pagina).Take(20);
                jsonModel.QuantasPaginasExistem = (evList.Count() != 0) ? Math.Ceiling(decimal.Divide(Convert.ToDecimal(evList.Count()),20)) : 1;

                return Json(jsonModel);
            }
        }

        public IActionResult LimpaFiltros(string Botao)
        {
            return GetLotePorClienteEstatistica(null, false, Botao,0);
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
            var ev = GetLotePorCliente(GetFiltrosSessao());
            
            byte[] fileBytes = _exportaExcelLotePorCliente.ExportaPadraoNovatec(ev);

            return File(fileBytes, "application/x-msdownload", _exportaExcelLotePorCliente.FileName);
        }

        public IActionResult ExportaPadraoGasNatural()
        {
            var filtros = GetFiltrosSessao();
          
            var data = GetListLoteAtivoB(filtros);

            var lote = (from l in _context._11Lotes
                        where l.Id == Convert.ToInt32(filtros.IdLote)
                        join ti in _context._00TabelasItems on l.Status equals ti.Id
                        join ar in _context._00Areas on l.Area equals ar.Id
                        join dl in _context._00Delegacao on ar.Delegacao equals dl.Id
                        select new
                        {
                            Id = l.Id,
                            LoteNum = l.LoteNum,
                            Ge = l.Ge,
                            DataLote = l.DataLote,
                            Item = ti.Item,
                            Potencial = l.Potencial,
                            DataEntrega = l.DataEntrega,
                            Meta = l.Meta,
                            Zona = dl.Zona
                        });

            byte[] fileBytes = _exportaExcelLotePorCliente.ExportaPadraoGasNatural(data, lote);

            return File(fileBytes, "application/x-msdownload", _exportaExcelLotePorCliente.FileName);

        }
        
    }
}
