using PingPong.Connection.SocketBase.Abstraction;
using System.Net.Sockets;
using System.Text;

namespace PingPong.Connection.Server.SocketBase.Abstraction
{
    public class Write : IWrite<string>
    {
        void IWrite<string>.Write(string value, Socket handler)
        {
            byte[] msg = Encoding.ASCII.GetBytes(value);
            handler.Send(msg);
        }
    }
}
