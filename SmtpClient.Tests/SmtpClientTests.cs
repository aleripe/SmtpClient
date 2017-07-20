using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ReturnTrue.AspNetCore.Net.SmtpClient.Tests
{
    public class SmtpClientTests
    {
        [Fact]
        public async Task TestConnection()
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("info@paradox.it", "Paradox"),
                To = new List<MailAddress> { new MailAddress("aleripe@gmail.com"), new MailAddress("alessandro.riperi@funfactorysrl.com") },
                CC = new List<MailAddress> { new MailAddress("alessandro.riperi@gmail.com") },
                Bcc = new List<MailAddress> { new MailAddress("aleripe@alice.it") },
                Subject = "Notifica registrazione",
                Body = "<html><body><b>Un utente</b> si &egrave; registrato <i>nel sistema</i></html>",
                IsBodyHtml = true
            };

            SmtpClient client = new SmtpClient("localhost", 25);
            //client.SetCredentials("aleripe@gmail.com", "2_TnotB_8");
            //client.EnableSsl = true;
            await client.SendAsync(mailMessage);
        }
    }
}