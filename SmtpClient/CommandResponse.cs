namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class CommandResponse
    {
        public int Code { get; private set; }
        public string Message { get; private set; }

        public CommandResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}