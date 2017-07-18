using NovatecEnergyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Domain.Interfaces.Repository
{
    public interface IMotivoRejeicao
    {
        List<_11MotivosRej> GetMotivosProdutoSv();
    }
}
