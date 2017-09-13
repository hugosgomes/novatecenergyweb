using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IVisitaPcoRepository
    {
        IEnumerable<VisitaPco> GetVisitaPco();
        IEnumerable<VisitaPco> AplicaFiltro(VisitaPcoViewModel visitaViewModel, IEnumerable<VisitaPco> visitasPcoLista);
    }
}
