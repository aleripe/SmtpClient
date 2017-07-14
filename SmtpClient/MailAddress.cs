namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class MailAddress
    {
        public string Address { get; set; }

        public MailAddress(string address)
        {
            Address = address;
        }
    }
}