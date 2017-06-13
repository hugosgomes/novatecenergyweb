using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Services
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
        IActionResult GetRejeicao();
    }
}
