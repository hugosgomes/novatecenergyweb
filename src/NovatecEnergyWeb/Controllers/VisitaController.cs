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
using NovatecEnergyWeb.Models.Exportacao;
using NovatecEnergyWeb.Models.StoredProcedures;

namespace NovatecEnergyWeb.Controllers
{
    public class VisitaController : Controller
    {
        private BDNVTContext _context;
        private IVisitasRepository _VisitasRepository;
        private IAreaRepository _areaRepository;
        private ILoteRepository _loteRepository;
        private ICondominioLoteAtivo _condominioRepository;
        private IMotivoRejeicao _motivoRejeicaoRepository;
        private IExcelExportVisitas _exportaExecelVisitas;

        public VisitaController(BDNVTContext context,
           IVisitasRepository VisitasRepository, IMotivoRejeicao motivoRejeicaoRepository, IAreaRepository areaRepository,
           ICondominioLoteAtivo condominioRepository, ILoteRepository loteRepository, IExcelExportVisitas exportaExecelVisitas)

        {
            _context = context;
            _VisitasRepository = VisitasRepository;
            _motivoRejeicaoRepository = motivoRejeicaoRepository;
           _areaRepository = areaRepository;
            _loteRepository = loteRepository;
            _condominioRepository = condominioRepository;
            _exportaExecelVisitas = exportaExecelVisitas;

        }

        [HttpGet]
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BuscaVisitas(int num, int zonas, int delegacao, int area,int condominio, 
            int venda, int d1d2, int tipovisita, int rejeicao, int statuscond, String condominioinput,
            String agcomercialinput, String localidadeinput, String bairro, String logradouroinput, 
            String diavisita1, String diavisita2, int Numero1, int Numero2)
        {
            
            // definicoes da paginacao
            var pagina = 0;
            var PaginaClicada = num;
            var itensPagina = 20;

            if (PaginaClicada != 0)
            {
                pagina = (PaginaClicada - 1) * 20;
            }



            // retorna a consulta filtrada pelos parametros
            var visitas = _VisitasRepository.GetVisitasFiltro( zonas, delegacao, area, condominio);

          
            // filtra as seguintes colunas
            if (venda != 0) {

               visitas = visitas.Where( c =>c.Vendaid == venda);
               
            }

            if (d1d2 != 0)
            {

                visitas = visitas.Where(c => c.Dxid == d1d2);

            }

            if (tipovisita != 0)
            {

                visitas = visitas.Where(c => c.TipoVisitaid == tipovisita);

            }

            if (rejeicao != 0)
            {

                visitas = visitas.Where(c => c.Negativaid == rejeicao);

            }

            if (statuscond != 0)
            {

                visitas = visitas.Where(c => c.Statusid == statuscond);

            }

            if (condominioinput != null)
            {

                visitas = visitas.Where(c => c.Condominio.Contains(condominioinput));

            }

            if (agcomercialinput != null)
            {

                visitas = visitas.Where(c => c.AgVisita.Contains(agcomercialinput));

            }

            if (localidadeinput != null)
            {

                visitas = visitas.Where(c => c.Localidade.Contains(localidadeinput));

            }

            if (bairro != null)
            {

                visitas = visitas.Where(c => c.Bairro.Contains(bairro));

            }

            if (logradouroinput != null)
            {

                visitas = visitas.Where(c => c.Logradouro.Contains(logradouroinput));

            }

            if (Numero1 != 0 &&  Numero2 != 0)
            {

                visitas = visitas.Where(c => c.Num >=Numero1 && c.Num <= Numero2).OrderBy(c => c.Num);

            }



            if (diavisita1 != null && diavisita2 != null)
            {         
                
                    DateTime dt = Convert.ToDateTime(diavisita1);
                    DateTime dt2 = Convert.ToDateTime(diavisita2);

                    visitas = visitas.Where(w => w.DataHora >= dt && w.DataHora <= dt2
     
                    );


            }


            // paginacao
            var vis2 = visitas.Skip(pagina)
                          .Take(itensPagina);

            return Json(vis2);

            

        }
        
   

        [HttpGet]
        public IActionResult BuscaZona()
        {

            var zona = _context._00Zona.ToList();

            return Json(zona);
        }

        [HttpGet]
        public IActionResult BuscaDelegacao()
        {

            var delegacao = _context._00Delegacao.ToList();

            return Json(delegacao);
        }

        [HttpGet]
        public IActionResult BuscaArea()
        {

            var area = _context._00Areas.ToList();

            return Json(area);
        }

        [HttpGet]
        public IActionResult BuscaLote()
        {

            var lote = _context._11Lotes.ToList();

            return Json(lote);
        }


