using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Models.StoredProcedures;

namespace NovatecEnergyWeb.Models.Repository
{
    public class CondominioLoteAtivoRepository : ICondominioLoteAtivo
    {
        private BDNVTContext _context;

        public CondominioLoteAtivoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public List<_11_LoteAtivos_Condominios> GetCondominios(List<int> areas, int area, int status)
        {
            List<_11_LoteAtivos_Condominios> condominio;
            if (status == 0)
            {
                condominio = (from c in _context._11Condominios
                              join lo in _context._00Logradouro on c.Logradouro equals lo.Id
                              join ba in _context._00Bairro on lo.Bairro equals ba.Id
                              join ar in _context._00Areas on ba.Area equals ar.Id
                              join de in _context._00Delegacao on ar.Delegacao equals de.Id
                              join zo in _context._00Zona on de.Zona equals zo.Id
                              join ti in _context._00TabelasItems on c.Status equals ti.Id
                              where (area != 0) ? ba.Area == area : areas.Contains(Convert.ToInt32(ba.Area))
                              && ti.Campo == "STATUS" && ti.Tabela == 237 && ti.Id != 25
                              orderby ti.Ordem, zo.Id, de.Id, c.Nome ascending
                              select new _11_LoteAtivos_Condominios
                              {
                                  Id = c.Id,
                                  Nome = c.Nome,
                                  Num = c.Num,
                                  Complemento = c.Complemento,
                                  Item = ti.Item,
                                  Z = zo.Z,
                                  D = de.D
                              }).ToList();
            }
            else
            {

                condominio = (from c in _context._11Condominios
                              join lo in _context._00Logradouro on c.Logradouro equals lo.Id
                              join ba in _context._00Bairro on lo.Bairro equals ba.Id
                              join ar in _context._00Areas on ba.Area equals ar.Id
                              join de in _context._00Delegacao on ar.Delegacao equals de.Id
                              join zo in _context._00Zona on de.Zona equals zo.Id
                              join ti in _context._00TabelasItems on c.Status equals ti.Id
                              where (area != 0) ? ba.Area == area : areas.Contains(Convert.ToInt32(ba.Area))
                              && ti.Campo == "STATUS" && ti.Tabela == 237 //&& ti.Id != 25
                              && ti.Id == status
                              orderby ti.Ordem, zo.Id, de.Id, c.Nome ascending
                              select new _11_LoteAtivos_Condominios
                              {
                                  Id = c.Id,
                                  Nome = c.Nome,
                                  Num = c.Num,
                                  Complemento = c.Complemento,
                                  Item = ti.Item,
                                  Z = zo.Z,
                                  D = de.D
                              }).ToList();
            }


            return condominio;
        }

        
    }
}
