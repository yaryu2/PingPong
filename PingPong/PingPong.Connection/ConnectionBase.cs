using PingPong.Connection.Abstract;
using PingPong.Connection.Socket;

namespace PingPong.Connection
{
    public abstract class ConnectionBase<TType, TWrite, TRead>
    {
        protected IHandleRequest<TRead> _handleRequest;
        protected SocketBase<TType, TWrite, TRead> _socket;

        public abstract void Run(string ip, int port);
    }
}
