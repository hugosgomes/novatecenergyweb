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
            var _50Croquis = _context._50Croquis.GroupBy(c => new { c.Data.Year }).ToList() ;
            var _50ProjetosStatus = _context._50ProjetoStatus.GroupBy(p => new { p.Id, p.Nome }).ToList();
            var _50CroquiCentroC = _context._50CroquiCentroContabil.Select(o => new { o.Id, o.Nome }).ToList();
            var _00Zona = _context._00Zona.Select(z => new { z.Id, z.Zona }).ToList();
            var _00Delegacao = _context._00Delegação.Select(d => new { d.Id, d.Delegacao }).ToList();

            //dropdown anos
            ViewBag.ListaAnos = new List<Int64>();
            foreach (var item in _50Croquis)
            {
                ViewBag.ListaAnos.Add(item.Key.Year);
            }

            //dropdown status
            ViewBag.ListaStatus = new List<_50ProjetoStatus>();
            foreach (var item in _50ProjetosStatus)
            {
                var status = new _50ProjetoStatus();
                status.Id = item.Key.Id;
                status.Nome = item.Key.Nome;
                ViewBag.ListaStatus.Add(status);
            }

            //dropdown tipo conta
            ViewBag.ListaTipoConta = new List<_50CroquiCentroContabil>();
            foreach (var item in _50CroquiCentroC)
            {
                var centroContabil = new _50CroquiCentroContabil();
                centroContabil.Id = item.Id;
                centroContabil.Nome = item.Nome;
                ViewBag.ListaTipoConta.Add(centroContabil);
            }


            //dropdown zona
            ViewBag.ListaZona = new List<_00Zona>();
            foreach (var item in _00Zona)
            {
                var zona = new _00Zona();
                zona.Id = item.Id;
                zona.Zona = item.Zona;
                ViewBag.ListaZona.Add(zona);
            }

            ViewBag.ListaDelegacao = new List<_00Delegação>();
            foreach (var item in _00Delegacao)
            {
                var delegacao = new _00Delegação();
                delegacao.Id = item.Id;
                delegacao.Delegacao = item.Delegacao;
                ViewBag.ListaDelegacao.Add(delegacao);
            }


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
