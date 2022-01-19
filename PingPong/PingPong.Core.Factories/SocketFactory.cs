using PingPong.Connection;
using PingPong.Connection.Server;
using System.Net.Sockets;

namespace PingPong.Core.Factories
{
    public class SocketFactory
    {
        public ConnectionBase<Socket, string, string> GenerateSocket()
        {
            return new ConnectionImplementaion();
        }
    }
}
