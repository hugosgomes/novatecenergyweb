﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Domain.Interfaces.Repository;

namespace NovatecEnergyWeb.Repository
{
    public class PcoRepository : IPcoRepository
    {
        private BDNVTContext _context;

        public PcoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public IEnumerable<Pco> GetPco()
        {
          var pco = _context.Pco.FromSql(" exec [dbo].[Pco] ").ToList();
            return pco;
        }
    }
}
