using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels;
using NovatecEnergyWeb.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using NovatecEnergyWeb.Filters.ActionFilters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class VisitaPcoController : Controller
    {
        private IVisitaPcoRepository _visitaPcoRepository;
        private IExcelExporterLotePorClienteApartamento _exporter;

        public VisitaPcoController(IVisitaPcoRepository visitaPcoRepository, IExcelExporterLotePorClienteApartamento exporter)
        {
            _visitaPcoRepository = visitaPcoRepository;
            _exporter = exporter;
        }

        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AutenticacaoFilter]
        public IActionResult VisitaPco([FromForm] VisitaPcoViewModel visitaViewModel, int PaginaClicada)
        {          
            var visitasPcoLista = _visitaPcoRepository.GetVisitaPco();

            var d = HttpContext.Session.GetInt32("Delegação");
            var z = HttpContext.Session.GetInt32("Zona");
            var quantArea = HttpContext.Session.GetInt32("QuantidadeArea");

            if (quantArea != null && ((int)quantArea == 1))
            {
                visitaViewModel.AId = (int)HttpContext.Session.GetInt32("Área");
            }
            // se for cliente, vai ter as variáveis de sessão preenchidas
            visitaViewModel.ZId = (z != null) ? (int)z : visitaViewModel.ZId;
            visitaViewModel.DId = (d != null) ? (int)d : visitaViewModel.DId;

            visitasPcoLista = _visitaPcoRepository.AplicaFiltro(visitaViewModel, visitasPcoLista);

            //paginação
            var pagina = 0;
            var itensPorPagina = 20;
            if (PaginaClicada != 0)
            {
                pagina = (PaginaClicada - 1) * itensPorPagina;
            }

            var retorno = new
            {
                visitasPco = visitasPcoLista.Skip(pagina).Take(itensPorPagina),
                QuantasPaginasExistem = (visitasPcoLista.Count() != 0) ? Math.Ceiling(decimal.Divide(Convert.ToDecimal(visitasPcoLista.Count()), itensPorPagina)) : 1,
                contagem = visitasPcoLista.Count()
            };

            return Json(retorno);
        }

        [AutenticacaoFilter]
        public IActionResult ExportaPadraoNovatec(int Zid, int AId,int IdLote,int Interesse,int NegativaId, int AgComercialId,
                                    string Diavisita1, string Diavisita2, string Pco, string AgVisita, string Bairro,
                                       string Localidade, string Logradouro, int Numero1, int Numero2, int TipoVisitaId)
        {
            var viewModel = new VisitaPcoViewModel()
            {
                ZId = Zid,
                AId = AId,
                IdLote = IdLote,
                Interesse = Interesse,
                NegativaId = NegativaId,
                AgComercialId = AgComercialId,
                Diavisita1 = Diavisita1,
                Diavisita2 = Diavisita2,
                Pco = Pco, 
                AgVisita = AgVisita,
                Bairro = Bairro,
                Localidade = Localidade,
                Logradouro = Logradouro,
                Numero1 = Numero1, 
                Numero2 = Numero2,
                TipoVisitaId = TipoVisitaId
            };
            

            var visitasPcoLista = _visitaPcoRepository.GetVisitaPco();

            // filtros vindos da View
            visitasPcoLista = _visitaPcoRepository.AplicaFiltro(viewModel, visitasPcoLista);

            byte[] fileBytes = _exporter.ExportaPadraoNovatecVisitaPco(visitasPcoLista.ToList());

            return File(fileBytes, "application/x-msdownload", _exporter.FileName);
        }
    }
}
