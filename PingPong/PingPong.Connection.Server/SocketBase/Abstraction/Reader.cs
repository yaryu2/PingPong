using PingPong.Connection.SocketBase.Abstraction;
using System.Net.Sockets;
using System.Text;

namespace PingPong.Connection.Server.SocketBase.Abstraction
{
    public class Reader : IReader<string>
    {
        public string Read(Socket handler)
        {
            byte[] bytes = new byte[1024];
            int bytesRec = handler.Receive(bytes);
            return Encoding.ASCII.GetString(bytes, 0, bytesRec);
        }
    }
}
