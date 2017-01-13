using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Filters.ActionFilters;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.MetasViewModels;

namespace NovatecEnergyWeb.Controllers
{
    public class MetasController : Controller
    {

        private BDNVTContext _context;

        public MetasController(BDNVTContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            var metasCargas = _context._10_MetasCargas.FromSql("EXECUTE [dbo].[10_MetasCargas]").Where(c => c.Ano == 2015).ToList();

            var fluminense = new ResultadosViewModel();
            var metropolitana = new ResultadosViewModel();

            metropolitana.Meses = new List<int>();
            fluminense.Meses = new List<int>();

            List<ResultadosViewModel>resultados = new List<ResultadosViewModel>();

            foreach (var item in metasCargas)
            {
                if (item.ZonaId == 1)
                {

                    if (item.Mes == 1 || item.Mes == 2 || item.Mes == 3)
                    {
                        metropolitana.Trim1 = metropolitana.Trim1 + Convert.ToInt32( item.Res);
                    }
                    if (item.Mes == 4 || item.Mes == 5 || item.Mes == 6)
                    {
                        metropolitana.Trim2 = metropolitana.Trim2 + Convert.ToInt32(item.Res);
                    }
                    if (item.Mes == 7 || item.Mes == 8 || item.Mes == 9)
                    {
                        metropolitana.Trim3 = metropolitana.Trim3 + Convert.ToInt32(item.Res);
                    }
                    if (item.Mes == 10 || item.Mes == 11 || item.Mes == 12)
                    {
                        metropolitana.Trim4 = metropolitana.Trim4 + Convert.ToInt32(item.Res);
                    }
                    metropolitana.Meses.Add(Convert.ToInt32(item.Res));
                }
                else
                {
                    if (item.Mes == 1 || item.Mes == 2 || item.Mes == 3)
                    {
                        fluminense.Trim1 = fluminense.Trim1 + Convert.ToInt32(item.Res);
                    }
                    if (item.Mes == 4 || item.Mes == 5 || item.Mes == 6)
                    {
                        fluminense.Trim2 = fluminense.Trim2 + Convert.ToInt32(item.Res);
                    }
                    if (item.Mes == 7 || item.Mes == 8 || item.Mes == 9)
                    {
                        fluminense.Trim3 = fluminense.Trim3 + Convert.ToInt32(item.Res);
                    }
                    if (item.Mes == 10 || item.Mes == 11 || item.Mes == 12)
                    {
                        fluminense.Trim4 = fluminense.Trim4 + Convert.ToInt32(item.Res);
                    }

                    fluminense.Meses.Add(Convert.ToInt32(item.Res));
                }
            }

            metropolitana.Zona = "Metropolitana";
            metropolitana.Anual = metropolitana.Trim1 + metropolitana.Trim2 +
            metropolitana.Trim3 + metropolitana.Trim4;

            fluminense.Zona = "Fluminense";
            fluminense.Anual = fluminense.Trim1 + fluminense.Trim2 +
            fluminense.Trim3 + fluminense.Trim4;

            resultados.Add(fluminense);
            resultados.Add(metropolitana);

            return View(resultados);
        }
    }
}
