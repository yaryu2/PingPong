namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IConnection<T, K>
    {
        T CreateConnection(K arg);
    }
}
