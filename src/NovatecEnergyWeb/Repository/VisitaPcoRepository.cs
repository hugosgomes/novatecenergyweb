using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models.StoredProcedures;
using NovatecEnergyWeb.Core;
using Microsoft.EntityFrameworkCore;

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
                    PcoB = v.PcoB

                }).ToList();
            return visitasPco;
        }
    }
}
