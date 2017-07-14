using System.Net.Sockets;
using System.Threading.Tasks;

namespace ReturnTrue.AspNetCore.Net.SmtpClient
{
    public static class SocketExtensions
    {
        public static async Task<Socket> ChainAsync(this Socket input, byte[] buffer, int milliseconds)
        {
            input.Send(buffer);
            await Task.Delay(milliseconds);
            return input;
        }
    }
}