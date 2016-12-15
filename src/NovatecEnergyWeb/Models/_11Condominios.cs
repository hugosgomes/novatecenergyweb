using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _11Condominios
    {
        public _11Condominios()
        {
            _11CondEstrutura = new HashSet<_11CondEstrutura>();
            _11CondominiosObs = new HashSet<_11CondominiosObs>();
        }

        public int Id { get; set; }
        public int Logradouro { get; set; }
        public decimal Num { get; set; }
        public string Complemento { get; set; }
        public string Nome { get; set; }
        public int? Economias { get; set; }
        public int? Status { get; set; }
        public int? Statusb { get; set; }
        public decimal? Tipo { get; set; }
        public int Produto { get; set; }
        public DateTime? Dataprev { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? Instinternas { get; set; }
        public decimal? Redeinterna { get; set; }
        public int? Distrede { get; set; }
        public int? Energiaatual { get; set; }
        public string Contato { get; set; }
        public int? Tipocontato { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int? Obra { get; set; }
        public string Obs { get; set; }
        public DateTime? Datasistema { get; set; }
        public string Usersistema { get; set; }
        public int? Tarifasocial { get; set; }

        public virtual ICollection<_11CondEstrutura> _11CondEstrutura { get; set; }
        public virtual ICollection<_11CondominiosObs> _11CondominiosObs { get; set; }
    }
}
