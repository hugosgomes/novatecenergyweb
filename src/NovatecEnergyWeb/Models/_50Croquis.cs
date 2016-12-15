using System;
using System.Collections.Generic;

namespace NovatecEnergyWeb.Models
{
    public partial class _50Croquis
    {
        public _50Croquis()
        {
            _50LotesPlanoTeste = new HashSet<_50LotesPlanoTeste>();
            _50Precert = new HashSet<_50Precert>();
            _50ProjetoDesenvolvimento = new HashSet<_50ProjetoDesenvolvimento>();
            _50ProjetoMateriais = new HashSet<_50ProjetoMateriais>();
        }

        public int Cod { get; set; }
        public int Numcroqui { get; set; }
        public int Projeto { get; set; }
        public int Centrocontabil { get; set; }
        public DateTime Data { get; set; }
        public string Trecho { get; set; }
        public int? Encarregado { get; set; }
        public int? Desenhista { get; set; }
        public int Soldador { get; set; }
        public int? Encanador { get; set; }
        public string Maquinasolda { get; set; }
        public string Obs { get; set; }
        public string Anexo { get; set; }

        public virtual ICollection<_50LotesPlanoTeste> _50LotesPlanoTeste { get; set; }
        public virtual ICollection<_50Precert> _50Precert { get; set; }
        public virtual ICollection<_50ProjetoDesenvolvimento> _50ProjetoDesenvolvimento { get; set; }
        public virtual ICollection<_50ProjetoMateriais> _50ProjetoMateriais { get; set; }
        public virtual _50CroquiCentroContabil CentrocontabilNavigation { get; set; }
        public virtual Funcionários DesenhistaNavigation { get; set; }
        public virtual Funcionários EncanadorNavigation { get; set; }
        public virtual Funcionários EncarregadoNavigation { get; set; }
        public virtual Funcionários SoldadorNavigation { get; set; }
    }
}
