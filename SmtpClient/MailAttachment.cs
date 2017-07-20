namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class MailAttachment
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        
        public MailAttachment(string name, byte[] data)
        {
            Name = name;
            Data = data;
        }
    }
}