using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Controllers
{
    public class AdesaoController : Controller
    {
        private BDNVTContext _context;

        public AdesaoController(BDNVTContext context)
        {
            _context = context;
        }
        
        public IActionResult EnderecosVisitas()
        {
            var ev = _context._11_LoteAtivo.FromSql("exec [dbo].[11_LoteAtivo]").ToList();
            ViewBag.Visitados = ev.Sum(c => c.Visitado);
            ViewBag.VisitadosPercent = Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Visitados), Convert.ToDecimal(ev.Count())) *100);
            ViewBag.NaoVisitados = ev.Count() - ViewBag.Visitados;
            ViewBag.NaoVisitadosPercent = Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.NaoVisitados), Convert.ToDecimal(ev.Count())) * 100 );

            ViewBag.Contratados = ev.Sum(c => c.CasoC);
            ViewBag.ContratadosPercent = Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Contratados), Convert.ToDecimal(ev.Count())) * 100);
            ViewBag.NaoContratados = ev.Sum(c => c.CasoA);
            ViewBag.NaoContratadosPercent = Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.NaoContratados), Convert.ToDecimal(ev.Count())) * 100);
            ViewBag.VisitaAgendada = ev.Sum(c => c.CasoB);
            ViewBag.VisitaAgendadaPercent = Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.VisitaAgendada), Convert.ToDecimal(ev.Count())) * 100);

            ViewBag.Visitas = ev.Sum(c => c.Visitas);
            ViewBag.Ausentes = ev.Sum(c => c.Ausentes);
            ViewBag.VisitasComResposta = ViewBag.Visitas - ViewBag.Ausentes;
            ViewBag.VisitasComRespostaPercent = Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.VisitasComResposta), Convert.ToDecimal(ViewBag.Visitas)) * 100);
            ViewBag.AusentesPercent = Convert.ToInt32( decimal.Divide(Convert.ToDecimal(ViewBag.Ausentes), Convert.ToDecimal(ViewBag.Visitas)) * 100);

            return View(ev);
        }
    }
}
