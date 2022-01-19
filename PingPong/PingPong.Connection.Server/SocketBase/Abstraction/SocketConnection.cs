using PingPong.Connection.SocketBase.Abstraction;
using System.Net;
using System.Net.Sockets;

namespace PingPong.Connection.Server.SocketBase.Abstraction
{
    public class SocketConnection : IConnection<Socket>
    {
        public Socket CreateConnection(string ip, int port)
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);

            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);

            listener.Listen();

            return listener;
        }
    }
}
