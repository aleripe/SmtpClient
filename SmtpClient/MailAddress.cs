namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class MailAddress
    {
        public string Address { get; set; }
        public string Name { get; set; }

        public MailAddress(string address)
        {
            Address = address;
        }

        public MailAddress(string address, string name)
        {
            Address = address;
            Name = name;
        }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                return $"{Name} <{Address}>";
            }
            else
            {
                return Address;
            }
        }
    }
}