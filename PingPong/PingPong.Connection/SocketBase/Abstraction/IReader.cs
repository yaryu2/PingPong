using System.Net.Sockets;

namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IReader<T, K>
    {
        T Read(K arg);
    }
}
