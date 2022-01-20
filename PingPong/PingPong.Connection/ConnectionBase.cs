using PingPong.Connection.SocketBase;
using PingPong.Connection.SocketBase.Abstraction;
using PingPong.UI;

namespace PingPong.Connection
{
    public abstract class ConnectionBase<TType, TWrite, TRead, TArg>
    {
        protected SocketBase<TType, TWrite, TRead, TArg> _socket;
        protected UIBase<TRead, TWrite> _ui;

        public ConnectionBase(UIBase<TRead, TWrite> ui, SocketBase<TType, TWrite, TRead, TArg> socket)
        {
            _ui = ui;
            _socket = socket;
        }

        public abstract void Run(string ip, int port);
    }
}
