using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class LoteEstatisticaPco
    {
        public Int64 Id { get; set; }
        public int Lote { get; set; }
        public string Umt { get; set; }
        public int Qmt { get; set; }
        public int Pot { get; set; }
        public int Vis { get; set; }
        public int Ent { get; set; }
        public int Int { get; set; }
        public int Visx { get; set; }
        public int Entx { get; set; }
        public Double Mtpot { get; set; }
        public Double Mtvis { get; set; }
        public Double Mtent { get; set; }
        public int Zid { get; set; }
        public int Did { get; set; }
        public int Aid { get; set; }
        public int Trat { get; set; }
        public int Visitas0 { get; set; }
        public int Visitas1 { get; set; }
        public int Visitas2 { get; set; }
    }
}
