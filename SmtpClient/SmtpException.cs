using System;

namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public class SmtpException : Exception
    {
        public SmtpStatusCode StatusCode { get; set; }

        public SmtpException(SmtpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public SmtpException(string message, SmtpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public SmtpException(string message, Exception innerException, SmtpStatusCode statusCode) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}