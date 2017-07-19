using System.Collections.Generic;

namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class MailMessage
    {
        public MailAddress From { get; set; }
        public List<MailAddress> To { get; set; } = new List<MailAddress>();
        public List<MailAddress> CC { get; set; } = new List<MailAddress>();
        public List<MailAddress> Bcc { get; set; } = new List<MailAddress>();
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; } = false;
    }
}