using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models;
using System.Dynamic;

namespace NovatecEnergyWeb.Services
{
    public class FiltroCascataServiceController : Controller, IFiltroService
    {
        private BDNVTContext _context;

        public FiltroCascataServiceController(BDNVTContext context)
        {
            _context = context;
        }

        public IActionResult AreaCascade(int lote)
        {
            throw new NotImplementedException();
        }

        public IActionResult DelegacaoCascade(int delegacao)
        {
            //area
            var AreasL = _context._00Areas.Where(c => c.Delegacao == delegacao).ToList();
            var listAreaInt = new List<int>();
            foreach (var item in AreasL)
            {
                listAreaInt.Add(item.Id);
            }

            dynamic retorno = new ExpandoObject();
            retorno.area = AreasL;

            return Json(retorno);
        }

        public IActionResult ZonaCascade(int zona)
        {
            //delegacao
            var delegacao = _context._00Delegacao.Where(c => c.Zona == zona)
                .Select(c => new _00Delegação { Id = c.Id, Delegacao = c.Delegacao, Zona = c.Zona })
            .ToList();

            var listint = new List<int>();
            foreach (var item in delegacao)
            {
                listint.Add(item.Id);
            }

            //area
            var areasL = _context._00Areas.Where(x => listint.Contains(Convert.ToInt32(x.Delegacao))).ToList();

            //lotes 
            var listAreaInt = new List<int>();
            foreach (var item in areasL)
            {
                listAreaInt.Add(item.Id);
            }

            dynamic retorno = new ExpandoObject();
            retorno.delegacao = delegacao;
            retorno.area = areasL;
            

            return Json(retorno);
        }
    }
}
