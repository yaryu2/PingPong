namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IConnection<T>
    {
        T CreateConnection(string ip, int port);
    }
}
