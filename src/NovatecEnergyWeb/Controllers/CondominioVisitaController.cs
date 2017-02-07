using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovatecEnergyWeb.Models;
using Microsoft.EntityFrameworkCore;
using NovatecEnergyWeb.Models.CondominioVisitaViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NovatecEnergyWeb.Controllers
{
    public class CondominioVisitaController : Controller
    {
        private BDNVTContext _context;

        public CondominioVisitaController(BDNVTContext context)
        {
            _context = context;
        }

        public IActionResult EnderecoSemClienteCondominioAtivo()
        {
            return FiltraResultados();
        }

        public IActionResult FiltraResultados()
        {
            var visitas = _context._11_CondVisitasB.FromSql("exec [dbo].[11_CondVisitasB]").ToList();

            var Zonas = _context._00Zona.Where(c => c.Id < 3).Select(c => new { c.Id, c.Zona }).ToList();

            var _00Delegacao = _context._00Delegação.Select(d => new { d.Id, d.Delegacao }).ToList();

            var _00Areas = _context._00Areas.Select(a => new { a.Id, a.Area }).OrderBy(a => a.Area).ToList();

            var _TabelaItemVenda = _context._00TabelasItems
                .Select(t => new { t.Id, t.Item, t.Tabela, t.Campo })
                .Where(t => t.Tabela == 290 && t.Campo == "VENDA").ToList();

            var _TabelaItemTipoVenda = _context._00TabelasItems
                .Select(t => new { t.Id, t.Item, t.Tabela, t.Campo })
                .Where(t => t.Tabela == 290 && t.Campo == "TIPO").ToList();

            var _TabelaItemTipoVisita = _context._00TabelasItems
                .Where(t => t.Tabela == 290 && t.Campo == "STATUS")
                .Select(t => new { t.Id, t.Item })
                .ToList();

            var _MotivosRej = _context._11MotivosRej
                .Select(c => new { c.Id, c.Motivo }).ToList();

            var _FuncionariosComercial = _context.Funcionários
                .Where(f => f.Setor == 4 && f.DataDeDemissão == null)
                .Select(f => new { f.Id, f.NomeCompleto })
                .OrderBy(a => a.NomeCompleto)
                .ToList();

            var _StatusCondominio = _context._00TabelasItems
                .Where(f => f.Tabela == 237 && f.Campo == "STATUS")
                .OrderBy(f => f.Ordem)
                .Select(f => new { f.Id, f.Item })
                .ToList();

            var _Condominios = _context._11_Visita_Condominios.FromSql("exec [dbo].[11_Visita_Condominios]").ToList();
            
            #region PreencheViewBag
            //Lista de errados
            var ContavisitasTemp = _context._11CondVisitasTemp.Count();
            ViewBag.Errados = ContavisitasTemp;
            
            //lista de zonas
            ViewBag.Zonas = new List<_00Zona>();
            foreach (var item in Zonas)
            {
                var zona = new _00Zona();
                zona.Id = item.Id;
                zona.Zona = item.Zona;
                ViewBag.Zonas.Add(zona);
            }

            ViewBag.ListaDelegacao = new List<_00Delegação>();
            foreach (var item in _00Delegacao)
            {
                var delegacao = new _00Delegação();
                delegacao.Id = item.Id;
                delegacao.Delegacao = item.Delegacao;
                ViewBag.ListaDelegacao.Add(delegacao);
            }

            ViewBag.ListaAreas = new List<_00Areas>();
            foreach (var item in _00Areas)
            {
                var area = new _00Areas();
                area.Id = item.Id;
                area.Area = item.Area;
                ViewBag.ListaAreas.Add(area);
            }

            ViewBag.ListaVenda = new List<_00TabelasItems>();
            foreach (var item in _TabelaItemVenda)
            {
                var itemVisita = new _00TabelasItems();
                itemVisita.Id = item.Id;
                itemVisita.Item = item.Item;
                ViewBag.ListaVenda.Add(itemVisita);
            }

            ViewBag.TipoVenda = new List<_00TabelasItems>();
            foreach (var item in _TabelaItemTipoVenda)
            {
                var itemTipo = new _00TabelasItems();
                itemTipo.Id = item.Id;
                itemTipo.Item = item.Item;
                ViewBag.TipoVenda.Add(itemTipo);
            }

            ViewBag.TipoVisitas = new List<_00TabelasItems>();
            foreach (var item in _TabelaItemTipoVisita)
            {
                var tipoVisita = new _00TabelasItems();
                tipoVisita.Id = item.Id;
                tipoVisita.Item = item.Item;
                ViewBag.TipoVisitas.Add(tipoVisita);
            }

            ViewBag.MotivosRej = new List<_11MotivosRej>();
            foreach (var item in _MotivosRej)
            {
                var motivoRejeicao = new _11MotivosRej();
                motivoRejeicao.Id = item.Id;
                motivoRejeicao.Motivo = item.Motivo;
                ViewBag.MotivosRej.Add(motivoRejeicao);
            }

            ViewBag.ListaFuncionarios = new List<Funcionários>();
            foreach (var item in _FuncionariosComercial)
            {
                var funcionario = new Funcionários();
                funcionario.Id = item.Id;
                funcionario.NomeCompleto = item.NomeCompleto;
                ViewBag.ListaFuncionarios.Add(funcionario);
            }

            ViewBag.ListaStatusCondominio = new List<_00TabelasItems>();
            foreach (var item in _StatusCondominio)
            {
                var statusCondominio = new _00TabelasItems();
                statusCondominio.Id = item.Id;
                statusCondominio.Item = item.Item;
                ViewBag.ListaStatusCondominio.Add(statusCondominio);
            }

            ViewBag.ListaStatusCondominio = new List<_00TabelasItems>();
            foreach (var item in _StatusCondominio)
            {
                var statusCondominio = new _00TabelasItems();
                statusCondominio.Id = item.Id;
                statusCondominio.Item = item.Item;
                ViewBag.ListaStatusCondominio.Add(statusCondominio);
            }
            #endregion

            ViewBag.ListaCondominios = _Condominios;


            var listaCondominioVisita = new List<CondominioVisitaViewModel>();

            foreach (var item in visitas)
            {
                var condominioVisitaViewModel = new CondominioVisitaViewModel();
                condominioVisitaViewModel.Id = item.Id;
                condominioVisitaViewModel.Z = item.Z;
                condominioVisitaViewModel.D = item.D;
                condominioVisitaViewModel.Ar = item.Ar;
                condominioVisitaViewModel.Condominio = item.Condominio;
                condominioVisitaViewModel.Complemento = item.Complemento;
                condominioVisitaViewModel.Num = item.Num;
                condominioVisitaViewModel.Bloco = item.Bloco;
                condominioVisitaViewModel.Apt =  item.Apt;      
                condominioVisitaViewModel.DataHora =  item.DataHora;
                condominioVisitaViewModel.Venda =  item.Venda;
                condominioVisitaViewModel.AgVisita       =  item.AgVisita;
                condominioVisitaViewModel.Negativa       =  item.Negativa ;
                condominioVisitaViewModel.TipoVisita     =  item.TipoVisita;
                condominioVisitaViewModel.Dx             =  item.Dx;
                condominioVisitaViewModel.TipoD2         =  item.TipoD2;
                condominioVisitaViewModel.Obs            =  item.Obs;
                condominioVisitaViewModel.Pt             =  item.Pt;
                condominioVisitaViewModel.Latitude       =  item.Latitude;
                condominioVisitaViewModel.Longitude      =  item.Longitude;           
                condominioVisitaViewModel.DataAgendamento =  item.DataAgendamento;                  
                condominioVisitaViewModel.ObsAgendamento =  item.ObsAgendamento;
                condominioVisitaViewModel.StatusCond     =  item.StatusCond;
                condominioVisitaViewModel.TipoCond       =  item.TipoCond;
                condominioVisitaViewModel.Localidade     =  item.Localidade;
                condominioVisitaViewModel.Bairro         =  item.Bairro;
                condominioVisitaViewModel.Via            =  item.Via;
                condominioVisitaViewModel.Logradouro     =  item.Logradouro;
                condominioVisitaViewModel.Cliente =         item.Cliente;

                listaCondominioVisita.Add(condominioVisitaViewModel);
            }
            return View(listaCondominioVisita);
        }
    }
}
