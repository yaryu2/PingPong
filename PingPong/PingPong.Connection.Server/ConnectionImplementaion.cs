using PingPong.Connection.Server.Abstract;
using PingPong.Connection.Server.SocketBase;
using PingPong.UI;
using System.Net.Sockets;

namespace PingPong.Connection.Server
{
    public class ConnectionImplementaion : ConnectionBase<Socket, string, string>
    {
        public ConnectionImplementaion() : base(
            new HandleRequest(), 
            new SocketImplementation()) { }

        public override void Run(string ip, int port, UIBase<string, string> ui)
        {
            var connection = _socket.CreateConnection(ip, port);
            var msg = _socket.Read(connection);
            var respons = _handleRequest.HandleRequestSocket(msg, ui);
            _socket.Write(respons, connection);
        }
    }
}
