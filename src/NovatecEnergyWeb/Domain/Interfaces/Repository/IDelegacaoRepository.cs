﻿using NovatecEnergyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IDelegacaoRepository
    {
        List<int> GetDelegacaoIdsByZona(int zona);
        List<_00Delegação> GetDelegacaoByZonaId(int zona);
    }
}
