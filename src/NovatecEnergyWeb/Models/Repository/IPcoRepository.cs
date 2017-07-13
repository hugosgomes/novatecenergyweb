using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;

namespace NovatecEnergyWeb.Models.Repository
{
    public interface IPcoRepository
    {
        List<Pco> GetPco();
    }
}