        [HttpGet]
        public IActionResult BuscaAgente()
        {

            var agComercial = _context.Funcionários.ToList();

            return Json(agComercial);
        }

        [HttpGet]
        public IActionResult BuscaCondominio()
        {

            var condominio = _context._11Condominios.ToList().OrderBy(c => c.Nome);

            return Json(condominio);
        }

        [HttpGet]
        public IActionResult BuscaStatus()
        {

           var status = _context._00TabelasItems.Where(c => c.Tabela == 237 && c.Campo == "STATUS").OrderBy(c => c.Item);
           
           return Json(status);


           /* var statuscond = _context._00TabelasItems.Where(ti => ti.Tabela == 237 && ti.Campo == "STATUS"
            && ti.Id != 25)
                .OrderBy(ti => ti.Ordem).ToList().Select(ti => new
                {
                    Id = ti.Id,
                    Item = ti.Item
                });

            return Json(statuscond);*/
        }

        [HttpGet]
        public IActionResult BuscaD()
        {

            var d = _context._00TabelasItems.Where(c => c.Tabela == 290 && c.Campo == "TIPO").OrderBy(c => c.Item);

            return Json(d);
        }

        [HttpGet]
        public IActionResult BuscaRejeicao()
        {

            var rejeicao = _motivoRejeicaoRepository.GetMotivosProdutoSv()
                 .Select(m => new
                 {
                     Id = m.Id,
                     Motivo = m.Motivo
                 }).ToList();
            return Json(rejeicao);
        }


        [HttpGet]
        public IActionResult Buscavenda()
        {

            var vendas = _context._00TabelasItems.Where(c => c.Tabela == 290 && c.Campo == "VENDA").OrderBy(c => c.Item);

            return Json(vendas);
        }


        [HttpGet]
        public IActionResult BuscaTipoVisita()
        {

            var visitas = _context._00TabelasItems.Where(c => c.Tabela == 290 && c.Campo == "STATUS").OrderBy(c => c.Item);

            return Json(visitas);
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
            retorno.Condominio = _condominioRepository.GetCondominios(listAreaInt, 0, 0);

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
            var loteParam = _context._11Lotes.Where(c => c.Id == lote).FirstOrDefault();

            dynamic retorno = new ExpandoObject();
            retorno.Condominio = _condominioRepository.GetCondominios(null, loteParam.Area, 0);
            return Json(retorno);
        }


        public IActionResult ExportaExcel( int zonas, int delegacao, int area, int condominio,
            int venda, int d1d2, int tipovisita, int rejeicao, int statuscond, String condominioinput,
            String agcomercialinput, String localidadeinput, String bairro, String logradouroinput,
            String diavisita1, String diavisita2, int Numero1, int Numero2)
        {

         
            // retorna a consulta filtrada pelos parametros
            var visitas = _VisitasRepository.GetVisitasFiltro(zonas, delegacao, area, condominio);


            // filtra as seguintes colunas
            if (venda != 0) { visitas = visitas.Where(c => c.Vendaid == venda);}

            if (d1d2 != 0) { visitas = visitas.Where(c => c.Dxid == d1d2); }

            if (tipovisita != 0) { visitas = visitas.Where(c => c.TipoVisitaid == tipovisita); }

            if (rejeicao != 0) { visitas = visitas.Where(c => c.Negativaid == rejeicao); }

            if (statuscond != 0) { visitas = visitas.Where(c => c.Statusid == statuscond); }

            if (condominioinput != null) { visitas = visitas.Where(c => c.Condominio.Contains(condominioinput)); }

            if (agcomercialinput != null) { visitas = visitas.Where(c => c.AgVisita.Contains(agcomercialinput)); }

            if (localidadeinput != null) { visitas = visitas.Where(c => c.Localidade.Contains(localidadeinput)); }

            if (bairro != null) { visitas = visitas.Where(c => c.Bairro.Contains(bairro)); }

            if (logradouroinput != null) { visitas = visitas.Where(c => c.Logradouro.Contains(logradouroinput)); }

            if (Numero1 != 0 && Numero2 != 0) { visitas = visitas.Where(c => c.Num >= Numero1 && c.Num <= Numero2).OrderBy(c => c.Num); }

            if (diavisita1 != null && diavisita2 != null)
            {

                DateTime dt = Convert.ToDateTime(diavisita1);
                DateTime dt2 = Convert.ToDateTime(diavisita2);

                visitas = visitas.Where(w => w.DataHora >= dt && w.DataHora <= dt2

                );


            }

            // cast IEnumerable em List
            List<Visitas> vs = visitas.ToList();


            byte[] fileBytes = _exportaExecelVisitas.ExportaPadraoNovatec(vs);

            return File(fileBytes, "application/x-msdownload", _exportaExecelVisitas.FileName);
        }

    }
}
