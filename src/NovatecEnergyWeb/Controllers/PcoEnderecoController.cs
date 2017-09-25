using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.AspNetCore.Http;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Domain.Interfaces;
using NovatecEnergyWeb.Filters.ActionFilters;

namespace NovatecEnergyWeb.Controllers
{
    public class PcoEnderecoController : Controller
    {
        private IVisitaEnderecoPcoRepository _visitaEnderecoPcoRepository;
        private ILotePcoRepository _lotePcoRepository;
        IExcelExporterLotePorClienteApartamento _exporter;
        private BDNVTContext _context;
        //private IExcelExportVisitaEndereco _exportaExecelVisitaEndereco;

        public PcoEnderecoController(IVisitaEnderecoPcoRepository visitaEnderecoPcoRepository, 
            ILotePcoRepository lotePcoRepository, BDNVTContext context, IExcelExporterLotePorClienteApartamento exporter)
        {
            _visitaEnderecoPcoRepository = visitaEnderecoPcoRepository;
            _lotePcoRepository = lotePcoRepository;
            _context = context;
            _exporter = exporter;
        }
        [AutenticacaoFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaPcoVisitasEndereco(int paginaClicada, int lote, int zona, int delegacao, int area, string bairro)
        {
            var d = HttpContext.Session.GetInt32("Delegação");
            var z = HttpContext.Session.GetInt32("Zona");
            var quantArea = HttpContext.Session.GetInt32("QuantidadeArea");

            if (quantArea != null && ((int)quantArea == 1))
            {
                area = (int)HttpContext.Session.GetInt32("Área");
            }

            // se for cliente, vai ter as variáveis de sessão preenchidas
            zona = (z != null) ? (int)z : zona;
            delegacao = (d != null) ? (int)d : delegacao;

            
            var visitas = _visitaEnderecoPcoRepository.VisitasPcoEndereco(zona, delegacao, area, lote,bairro);


            // definicoes da paginacao
            var pagina = 0;
            var itensPagina = 20;

            if (paginaClicada != 0)
            {
                pagina = (paginaClicada - 1) * itensPagina;
            }

         
            //Cálculos
            var Potencial = visitas.Sum(c => c.Potencial);

            var Tratados = visitas.Sum(c => c.Tratados);
            var TratadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Tratados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var naoTratados = Potencial - Tratados;
            var naoTratadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(naoTratados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var Visitas0 = visitas.Sum(c => c.Visitas0);
            var Visitas0Perc = (naoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitas0), Convert.ToDecimal(naoTratados)) * 100) : 0;

            var Visitas1 = visitas.Sum(c => c.Visitas1);
            var Visitas1Perc = (naoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitas1), Convert.ToDecimal(naoTratados)) * 100) : 0;

            var Visitas2 = visitas.Sum(c => c.Visitas2);
            var Visitas2Perc = (naoTratados != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitas2), Convert.ToDecimal(naoTratados)) * 100) : 0;

            var Visitados = visitas.Sum(c => c.Visitados);
            var VisitadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Visitados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var naoVisitados = Potencial - Visitados;
            var naoVisitadosPerc = (Potencial != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(naoVisitados), Convert.ToDecimal(Potencial)) * 100) : 0;

            var tEnderecos = visitas.Count();

            var Visitas = visitas.Sum(c => c.Visitas);

            var Entrevistas = visitas.Sum(c => c.Entrevistas);
            var EntrevistasPerc = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(Entrevistas), Convert.ToDecimal(Visitas)) * 100) : 0;

            var VisitasImpr = visitas.Sum(c => c.VisitasImpr);
            var VisitasImprPerc = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(VisitasImpr), Convert.ToDecimal(Visitas)) * 100) : 0;

            var VisitasAus = visitas.Sum(c => c.Ausencias);
            var VisitasAusPerc = (Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(VisitasAus), Convert.ToDecimal(Visitas)) * 100) : 0;

            var VisitasAge = visitas.Sum(c => c.VisitasAgendadas);

           

            var totalPaginas = (visitas.Count() != 0) ? Math.Ceiling(decimal.Divide(Convert.ToDecimal(visitas.Count()), itensPagina)) : 1;

            var vis2 = visitas.Skip(pagina).Take(itensPagina);

            dynamic jsonModel = new ExpandoObject();
            jsonModel.vis = vis2;
            jsonModel.Numeracoes = new List<dynamic>();
            jsonModel.Porcentagens = new List<dynamic>();
            jsonModel.totalPag = totalPaginas;
            jsonModel.Numeracoes.Add(Potencial);
            jsonModel.Numeracoes.Add(Tratados);
            jsonModel.Porcentagens.Add(TratadosPerc);
            jsonModel.Numeracoes.Add(naoTratados);
            jsonModel.Porcentagens.Add(naoTratadosPerc);
            jsonModel.Numeracoes.Add(Visitas0);
            jsonModel.Porcentagens.Add(Visitas0Perc);
            jsonModel.Numeracoes.Add(Visitas1);
            jsonModel.Porcentagens.Add(Visitas1Perc);
            jsonModel.Numeracoes.Add(Visitas2);
            jsonModel.Porcentagens.Add(Visitas2Perc);
            jsonModel.Numeracoes.Add(Visitados);
            jsonModel.Porcentagens.Add(VisitadosPerc);
            jsonModel.Numeracoes.Add(naoVisitados);
            jsonModel.Porcentagens.Add(naoVisitadosPerc);
            jsonModel.Numeracoes.Add(tEnderecos);
            jsonModel.Numeracoes.Add(Visitas);
            jsonModel.Numeracoes.Add(Entrevistas);
            jsonModel.Porcentagens.Add(EntrevistasPerc);
            jsonModel.Numeracoes.Add(VisitasImpr);
            jsonModel.Porcentagens.Add(VisitasImprPerc);
            jsonModel.Numeracoes.Add(VisitasAus);
            jsonModel.Porcentagens.Add(VisitasAusPerc);
            jsonModel.Numeracoes.Add(VisitasAge);

            return Json(jsonModel);
        }

        public IActionResult ExportaAgendaAdesao(int lote, int zona, int delegacao, int area, string bairro, string ano, string mes )
        {
            
            var visitasEndereco = _visitaEnderecoPcoRepository.VisitasPcoEndereco(zona, delegacao, area, lote, bairro).ToList();

            //mudar isso para um repositório depois
            var dataExporta = _context._PcoEndereco_ExportaAgendaAdesao
                .FromSql("exec [dbo].[sp_13_Visita_Endereco_ExportaAgendaAdesao] ");

            if (!String.IsNullOrEmpty(ano))
            {
                dataExporta = dataExporta.Where(d => d.Datah.Year == Convert.ToInt32(ano));
            }

            if (!String.IsNullOrEmpty(mes))
            {
                dataExporta = dataExporta.Where(d => d.Datah.Month == Convert.ToInt32(mes));
            }

            var loteEscolhido = _lotePcoRepository.GetLotesById(lote).FirstOrDefault();

            byte[] fileBytes =  _exporter.ExportaAgendaEnderecoPco(visitasEndereco, dataExporta.ToList(),
                loteEscolhido, mes, ano);

            return File(fileBytes, "application/x-msdownload", _exporter.FileName);
        } 


    }
}
