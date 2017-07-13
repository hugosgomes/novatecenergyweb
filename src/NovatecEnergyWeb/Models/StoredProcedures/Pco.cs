using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models.StoredProcedures
{
    public class Pco
    {
        public Int64 Id { get; set; }
        public int Num { get; set; }
        public String Complemento { get; set; }
        public String Nome { get; set; }
        public int Statu { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
        public int Distrede { get; set; }
        public int InstInternas { get; set; }
        public int EnergiaAtual { get; set; }
        public String Contato { get; set; }
        public int TipoContato { get; set; }
        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public String Obs { get; set; }
        public DateTime DataSistema { get; set; }
        public String UserSistema { get; set; }
        public String LinkPasta { get; set; }
        public int IdLoc { get; set; }
        public int IdBairro { get; set; }
        public int IdVia { get; set; }
        public int IdZona { get; set; }
        public int IdDel { get; set; }
        public String Complog { get; set; }
        public String LocalidadeB { get; set; }
        public String BairroB { get; set; }
        public String LogradouroB { get; set; }
        public String Localidade { get; set; }
        public String Bairro { get; set; }
        public String LogDesc { get; set; }
        public String Via { get; set; }
        public String Status_Item { get; set; }
        public String Internas_Item { get; set; }
        public String Energia_Item { get; set; }
        public String Tipocontato_Item { get; set; }



    }
}
