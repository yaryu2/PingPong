using System.Net.Sockets;

namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IWrite<T>
    {
        void Write(T value, Socket handler);
    }
}
