using PingPong.Connection.Server.SocketBase.Abstraction;
using PingPong.Connection.SocketBase;
using PingPong.UI;
using System.Net.Sockets;
using System.Text;

namespace PingPong.Connection.Server.SocketBase
{
    public class SocketImplementation : SocketBase<Socket, string, string, IAsyncResult>
    {
        public override Socket CreateConnection(IAsyncResult arg)
        {
            throw new NotImplementedException();
        }

        public override string HandleRequestSocket(string request, UIBase<string, string> ui)
        {
            throw new NotImplementedException();
        }

        public override string Read(IAsyncResult arg)
        {
            throw new NotImplementedException();
        }

        public override void Write(string value, Socket handler)
        {
            throw new NotImplementedException();
        }
    }
}
