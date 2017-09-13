using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Core;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.ViewModels.AdesaoViewModels;

namespace NovatecEnergyWeb.Repository
{
    public class VisitaPcoRepository : IVisitaPcoRepository
    {
        private BDNVTContext _context;

        public VisitaPcoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public IEnumerable<VisitaPco> GetVisitaPco()
        {
            var visitasPco = _context.VisitaPco.FromSql(" exec [dbo].[sp_13_Visitas_Pco] ")
                .Select(v => new VisitaPco
                {
                    Id = v.Id,
                    Z = v.Z,
                    D = v.D,
                    Ar = v.Ar,
                    Pco = v.Pco,
                    Complemento = v.Complemento,
                    NegativaId = v.NegativaId,
                    Num = v.Num,
                    DataHora = v.DataHora,
                    AgVisita = v.AgVisita,
                    Obs = v.Obs,
                    Latitude = v.Latitude,
                    Longitude = v.Longitude,
                    DataAgendamento = v.DataAgendamento,
                    StatusPco = v.StatusPco,
                    Localidade = v.Localidade,
                    Bairro = v.Bairro,
                    Via = v.Via,
                    Logradouro = v.Logradouro,
                    IdLote = v.IdLote,
                    Interesse = v.Interesse,
                    AgComercialId = v.AgComercialId,
                    ZId = v.ZId,
                    DId = v.DId,
                    AId = v.AId,
                    LogradouroB = v.LogradouroB,
                    LocalidadeB = v.LocalidadeB,
                    BairroB = v.BairroB,
                    PcoB = v.PcoB,
                    Negativa = v.Negativa,
                    ObsAgendamento = v.ObsAgendamento,
                    TipoVisitaId = v.TipoVisitaId

                }).ToList();
            return visitasPco;
        }

        /* Aplica filtros vindos da View de VisitaPco/Index.cshtml */
        public IEnumerable<VisitaPco> AplicaFiltro(VisitaPcoViewModel visitaViewModel, IEnumerable<VisitaPco> visitasPcoLista)
        {
            //refatorar esse código futuramente
            if (visitaViewModel.ZId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.ZId == visitaViewModel.ZId).ToList();
            }
            if (visitaViewModel.DId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.DId == visitaViewModel.DId).ToList();
            }
            if (visitaViewModel.AId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AId == visitaViewModel.AId).ToList();
            }
            if (visitaViewModel.IdLote != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.IdLote == visitaViewModel.IdLote).ToList();
            }
            if (visitaViewModel.Interesse != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.Interesse == visitaViewModel.Interesse).ToList();
            }
            if(visitaViewModel.TipoVisitaId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.TipoVisitaId == visitaViewModel.TipoVisitaId).ToList();
            }
            if (visitaViewModel.NegativaId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.NegativaId == visitaViewModel.NegativaId).ToList();
            }
            if (visitaViewModel.AgComercialId != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AgComercialId == visitaViewModel.AgComercialId).ToList();
            }
            if (visitaViewModel.Diavisita1 != null && visitaViewModel.Diavisita2 != null)
            {
                DateTime dt = Convert.ToDateTime(visitaViewModel.Diavisita1);
                DateTime dt2 = Convert.ToDateTime(visitaViewModel.Diavisita2);
                dt2 = dt2.AddHours(23);
                dt2 = dt2.AddMinutes(59); 

                visitasPcoLista = visitasPcoLista.Where(w => w.DataHora >= dt && w.DataHora <= dt2)
                    .ToList();
            }
            if (visitaViewModel.Bairro != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.BairroB.Contains(visitaViewModel.Bairro.ToUpper())).ToList();
            }
            if (visitaViewModel.Localidade != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.LocalidadeB.Contains(visitaViewModel.Localidade.ToUpper())).ToList();
            }
            if (visitaViewModel.Logradouro != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.LogradouroB.Contains(visitaViewModel.Logradouro.ToUpper())).ToList();
            }
            if (visitaViewModel.AgVisita != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.AgVisita.Contains(visitaViewModel.AgVisita)).ToList();
            }
            if (visitaViewModel.Pco != null)
            {
                visitasPcoLista = visitasPcoLista.Where(v => v.PcoB.Contains(visitaViewModel.Pco.ToUpper())).ToList();
            }
            if (visitaViewModel.Numero1 != 0 && visitaViewModel.Numero2 != 0)
            {
                visitasPcoLista = visitasPcoLista.Where(c => c.Num >= visitaViewModel.Numero1 && c.Num <= visitaViewModel.Numero2).OrderBy(c => c.Num).ToList();
            }

            return visitasPcoLista;
        }
    }
}
