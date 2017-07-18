using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.AdesaoViewModels;
using NovatecEnergyWeb.Filters.ActionFilters;
using NovatecEnergyWeb.Domain.Interfaces.Repository;



namespace NovatecEnergyWeb.Controllers
{
    public class CondEstatisticaController : Controller
    {


        private BDNVTContext _context;
        private ICondEstatisticaRepository _condEstatisticaRepository;
        private ILoteRepository _loteRepository;
        private IAreaRepository _areaRepository;
        private IDelegacaoRepository _delegacaoRepository;

        public CondEstatisticaController(BDNVTContext context,
            ICondEstatisticaRepository condEstatisticaRepository, ILoteRepository loteRepository,
            IAreaRepository areaRepository, IDelegacaoRepository delegacaoRepository)
        {
            _context = context;
            _condEstatisticaRepository = condEstatisticaRepository;
            _loteRepository = loteRepository;
            _areaRepository = areaRepository;
            _delegacaoRepository = delegacaoRepository;
        }


        [HttpGet]
        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuscaEstatistica(int idLote)
        {
            return Json(_condEstatisticaRepository.GetLoteEstatisticaByLote(idLote));
        }

        [HttpGet]
        public IActionResult BuscaLotes(int zonas, int delegacao, int area)
        {

            var dd = HttpContext.Session.GetInt32("Delegação");
            var zz = HttpContext.Session.GetInt32("Zona");
            var quantArea = HttpContext.Session.GetInt32("QuantidadeArea");

            if (quantArea!=null &&((int)quantArea == 1))
            {
                area = (int)HttpContext.Session.GetInt32("Área");
            }


            // se for cliente, vai ter as variáveis de sessão preenchidas
            zonas = (zz != null) ? (int)zz : zonas;
            delegacao = (dd != null) ? (int)dd : delegacao;

            var Lotes = new List<List<dynamic>>();

            //.Where(l => l.Status == 136).ToList();
            var lotes = (from l in _context._12Lotes
                         join a in _context._00Areas on l.Area equals a.Id
                         join d in _context._00Delegacao on (int)a.Delegacao equals d.Id
                         join z in _context._00Zona on d.Zona equals z.Id
                         where l.Status == 136 
                           select new
                           {
                               IdLote = l.Id,
                               Lote = l.LoteNum,
                               Z = z.Z,
                               Zid = z.Id,
                               D = d.D,
                               Did = d.Id,
                               Ar = a.Area,
                               Arid = a.Id

                           }).ToList();


            // filtro area
            if (area != 0)
            {

                var resultados = lotes.Where(c => c.Arid == area);

             
                foreach (var item in resultados)
                {
                    var d = new List<dynamic>();
                    d.Add(item.IdLote);
                    d.Add(item.Lote);
                    d.Add(item.Z);
                    d.Add(item.D);
                    d.Add(item.Ar);
                    Lotes.Add(d);
                }



                return Json(Lotes);

            }
            else {

                // filtro delegacao 
                if (delegacao != 0)
                {
                    var resultados = lotes.Where(c => c.Did == delegacao);

                 
                    foreach (var item in resultados)
                    {
                        var d = new List<dynamic>();
                        d.Add(item.IdLote);
                        d.Add(item.Lote);
                        d.Add(item.Z);
                        d.Add(item.D);
                        d.Add(item.Ar);
                        Lotes.Add(d);
                    }



                    return Json(Lotes);

                }
                else
                {

                    //filtro zona 
                    if (zonas != 0)
                    {
                        var resultados = lotes.Where(c => c.Zid == zonas);

                    
                        foreach (var item in resultados)
                        {
                            var d = new List<dynamic>();
                            d.Add(item.IdLote);
                            d.Add(item.Lote);
                            d.Add(item.Z);
                            d.Add(item.D);
                            d.Add(item.Ar);
                            Lotes.Add(d);
                        }



                        return Json(Lotes);
                    }


                }


            }

        
            foreach (var item in lotes)
            {
                var d = new List<dynamic>();
                d.Add(item.IdLote);
                d.Add(item.Lote);
                d.Add(item.Z);
                d.Add(item.D);
                d.Add(item.Ar);
                Lotes.Add(d);
            }



            return Json(Lotes);

        }


       




}
}
