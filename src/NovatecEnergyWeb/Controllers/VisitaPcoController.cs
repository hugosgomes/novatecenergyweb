using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class VisitaPcoController : Controller
    {
        private IVisitaPcoRepository _visitaPcoRepository;

        public VisitaPcoController(
            IVisitaPcoRepository visitaPcoRepository)
        {
            _visitaPcoRepository = visitaPcoRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VisitaPco([FromRoute] VisitaPcoViewModel visitaViewModel, int PaginaClicada)
        {          
            var visitasPcoLista = _visitaPcoRepository.GetVisitaPco();
        
            if(visitaViewModel.ZId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.ZId == visitaViewModel.ZId).ToList();
            }
            if (visitaViewModel.DId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.DId == visitaViewModel.DId).ToList();
            }
            if (visitaViewModel.AId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AId == visitaViewModel.AId).ToList();
            }
            if (visitaViewModel.IdLote != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.IdLote == visitaViewModel.IdLote).ToList();
            }
            if (visitaViewModel.Interesse != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Interesse == visitaViewModel.Interesse).ToList();
            }
            if (visitaViewModel.NegativaId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.NegativaId == visitaViewModel.NegativaId).ToList();
            }
            if (visitaViewModel.AgComercialId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AgComercialId == visitaViewModel.AgComercialId).ToList();
            }
            if (visitaViewModel.Diavisita1 != null && visitaViewModel.Diavisita2 != null)
            {
                DateTime dt = Convert.ToDateTime(visitaViewModel.Diavisita1);
                DateTime dt2 = Convert.ToDateTime(visitaViewModel.Diavisita2);

                visitasPcoLista = visitasPcoLista.Where(w => w.DataHora >= dt && w.DataHora <= dt2)
                    .ToList();
            }
            if (visitaViewModel.Bairro != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.BairroB.Contains(visitaViewModel.Bairro.ToUpper())).ToList();
            }
            if (visitaViewModel.Localidade != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.LocalidadeB.Contains(visitaViewModel.Localidade.ToUpper())).ToList();
            }
            if (visitaViewModel.Logradouro != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.LogradouroB.Contains(visitaViewModel.Logradouro.ToUpper())).ToList();
            }
            if (visitaViewModel.AgVisita != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AgVisita.Contains(visitaViewModel.AgVisita)).ToList();
            }
            if (visitaViewModel.Pco != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.PcoB.Contains(visitaViewModel.Pco.ToUpper())).ToList();
            }
            if (visitaViewModel.Numero1 != 0 && visitaViewModel.Numero2 != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(c => c.Num >= visitaViewModel.Numero1 && c.Num <= visitaViewModel.Numero2).OrderBy(c => c.Num).ToList();
            }

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

        public IActionResult ExportaExcel(int Zid, int AId,int IdLote,int Interesse,int NegativaId, int AgComercialId,
                                    string Diavisita1, string Diavisita2, string Pco, string AgVisita, string Bairro,
                                       string Localidade, string Logradouro, int Numero1, int Numero2)
        {


            byte[] fileBytes = null;// _ExcelExportvisitaEndereco.ExportaPadraoNovatecCondVisita(vs);

            return File(fileBytes, "application/x-msdownload", "");
        }
    }
}
