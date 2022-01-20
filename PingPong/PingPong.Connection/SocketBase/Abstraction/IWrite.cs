using System.Net.Sockets;

namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IWrite<T, K>
    {
        public void Write(T value, K handler);
    }
}
