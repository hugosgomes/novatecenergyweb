using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IZonaRepository
    {
        _00Zona GetZonaByLote(int idLote);
    }
}
