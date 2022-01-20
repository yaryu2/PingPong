using PingPong.Connection.Server.SocketBase;
using PingPong.Connection.SocketBase;
using PingPong.UI;
using System.Net;
using System.Net.Sockets;

namespace PingPong.Connection.Server
{
    public class ConnectionImplementaion : ConnectionBase<Socket, string, string, IAsyncResult>
    {
        public ConnectionImplementaion(
            UIBase<string, string> ui, 
            SocketBase<Socket, string, string, IAsyncResult> socket) : base(ui, socket)
        { }

        public override void Run(string ip, int port)
        {
            throw new NotImplementedException();
        }
    }
}
