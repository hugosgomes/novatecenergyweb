using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Filters.ActionFilters;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using NovatecEnergyWeb.Models.ViewModels.MetasViewModels;
using NovatecEnergyWeb.Core;

namespace NovatecEnergyWeb.Controllers
{
    public class CargasController : Controller
    {
        private BDNVTContext _context;

        public CargasController(BDNVTContext context)
        {
            _context = context;
        }
        
        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return BuscaCargasFiltradas(DateTime.Now.Year, true);
        }

        [AutenticacaoFilter]
        public IActionResult BuscaCargasFiltradas(int anoSelecionado, bool index)
        {
            var cargas = _context._10_CargasMetas.FromSql("EXECUTE [dbo].[10_CargasMetas]").Where(c => c.AnoCarga == anoSelecionado).ToList();

            dynamic mymodel = new ExpandoObject();
            mymodel.Cargas = GetCargas(cargas, "cargas");

            if (index)
                return View(mymodel);
            else
                return Json(mymodel);
        }

        public List<ResultadosViewModel> GetCargas(List<_10_CargasMetas> cargas, string tipoMeta)
        {
            var fluminense = new ResultadosViewModel();
            var metropolitana = new ResultadosViewModel();
            var total = new ResultadosViewModel();

            var resultados = new List<ResultadosViewModel>();

            metropolitana.Meses = new List<string>() { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            fluminense.Meses = new List<string>() { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            total.Meses = new List<string>() { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

            metropolitana.Id = 1;
            fluminense.Id = 2;

            #region for
            foreach (var item in cargas)
            {
                if (item.ZonaId == 1) // metropolitana
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (item.MesCarga == i)
                        {
                            metropolitana.Meses[i - 1] = Convert.ToInt32(item.Cargas).ToString();
                        }
                    }

                }else // fluminense
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (item.MesCarga == i)
                        {
                            fluminense.Meses[i - 1] = Convert.ToInt32(item.Cargas).ToString();
                        }
                    }
                }
            }
            #endregion

            metropolitana.Trim1 = cargas.Where(c => c.Zona =="METROPOLITANA").Select(c => c.Cargas).Take(3).Sum();
            metropolitana.Trim2 = cargas.Where(c => c.Zona =="METROPOLITANA").Select(c => c.Cargas).Skip(3).Take(3).Sum();
            metropolitana.Trim3 = cargas.Where(c => c.Zona =="METROPOLITANA").Select(c => c.Cargas).Skip(6).Take(3).Sum();
            metropolitana.Trim4 = cargas.Where(c => c.Zona == "METROPOLITANA").Select(c => c.Cargas).Skip(9).Take(3).Sum();

            fluminense.Trim1 = cargas.Where(c => c.Zona == "FLUMINENSE").Select(c => c.Cargas).Take(3).Sum();
            fluminense.Trim2 = cargas.Where(c => c.Zona == "FLUMINENSE").Select(c => c.Cargas).Skip(3).Take(3).Sum();
            fluminense.Trim3 = cargas.Where(c => c.Zona == "FLUMINENSE").Select(c => c.Cargas).Skip(6).Take(3).Sum();
            fluminense.Trim4 = cargas.Where(c => c.Zona == "FLUMINENSE").Select(c => c.Cargas).Skip(9).Take(3).Sum();

            //caso não tenha as colunas todas de meses preenchidos
            metropolitana.AcrescentaMesesQueFaltam();
            fluminense.AcrescentaMesesQueFaltam();

            metropolitana.Zona = "Metropolitana";
            fluminense.Zona = "Fluminense";
            total.Zona = "Total";

            metropolitana.Anual = metropolitana.Trim1 + metropolitana.Trim2 +
            metropolitana.Trim3 + metropolitana.Trim4;

            fluminense.Anual = fluminense.Trim1 + fluminense.Trim2 +
            fluminense.Trim3 + fluminense.Trim4;


            //Retirando os zeros
            for (int i = 0; i < 12; i++)
            {
                if (metropolitana.Meses[i] == "0")
                    metropolitana.Meses[i] = "";

                if (fluminense.Meses[i] == "0")
                    fluminense.Meses[i] = "";
                
            }

            //caso o cliente tenha Zona 
            int? zonaCliente = HttpContext.Session.GetInt32("Zona");
            if (zonaCliente !=null  && (zonaCliente == metropolitana.Id))
            {
                resultados.Add(metropolitana);
            }
            else if (zonaCliente != null && (zonaCliente == fluminense.Id))
            {
                resultados.Add(fluminense);
            }else
            {
                resultados.Add(fluminense);
                resultados.Add(metropolitana);

                for (int i = 0; i <= 11; i++)
                {
                    total.Meses[i] = (Convert.ToInt32( (fluminense.Meses[i]=="")?"0": fluminense.Meses[i]) + Convert.ToInt32( (metropolitana.Meses[i] =="")?"0": metropolitana.Meses[i]) ).ToString();
                }
                total.Trim1 = fluminense.Trim1 + metropolitana.Trim1;
                total.Trim2 = fluminense.Trim2 + metropolitana.Trim2;
                total.Trim3 = fluminense.Trim3 + metropolitana.Trim3;
                total.Trim4 = fluminense.Trim4 + metropolitana.Trim4;
                total.Anual = fluminense.Anual + metropolitana.Anual;

                for (int i = 0; i < 12; i++)
                {
                    if (total.Meses[i] == "0")
                        total.Meses[i] = "";
                }

                resultados.Add(total);
            }

            return resultados;
        }
    }
}
