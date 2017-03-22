using NovatecEnergyWeb.Validations.ClientesWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class ClientesWeb
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Digite o login")]
        [LoginRepetido]
        public string Login { get; set; }

        [StringLength(20,MinimumLength =4,ErrorMessage ="Senha deve ter entre 4 a 20 caracteres")]
        [Required(ErrorMessage = "Digite a senha do cliente")]
        public string Senha { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Digite a senha de confirmação")]
        [Compare("Senha",ErrorMessage ="As senhas não coincidem")]
        public string ConfirmaSenha { get; set; }

        
        public bool? StatusLogin { get; set; }

        [Required(ErrorMessage = "Digite o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a zona")]
        public int Zona { get; set; }

        [Required(ErrorMessage = "Informe a delegação")]
        public int Delegacao { get; set; }

       /* [Required(ErrorMessage = "Informe a área")]
        public int Area { get; set; }*/

        public virtual _00Zona ZonaObj { get; set; }
        public virtual _00Delegação DelegacaoObj { get; set; }
        // public virtual _00Areas AreaObj { get; set; }
        public virtual IEnumerable<ClientesAreas> ClientesAreas { get; set; }
    }
}
