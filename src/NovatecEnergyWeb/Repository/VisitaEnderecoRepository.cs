using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovatecEnergyWeb.Core;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Domain.Interfaces.Repository;

namespace NovatecEnergyWeb.Repository
{
    public class VisitaEnderecoRepository : IVisitaEnderecoRepository
    {

        private BDNVTContext _context;

        public VisitaEnderecoRepository(BDNVTContext context)
        {
            _context = context;
        }

        public IEnumerable<VisitaEndereco> VisitasEnderecoFiltro(int zonas, int delegacao, int area, int lotes)
        {

            List<VisitaEndereco> visitas = _context.VisitaEndereco.FromSql(" exec [dbo].[sp_12_Visita_Endereco] ").ToList();


            // filtro area
            if (lotes == 0)
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

                    IEnumerable<VisitaEndereco> filtro = visitas.Where(c => c.Zid == zonas);

                    //paginacao retorna n linhas por pagina
                    /* vis2 = filtro.Skip(pagina)
                               .Take(itensPagina);*/

                    return (filtro);


                }
            }
            else
            {

                IEnumerable<VisitaEndereco> filtro = visitas.Where(c => c.Did == delegacao);

                //paginacao retorna n linhas por pagina
                /*vis2 = filtro.Skip(pagina)
                           .Take(itensPagina);*/

                return (filtro);


            }

            }
            else
            {

                IEnumerable<VisitaEndereco> filtro = visitas.Where(c => c.Aid == area);

                //paginacao retorna n linhas por pagina
                /*vis2 = filtro.Skip(pagina)
                           .Take(itensPagina);*/

                return (filtro);


            }

            }
            else
            {

                IEnumerable<VisitaEndereco> filtro = visitas.Where(c => c.IdLote == lotes);

                //paginacao retorna n linhas por pagina
                /*vis2 = filtro.Skip(pagina)
                           .Take(itensPagina);*/

                return (filtro);


            }

        }
    }
}
