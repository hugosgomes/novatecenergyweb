using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovatecEnergyWeb.Models
{
    public class Email
    {
        public string _destinatario { get;  set; }
        public string _assunto { get;  set; }
        public string _conteudo { get;  set; }
        public string _remetente { get;  set; }
        
        public Email()
        {
            _destinatario = "tsantana@novatecenergy.com.br";
            _assunto = "Teste Sistema Web";
            _conteudo = "Teste do envio do E-mail - Teste Envio sistema";         
            _remetente = "tsantana@novatecenergy.com.br";
        }

        public string Enviar()
        {
            try
            {
                MimeMessage message = new MimeMessage();
                message.Subject = _assunto;
                message.Body = new TextPart("Plain") { Text = _conteudo };
                message.From.Add(new MailboxAddress(_remetente));
                message.To.Add(new MailboxAddress(_destinatario));
                
                using (var client = new SmtpClient())
                {
                    client.Connect("email-ssl.com.br", 587, SecureSocketOptions.StartTlsWhenAvailable);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate("tsantana@novatecenergy.com.br", "Novatec.0");
                    client.Send(message);
                    client.Disconnect(true);
                }
                
                return "Success";
            }
            catch (Exception ex)
            {
                return $"Failed. Error: {ex.Message}";
            }
        }
    }


    public class EmailDiretoria : Email
    {
        public EmailDiretoria(string nomeCliente)
        {
            _destinatario = "diretoria@novatecenergy.com.br"; // mudar depois para diretoria@novatecenergy.com.br
            _assunto = "NovatecEnergyWeb - Novo cliente cadastrado";
            _conteudo = $"Foi cadastrado o(a) cliente " + nomeCliente +" no portal NovatecEnergyWeb."+ Environment.NewLine+
                "Está aguardando a confirmação para poder realizar o login no sistema.";
            _remetente = "ti@novatecenergy.com.br";
        }
    }
    public class EmailCliente : Email
    {
        public EmailCliente(string destinatario, bool cadastro)
        {
            //cadastro feito
            if (cadastro)
            {
                _destinatario = destinatario;
                _assunto = "NovatecEnergyWeb - Cadastro concluído";
                _conteudo = $"Foi realizado um cadastro para seu uso no portal NovatecEnergyWeb. {Environment.NewLine}" +
                    "Aguarde o email de confirmação para poder realizar o login no sistema.";
                _remetente = "ti@novatecenergy.com.br";
            }
            else
            {
                //instruções falando para o cliente que ele já pode logar
                _destinatario = destinatario;
                _assunto = "NovatecEnergyWeb - Ativação de cadastro";
                _conteudo = $"Seu cadastro foi ativado no portal NovatecEnergyWeb. {Environment.NewLine}" +
                    "Já é possível realizar o login no sistema. Na tela de Login, selecione a opção 'Clientes' e realize o login.";
                _remetente = "ti@novatecenergy.com.br";
            }
        }
    }

}
