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
        public string _destinatario { get; private set; }
        public string _assunto { get; private set; }
        public string _conteudo { get; private set; }
        public string _remetente { get; private set; }
        
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
}
