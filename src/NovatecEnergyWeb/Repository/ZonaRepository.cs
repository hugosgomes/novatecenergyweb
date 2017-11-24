using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Domain.Interfaces.Repository;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Core;

namespace NovatecEnergyWeb.Repository
{
    public class ZonaRepository : IZonaRepository
    {
        private BDNVTContext context;

        public ZonaRepository(BDNVTContext context)
        {
            this.context = context;
        }

        public _00Zona GetZonaByLote(int idLote)
        {
            var zona = from z in context._00Zona
                       join d in context._00Delegacao on z.Id equals d.Zona
                       join a in context._00Areas on d.Id equals a.Delegacao
                       join l in context._13Lotes on a._13Lotes.FirstOrDefault().Id equals l.Id
                       where l.Id == idLote
                       select z;

            return zona.FirstOrDefault();
                       
        }
    }
}
