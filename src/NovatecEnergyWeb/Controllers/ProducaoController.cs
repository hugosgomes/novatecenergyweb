using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.ProducaoViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class ProducaoController : Controller
    {
        public BDNVTContext _context;

        public ProducaoController(BDNVTContext context)
        {
            _context = context;
        }

        public IActionResult AvancoMes()
        {
            var _50_AvancoMes = _context._50_AvancoMes.FromSql("EXECUTE [dbo].[50_AvancoMes] {0}",2016).ToList() ;

            //Agrupa pela obra e dimensão(DM)
            var obrasGroupDM = _50_AvancoMes.GroupBy(x => new { x.Z, x.D, x.Obra, x.Natureza, x.Conta, x.DM, x.IdZona,
                x.IdDel, x.StatusId, x.Cod, x.ContaId, x.ContaId2 }).ToList();

            var listaAvancoMesViewModel = new List<AvancoMesViewModel>();

            foreach (var item in obrasGroupDM.ToList())
            {
                var avancoMesViewModel = new AvancoMesViewModel();
                avancoMesViewModel.Z = item.Key.Z;
                avancoMesViewModel.D = item.Key.D;
                avancoMesViewModel.Obra = item.Key.Obra;
                avancoMesViewModel.Natureza = item.Key.Natureza;
                avancoMesViewModel.DM = item.Key.DM;
                

                avancoMesViewModel.Meses = new List<string>() { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

                //Meses
                for (int i = 1; i <= 12; i++)
                {
                    avancoMesViewModel.Meses[i -1] = _50_AvancoMes
                    .Where(c => c.Cod == item.Key.Cod && c.DM == item.Key.DM && c.Mes == i)
                    .Select(c => c.Total).FirstOrDefault().ToString();
                }
                avancoMesViewModel.Total = Math.Round(avancoMesViewModel.Meses.Select(decimal.Parse).Sum());

                //Retirando os zeros
                for (int i = 0; i < 12; i++)
                {
                    if (avancoMesViewModel.Meses[i] == "0" || avancoMesViewModel.Meses[i] =="0,00")
                        avancoMesViewModel.Meses[i] = "";
                }
                for (int i = 0; i < 12; i++)
                {
                    if ((avancoMesViewModel.Meses[i] != "0") && (!String.IsNullOrEmpty(avancoMesViewModel.Meses[i])) )
                        avancoMesViewModel.Meses[i] = Math.Round(Convert.ToDecimal(avancoMesViewModel.Meses[i])).ToString();
                }
                listaAvancoMesViewModel.Add(avancoMesViewModel);
            }

            return View(listaAvancoMesViewModel);
        }
    }
}
