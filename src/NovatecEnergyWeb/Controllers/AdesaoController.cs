using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using NovatecEnergyWeb.Models.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.AdesaoViewModels;
using System.Dynamic;
namespace NovatecEnergyWeb.Controllers
{
    public class AdesaoController : Controller
    {
        private BDNVTContext _context;

        public AdesaoController(BDNVTContext context)
        {
            _context = context;
        }
        
        public IActionResult EnderecosVisitas()
        {
            var lotes = (from l in _context._11Lotes
                        join ti in _context._00TabelasItems on l.Status equals ti.Id
                        select new
                        {
                            Id = l.Id,
                            LoteNum = l.LoteNum,
                            Ge = l.Ge,
                            DataLote = l.DataLote,
                            Item = ti.Item
                        }).ToList();

            ViewBag.Lotes = new List<List<dynamic>>();
            foreach (var item in lotes)
            {
                var d = new List<dynamic>();
                d.Add(item.Id);
                d.Add(item.LoteNum);
                d.Add(item.Ge);
                d.Add(item.DataLote.GetValueOrDefault().ToString("dd/MM/yyyy"));
                d.Add(item.Item);
                ViewBag.Lotes.Add(d);
            }
         //   ViewBag.Lotes = lotes.ToList(); // terminar depois

            var motivosRejeicao = _context._11MotivosRej.Select(c => new { c.Id, c.Motivo }).ToList();
            ViewBag.MotivosRejeicao = new List<_11MotivosRej>();
            foreach (var item in motivosRejeicao)
            {
                var m = new _11MotivosRej();
                m.Id = item.Id;
                m.Motivo = item.Motivo;
                ViewBag.MotivosRejeicao.Add(m);
            }

            var zonas = _context._00Zona.Where(c => c.Id < 3).Select(c => new { c.Id, c.Zona }).ToList();
            ViewBag.Zonas = new List<_00Zona>();
            foreach (var item in zonas)
            {
                var z = new _00Zona();
                z.Id = item.Id;
                z.Zona = item.Zona;
                ViewBag.Zonas.Add(z);
            }

            var delegacao = _context._00Delegacao.Select(c => new { c.Id, c.Delegacao, c.Zona }).ToList();
            ViewBag.Delegacao = new List<_00Delegação>();
            foreach (var item in delegacao)
            {
                var d = new _00Delegação();
                d.Id = item.Id;
                d.Delegacao = item.Delegacao;
                d.Zona = item.Zona;
                ViewBag.Delegacao.Add(d);
            }

            var areas = _context._00Areas.Select(c => new { c.Id, c.Area }).ToList();
            ViewBag.Areas = new List<_00Areas>();
            foreach (var item in areas)
            {
                var a = new _00Areas();
                a.Id = item.Id;
                a.Area = item.Area;
                ViewBag.Areas.Add(a);
            }

            var statusCondominio = _context._00TabelasItems
                .Where(c => (c.Tabela == 237) && (c.Campo == "STATUS"))
                .OrderBy(c => c.Ordem)
                .Select(c => new { c.Id, c.Item }).ToList();
            ViewBag.StatusCondominios = new List<_00TabelasItems>();
            foreach (var item in statusCondominio)
            {
                var sc = new _00TabelasItems();
                sc.Id = item.Id;
                sc.Item = item.Item;
                ViewBag.StatusCondominios.Add(sc);
            }


            var listCond = _context._11_LoteAtivo_Condominios.FromSql("exec [dbo].[11_LoteAtivo_Condominios]").ToList();
            ViewBag.ListaCondominios = new List<_11_LoteAtivos_Condominios>();
            foreach (var item in listCond)
            {
                var c = new _11_LoteAtivos_Condominios();
                c.Id = item.Id;
                c.Nome = item.Nome;
                c.Num = item.Num;
                c.Complemento = item.Complemento;
                c.Item = item.Item;
                c.Z = item.Z;
                c.D = item.D;
                ViewBag.ListaCondominios.Add(c);
            } 
                

            return GetListLoteAtivo(null, true);
        }

