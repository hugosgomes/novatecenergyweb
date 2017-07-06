using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Models.Repository
{
    public class CondVisitasRepository : ICondVisitasRepository
    {


        private BDNVTContext _context;

        public CondVisitasRepository(BDNVTContext context)
        {
            _context = context;
        }


        public List<CondVisita> GetVisitasByLote()
        {
            var visitas = _context.CondVisita.FromSql(" exec [dbo].[CondVisitaSH] ").ToList();
            return visitas;
        }

        public IEnumerable<CondVisita> GetVisitasFiltro( int zonas, int delegacao, int area, int condominio)
        {
            var visitas = _context.CondVisita.FromSql(" exec [dbo].[CondVisitaSH] ").ToList();
           

           
                // filtro area
                if (area == 0)
                {

                    // filtro delegacao 
                    if (delegacao == 0)
                    {
                        //filtro zona 
                        if (zonas == 0)
                        {

                            //paginacao retorna n linhas por pagina
                           /* vis2 = visitas.Skip(pagina)
                                       .Take(itensPagina);*/

                            return (visitas);
                        }
                        else
                        {
                            IEnumerable<CondVisita> filtro = visitas.Where(c => c.Zid == zonas);
                            
                                //paginacao retorna n linhas por pagina
                                /* vis2 = filtro.Skip(pagina)
                                           .Take(itensPagina);*/

                                return (filtro);
                          

                        }

                    }
                    else
                    {

                        IEnumerable<CondVisita> filtro = visitas.Where(c => c.Did == delegacao);

                        //paginacao retorna n linhas por pagina
                        /*vis2 = filtro.Skip(pagina)
                                   .Take(itensPagina);*/

                        return (filtro);


                    }
                }
                else
                {

                    IEnumerable<CondVisita> filtro = visitas.Where(c => c.Aid == area);

                    //paginacao retorna n linhas por pagina
                    /*vis2 = filtro.Skip(pagina)
                               .Take(itensPagina);*/

                    return (filtro);


                }
            
          
        }
    }
}
