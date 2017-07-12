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
        private IExcelExportVisitaEndereco _exportaExecelVisitaEndereco;

        public PcoController(BDNVTContext context,
            IMotivoRejeicao motivoRejeicaoRepository, IAreaRepository areaRepository,
           ICondominioLoteAtivo condominioRepository, ILoteRepository loteRepository, IExcelExportVisitaEndereco exportaExecelVisitaEndereco

           )

        {
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



    }
}
