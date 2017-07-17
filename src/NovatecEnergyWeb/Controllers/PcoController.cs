using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.Exportacao;
using NovatecEnergyWeb.Models.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
namespace NovatecEnergyWeb.Controllers
{
    public class PcoController : Controller
    {
        private BDNVTContext _context;
      
       
        private IAreaRepository _areaRepository;
        private ILoteRepository _loteRepository;
        private ICondominioLoteAtivo _condominioRepository;
        private IMotivoRejeicao _motivoRejeicaoRepository;
        private IPcoRepository _pcoRepository;
        private IExcelExportVisitaEndereco _exportaExecelVisitaEndereco;

        public PcoController(BDNVTContext context, IPcoRepository pcoRepository,
            IMotivoRejeicao motivoRejeicaoRepository, IAreaRepository areaRepository,
           ICondominioLoteAtivo condominioRepository, ILoteRepository loteRepository,
           IExcelExportVisitaEndereco exportaExecelVisitaEndereco

           )

        {
            _pcoRepository = pcoRepository;
            _context = context;        
            _motivoRejeicaoRepository = motivoRejeicaoRepository;
            _areaRepository = areaRepository;
            _loteRepository = loteRepository;
            _condominioRepository = condominioRepository;
            _exportaExecelVisitaEndereco = exportaExecelVisitaEndereco;

        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetPco(int num, int zona, int status, int delegacao, String localidade,
            String bairro, String logradouro, String pcoDes)
        {

            var pagina = 0;
            var PaginaClicada = num;
            var itensPagina = 20;

            if (PaginaClicada != 0)
            {
                pagina = (PaginaClicada - 1) * itensPagina;
            }

            var pco = _pcoRepository.GetPco();


            // filtra as seguintes colunas
            if (zona != 0)
            {

                pco = pco.Where(c => c.IdZona == zona);
            }

            if (delegacao != 0)
            {
                 pco = pco.Where(c => c.IdDel == delegacao);
            }

            if (status != 0)
            {

                pco = pco.Where(c => c.Statu == status);
            }

            if (localidade != null)
            {

                pco = pco.Where(c => c.Localidade.Contains(localidade));

            }

            if (bairro != null)
            {

                pco = pco.Where(c => c.Bairro.Contains(bairro));

            }

            if (logradouro != null)
            {

                pco = pco.Where(c => c.LogDesc.Contains(logradouro));

            }

            /*
            if (pcoDes != null)
            {

                pco = pco.Where(c => c.Pco.Contains(pcoDes));

            }*/


            var totalPaginas = pco.Count() / itensPagina + 1; // retorna numero de paginas nescessario

            var pcos = pco.Skip(pagina)
                          .Take(itensPagina);

            dynamic jsonModel = new ExpandoObject();

           jsonModel.pcoList = pcos;
           jsonModel.totalPag = totalPaginas;




            return Json(jsonModel);

        }


    }
}
