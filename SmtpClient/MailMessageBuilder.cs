using System;
using System.Collections.Generic;
using System.Linq;

namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class MailMessageBuilder
    {
        private MailAddress From { get; set; }
        private List<MailAddress> To { get; set; } = new List<MailAddress>();
        private List<MailAddress> CC { get; set; } = new List<MailAddress>();
        private List<MailAddress> Bcc { get; set; } = new List<MailAddress>();
        private string Subject { get; set; }
        private string Body { get; set; }
        private bool IsBodyHtml { get; set; }
        public List<MailAttachment> Attachments { get; set; } = new List<MailAttachment>();

        public MailMessageBuilder SetSender(string address, string name = null)
        {
            From = new MailAddress(address, name);
            return this;
        }

        public MailMessageBuilder AddRecipient(string address, string name = null, MailAddressType type = MailAddressType.To)
        {
            MailAddress mailAddress = new MailAddress(address, name);

            switch (type)
            {
                case MailAddressType.To:
                    To.Add(mailAddress);
                    break;
                case MailAddressType.CC:
                    CC.Add(mailAddress);
                    break;
                case MailAddressType.Bcc:
                    Bcc.Add(mailAddress);
                    break;
            }

            return this;
        }

        public MailMessageBuilder SetSubject(string subject)
        {
            Subject = subject;
            return this;
        }

        public MailMessageBuilder SetBody(string body, bool isBodyHtml = false)
        {
            Body = body;
            IsBodyHtml = isBodyHtml;
            return this;
        }

        public MailMessageBuilder AddAttachment(string name, byte[] data)
        {
            Attachments.Add(new MailAttachment(name, data));
            return this;
        }

        public MailMessage Build()
        {
            MailMessage mailMessage = new MailMessage();

            if (From == null || string.IsNullOrWhiteSpace(From.Address))
            {
                throw new ArgumentException(nameof(From));
            }
            else
            {
                mailMessage.From = From;
            }

            if (To != null && To.Any())
            {
                mailMessage.To.AddRange(To);
            }

            if (CC != null && CC.Any())
            {
                mailMessage.CC.AddRange(CC);
            }

            if (Bcc != null && Bcc.Any())
            {
                mailMessage.Bcc.AddRange(Bcc);
            }

            if (!string.IsNullOrWhiteSpace(Subject))
            {
                mailMessage.Subject = Subject;
            }

            if (!string.IsNullOrWhiteSpace(Body))
            {
                mailMessage.Body = Body;
                mailMessage.IsBodyHtml = IsBodyHtml;
            }

            if (Attachments != null && Attachments.Any())
            {
                mailMessage.Attachments.AddRange(Attachments);
            }

            return mailMessage;
        }
    }
}