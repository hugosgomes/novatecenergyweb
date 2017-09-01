using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;

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

        public IActionResult GetVisitaPco([FromForm] VisitaPco visitaPco)
        {          
            var visitasPcoLista = _visitaPcoRepository.GetVisitaPco();
        
            if (visitaPco.IdLote != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.IdLote == visitaPco.IdLote).ToList();
            }

            if (visitaPco.Interesse != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Interesse == visitaPco.Interesse).ToList();
            }

            if (visitaPco.NegativaId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.NegativaId == visitaPco.NegativaId).ToList();
            }

            if (visitaPco.AgComercialId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AgComercialId == visitaPco.AgComercialId).ToList();
            }


            if (visitaPco.Diavisita1 != null && visitaPco.Diavisita2 != null)
            {
                DateTime dt = Convert.ToDateTime(visitaPco.Diavisita1);
                DateTime dt2 = Convert.ToDateTime(visitaPco.Diavisita2);

                visitasPcoLista = visitasPcoLista.Where(w => w.DataHora >= dt && w.DataHora <= dt2)
                    .ToList();
            }

            if (visitaPco.Bairro != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Bairro.Contains(visitaPco.Bairro)).ToList();
            }

            if (visitaPco.Localidade != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Localidade.Contains(visitaPco.Localidade)).ToList();
            }

            if (visitaPco.Logradouro != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Logradouro.Contains(visitaPco.Logradouro)).ToList();
            }

            if (visitaPco.AgComercial != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AgComercial.Contains(visitaPco.AgComercial)).ToList();
            }

            if (visitaPco.Pco != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Pco.Contains(visitaPco.Pco)).ToList();
            }


            if (visitaPco.Numero1 != 0 && visitaPco.Numero2 != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(c => c.Num >= visitaPco.Numero1 && c.Num <= visitaPco.Numero2).OrderBy(c => c.Num).ToList();
            }

            return Json(visitasPcoLista);
        }

      /*  public IActionResult GetVisitaPco([FromForm] VisitaPco visitaPco)
        {
            // definicoes da paginacao
            var itensPorPagina = 20;

            var pagina = 0;
            if (paginaClicada != 0)
            {
                pagina = (paginaClicada - 1) * itensPorPagina;
            }

            var visitasPcoLista = _visitaPcoRepository.GetVisitaPco();

            //terminar depois
            var retorno = new
            {
                visitasPco = visitasPcoLista.Skip(pagina).Take(itensPorPagina),
                QuantasPaginasExistem = (visitasPcoLista.Count() != 0) ? Math.Ceiling(decimal.Divide(Convert.ToDecimal(visitasPcoLista.Count()), itensPorPagina)) : 1
            };

            return Json(retorno);
        }*/
    }
}
