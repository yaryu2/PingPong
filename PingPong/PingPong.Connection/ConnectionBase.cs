using PingPong.Connection.Abstract;
using PingPong.Connection.SocketBase;
using PingPong.UI;

namespace PingPong.Connection
{
    public abstract class ConnectionBase<TType, TWrite, TRead>
    {
        protected IHandleRequestSocket<TRead, TWrite> _handleRequest;
        protected SocketBase<TType, TWrite, TRead> _socket;

        public ConnectionBase(
            IHandleRequestSocket<TRead, TWrite> handleRequest, 
            SocketBase<TType, TWrite, TRead> socket)
        {
            _handleRequest = handleRequest;
            _socket = socket;
        }

        public abstract void Run(string ip, int port, UIBase<TRead, TWrite> ui);
    }
}
