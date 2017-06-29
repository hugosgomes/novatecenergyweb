using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;

namespace NovatecEnergyWeb.Models.Repository
{
    public class VisitasRepository : IVisitasRepository
    {


        private BDNVTContext _context;

        public VisitasRepository(BDNVTContext context)
        {
            _context = context;
        }


        public List<Visitas> GetVisitasByLote()
        {
            var visitas = _context.Visitas.FromSql(" exec [dbo].[CondVisitas] ").ToList();
            return visitas;
        }

        public IEnumerable<Visitas> GetVisitasFiltro( int zonas, int delegacao, int area, int condominio)
        {
            var visitas = _context.Visitas.FromSql(" exec [dbo].[CondVisitas] ").ToList();
           

            // filtro condominio
            if (condominio == 0)
            {
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
                            IEnumerable<Visitas> filtro = visitas.Where(c => c.Zid == zonas);
                            
                                //paginacao retorna n linhas por pagina
                                /* vis2 = filtro.Skip(pagina)
                                           .Take(itensPagina);*/

                                return (filtro);
                          

                        }

                    }
                    else
                    {

                        IEnumerable<Visitas> filtro = visitas.Where(c => c.Did == delegacao);

                        //paginacao retorna n linhas por pagina
                        /*vis2 = filtro.Skip(pagina)
                                   .Take(itensPagina);*/

                        return (filtro);


                    }
                }
                else
                {

                    IEnumerable<Visitas> filtro = visitas.Where(c => c.Aid == area);

                    //paginacao retorna n linhas por pagina
                    /*vis2 = filtro.Skip(pagina)
                               .Take(itensPagina);*/

                    return (filtro);


                }
            }
            else
            {
                IEnumerable<Visitas> filtro = visitas.Where(c => c.Condid == condominio);

                //paginacao retorna n linhas por pagina
                 /*vis2 = filtro.Skip(pagina)
                           .Take(itensPagina);*/

                return (filtro);

            }
        }
    }
}
