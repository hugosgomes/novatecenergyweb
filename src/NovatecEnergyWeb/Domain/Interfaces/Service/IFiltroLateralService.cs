using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Service
{
    public interface IFiltroLateralService
    {
        IActionResult ZonaCascade(int zona);
        IActionResult DelegacaoCascade(int delegacao);
        IActionResult AreaCascade(int lote);
        IActionResult GetZonas();
        IActionResult GetDelegacao();
        IActionResult GetArea();
        IActionResult GetLotes();
        IActionResult GetCampoVenda();
        IActionResult GetD1D2();
        IActionResult GetTipoVisita();
        IActionResult GetRejeicao();
        IActionResult GetAgenteComercial();
        IActionResult GetStatusCond();
        IActionResult GetCondominio();
        IActionResult GetVisitado();
        IActionResult GetInteresse();
        IActionResult GetPco();
        IActionResult GetTarifa();
        IActionResult GetStatus();
    }
}
