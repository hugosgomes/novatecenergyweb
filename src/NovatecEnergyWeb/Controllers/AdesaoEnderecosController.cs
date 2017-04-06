using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.StoredProcedures;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class AdesaoEnderecosController : Controller
    {
        private BDNVTContext _context;

        public AdesaoEnderecosController(BDNVTContext context)
        {
            _context = context;
        }

        public void BindSelects()
        {
            var lotes = (from l in _context._11Lotes
                        join ti in _context._00TabelasItems on l.Status equals ti.Id
                        join ti2 in _context._00TabelasItems on l.Procedencia equals ti2.Id
                        select new
                        {
                            Id = l.Id,
                            LoteNum = l.LoteNum,
                            Ge = l.Ge,
                            DataLote = l.DataLote,
                            Tipo = ti2.Item,
                            Status = ti.Item
                        }).ToList();
            ViewBag.Lotes = new List<List<dynamic>>();
            foreach (var item in lotes)
            {
                var l = new List<dynamic>();
                l.Add(item.Id);
                l.Add(item.LoteNum);
                l.Add(item.Ge);
                l.Add(item.DataLote);
                l.Add(item.Tipo);
                l.Add(item.Status);
                ViewBag.Lotes.Add(l);
            }

            var zonas = _context._00Zona.Where(c => c.Id < 3).ToList();
            ViewBag.Zonas = new List<_00Zona>();
            ViewBag.Zonas = zonas;

            var delegacoes = _context._00Delegacao.ToList();
            ViewBag.Delegacao = new List<_00Delegação>();
            ViewBag.Delegacao = delegacoes;

            var areas = _context._00Areas.ToList();
            ViewBag.Areas = new List<_00Areas>();
            ViewBag.Areas = areas;
        }

        public IActionResult VisitasEnderecos()
        {
            BindSelects();

            var enderecos = _context._11_LoteAtivoEndereco.FromSql("exec [dbo].[11_LoteAtivoEnderecos]").ToList();
            return View("VisitasEnderecos", new List<_11_LoteAtivoEnderecos>());
        }



    }
}
