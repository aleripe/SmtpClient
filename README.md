# SmtpClient
A simple but effective SMTP client for ASP.NET core

## Usage


```C#
MailMessageBuilder mailMessageBuilder = new MailMessageBuilder()
  .SetSender("info@mydomain.com", "My domain")
  .AddRecipient("john.smith@otherdomain.com", "John Smith") // Default recipient type is To (but can also be CC or Bcc)
  .SetSubject("Please confirm your account")
  .SetBody(@"<b>Please</b> click on the following <a href=""www.mydomain.com"">link</a> to confirm your account.", true) // Specifies HTML format
  .AddAttachment("Invoice.pdf", System.IO.File.ReadAllBytes(@"C:\Invoice.pdf"));
  
using (var client = new SmtpClient("localhost", 25))
{
  await client.SendAsync(mailMessageBuilder.build());
}
  
```

## License

This project is licensed under the terms of the MIT license.