        public IActionResult GetListLoteAtivo([FromForm]FormFiltersViewModels loteAtivo, bool eIndex)
        {
            IQueryable<_11_LoteAtivo> ev;
            if (loteAtivo == null)
            {
                ev = _context._11_LoteAtivo.FromSql("exec [dbo].[11_LoteAtivo2] ");
            }else
            {
                ev = _context._11_LoteAtivo.FromSql("exec [dbo].[11_LoteAtivo2] {0},{1},{2},{3},{4},{5},"+
                     "{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}",
                    loteAtivo.IdLote, loteAtivo.CasaStatus, loteAtivo.IdultMotivo, loteAtivo.Dtult,
                    loteAtivo.ClId, loteAtivo.ZId, loteAtivo.DId, loteAtivo.AId, loteAtivo.StatusId,
                    loteAtivo.CondId, loteAtivo.CondNome,loteAtivo.Localidade, loteAtivo.Bairro,
                    loteAtivo.Logradouro, loteAtivo.Numero1,loteAtivo.Numero2);
            }
            var evList = ev.ToList();

            ViewBag.Visitados = evList.Sum(c => c.Visitado);
            ViewBag.VisitadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Visitados), Convert.ToDecimal(evList.Count())) * 100):0;
            ViewBag.NaoVisitados = evList.Count() - ViewBag.Visitados;
            ViewBag.NaoVisitadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.NaoVisitados), Convert.ToDecimal(evList.Count())) * 100):0;

            ViewBag.Contratados = evList.Sum(c => c.CasoC);
            ViewBag.ContratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Contratados), Convert.ToDecimal(evList.Count())) * 100):0;
            ViewBag.NaoContratados = evList.Sum(c => c.CasoA);
            ViewBag.NaoContratadosPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.NaoContratados), Convert.ToDecimal(evList.Count())) * 100):0;
            ViewBag.VisitaAgendada = evList.Sum(c => c.CasoB);
            ViewBag.VisitaAgendadaPercent = (evList.Count() != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.VisitaAgendada), Convert.ToDecimal(evList.Count())) * 100):0;

            ViewBag.Visitas = evList.Sum(c => c.Visitas);
            ViewBag.Ausentes = evList.Sum(c => c.Ausentes);
            ViewBag.VisitasComResposta = ViewBag.Visitas - ViewBag.Ausentes;
            ViewBag.VisitasComRespostaPercent =(ViewBag.Visitas != 0) ? Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.VisitasComResposta), Convert.ToDecimal(ViewBag.Visitas)) * 100):0;
            ViewBag.AusentesPercent = (ViewBag.Visitas != 0) ?  Convert.ToInt32(decimal.Divide(Convert.ToDecimal(ViewBag.Ausentes), Convert.ToDecimal(ViewBag.Visitas)) * 100):0;

            if (eIndex)
                return View(evList);
            else
            {
                dynamic jsonModel = new ExpandoObject();
                jsonModel.Numeracoes = new List<string>();
                jsonModel.Porcentagens = new List<string>();

                jsonModel.Numeracoes.Add(evList.Count().ToString());
                jsonModel.Numeracoes.Add(ViewBag.Visitados.ToString());
                jsonModel.Numeracoes.Add(ViewBag.NaoVisitados.ToString());
                jsonModel.Numeracoes.Add(ViewBag.Contratados.ToString());
                jsonModel.Numeracoes.Add(ViewBag.NaoContratados.ToString());
                jsonModel.Numeracoes.Add(ViewBag.VisitaAgendada.ToString());
                jsonModel.Numeracoes.Add(ViewBag.Visitas.ToString());
                jsonModel.Numeracoes.Add(ViewBag.VisitasComResposta.ToString());
                jsonModel.Numeracoes.Add(ViewBag.Ausentes.ToString());

                jsonModel.Porcentagens.Add(ViewBag.VisitadosPercent.ToString());
                jsonModel.Porcentagens.Add(ViewBag.NaoVisitadosPercent.ToString());
                jsonModel.Porcentagens.Add(ViewBag.ContratadosPercent.ToString());
                jsonModel.Porcentagens.Add(ViewBag.NaoContratadosPercent.ToString());
                jsonModel.Porcentagens.Add(ViewBag.VisitaAgendadaPercent.ToString());
                jsonModel.Porcentagens.Add(ViewBag.VisitasComRespostaPercent.ToString());
                jsonModel.Porcentagens.Add(ViewBag.AusentesPercent.ToString());

                jsonModel.EV = evList;

                return Json(jsonModel);
            }
        }

    }
}
