using System.Collections.Generic;

namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class MailMessage
    {
        public string From { get; set; }
        public List<MailAddress> To { get; set; }
        public List<MailAddress> CC { get; set; }
        public List<MailAddress> Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
    }
}