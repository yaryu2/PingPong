using System.Net.Sockets;

namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IReader<T>
    {
        T Read(Socket handler);
    }
}
