using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.Exportacao;
using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Domain.Interfaces.Repository;

namespace NovatecEnergyWeb.Controllers
{
    public class CondEnderecoController : Controller
    {
        private BDNVTContext _context;
      
        private IVisitaEnderecoRepository _visitaEnderecoRepository;
        private IAreaRepository _areaRepository;
        private ILoteRepository _loteRepository;
        private ICondominioLoteAtivo _condominioRepository;
        private IMotivoRejeicao _motivoRejeicaoRepository;
        private IExcelExportVisitaEnderecoCondominio _exportaExecelVisitaEndereco;

        public CondEnderecoController(BDNVTContext context,
           IVisitaEnderecoRepository visitaEnderecoRepository, IMotivoRejeicao motivoRejeicaoRepository, IAreaRepository areaRepository,
           ICondominioLoteAtivo condominioRepository, ILoteRepository loteRepository, IExcelExportVisitaEnderecoCondominio exportaExcelVisitaEndereco

           )

        {
            _context = context;
            _visitaEnderecoRepository = visitaEnderecoRepository;
             _motivoRejeicaoRepository = motivoRejeicaoRepository;
            _areaRepository = areaRepository;
            _loteRepository = loteRepository;
            _condominioRepository = condominioRepository;
            _exportaExecelVisitaEndereco = exportaExcelVisitaEndereco;

        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult BuscaVisitasEndereco(int num, int lotes, int zonas, int delegacao, int area,  String endereco )
        {


            var d = HttpContext.Session.GetInt32("Delegação");
            var z = HttpContext.Session.GetInt32("Zona");
            var quantArea = HttpContext.Session.GetInt32("QuantidadeArea");

            if (quantArea != null && ((int)quantArea == 1))
            {
                area = (int)HttpContext.Session.GetInt32("Área");
            }


            // se for cliente, vai ter as variáveis de sessão preenchidas
            zonas = (z != null) ? (int)z : zonas;
            delegacao = (d != null) ? (int)d : delegacao;

            // definicoes da paginacao
            var pagina = 0;
            var PaginaClicada = num;
            var itensPagina = 20;

            if (PaginaClicada != 0)
            {
                pagina = (PaginaClicada - 1) * itensPagina;
            }

            // retorna a consulta filtrada pelos parametros
            var visitas = _visitaEnderecoRepository.VisitasEnderecoFiltro(zonas, delegacao, area, lotes);
            

            var Potencial = visitas.Sum(c => c.Potencial);

            var Tratados = visitas.Sum(c => c.Tratados);
            var TratadosPerc =  (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Tratados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var naoTratados = Potencial - Tratados;
            var naoTratadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(naoTratados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var Visitas0 = visitas.Sum(c => c.Visitas0);
            var Visitas0Perc = (naoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitas0), Convert.ToDecimal(naoTratados)) * 100) : 0;

            var Visitas1 = visitas.Sum(c => c.Visitas1);
            var Visitas1Perc = (naoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitas1), Convert.ToDecimal(naoTratados)) * 100) : 0;

            var Visitas2 = visitas.Sum(c => c.Visitas2);
            var Visitas2Perc = (naoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitas2), Convert.ToDecimal(naoTratados)) * 100) : 0;

            var Visitados = visitas.Sum(c => c.Visitados);
            var VisitadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var naoVisitados = Potencial - Visitados;
            var naoVisitadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(naoVisitados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var tEnderecos = visitas.Count();

            var Visitas = visitas.Sum(c => c.Visitas);

            var Entrevistas = visitas.Sum(c => c.Entrevistas);
            var EntrevistasPerc = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Entrevistas), Convert.ToDecimal(Visitas)) * 100) : 0;

            var VisitasImpr = visitas.Sum(c => c.VisitasImpr);
            var VisitasImprPerc = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(VisitasImpr), Convert.ToDecimal(Visitas)) * 100) : 0;

            var VisitasAus = visitas.Sum(c => c.Ausencias);
            var VisitasAusPerc = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(VisitasAus), Convert.ToDecimal(Visitas)) * 100) : 0;

            var VisitasAge = visitas.Sum(c => c.VisitasAgendadas);

            // filtra as seguintes colunas
            if (endereco != null )
            {

                visitas = visitas.Where(c => c.Endereco.Contains(endereco));

            }

            var totalPaginas = visitas.Count() / itensPagina + 1 ; // retorna numero de paginas nescessario

            var vis2 = visitas.Skip(pagina)
                          .Take(itensPagina);


            


            dynamic jsonModel = new ExpandoObject();

           jsonModel.vis = vis2;
           jsonModel.Numeracoes = new List<dynamic>();
           jsonModel.Porcentagens = new List<dynamic>();
           jsonModel.totalPag = totalPaginas;

            jsonModel.Numeracoes.Add(Potencial);

            jsonModel.Numeracoes.Add(Tratados);
            jsonModel.Porcentagens.Add(TratadosPerc);

            jsonModel.Numeracoes.Add(naoTratados);
            jsonModel.Porcentagens.Add(naoTratadosPerc);

            jsonModel.Numeracoes.Add(Visitas0);
            jsonModel.Porcentagens.Add(Visitas0Perc);

            jsonModel.Numeracoes.Add(Visitas1);
            jsonModel.Porcentagens.Add(Visitas1Perc);

            jsonModel.Numeracoes.Add(Visitas2);
            jsonModel.Porcentagens.Add(Visitas2Perc);

            jsonModel.Numeracoes.Add(Visitados);
            jsonModel.Porcentagens.Add(VisitadosPerc);

            jsonModel.Numeracoes.Add(naoVisitados);
            jsonModel.Porcentagens.Add(naoVisitadosPerc);

            jsonModel.Numeracoes.Add(tEnderecos);

            jsonModel.Numeracoes.Add(Visitas);

            jsonModel.Numeracoes.Add(Entrevistas);
            jsonModel.Porcentagens.Add(EntrevistasPerc); 

            jsonModel.Numeracoes.Add(VisitasImpr);
            jsonModel.Porcentagens.Add(VisitasImprPerc);

            jsonModel.Numeracoes.Add(VisitasAus);
            jsonModel.Porcentagens.Add(VisitasAusPerc);

            jsonModel.Numeracoes.Add(VisitasAge);




            return Json(jsonModel);

        }


        public IActionResult ExportaExcel(int lotes, int zonas, int delegacao, int area, String endereco)
        {
            // retorna a consulta filtrada pelos parametros
            var visitas = _visitaEnderecoRepository.VisitasEnderecoFiltro(zonas, delegacao, area, lotes);


            // filtra as seguintes colunas
            if (endereco != null)
            {
                visitas = visitas.Where(c => c.Endereco.Contains(endereco));
            }

            List<VisitaEndereco> vs = visitas.ToList();


            byte[] fileBytes = _exportaExecelVisitaEndereco.ExportaPadraoNovatec(vs);

            return File(fileBytes, "application/x-msdownload", _exportaExecelVisitaEndereco.FileName);
        }



    }
}
