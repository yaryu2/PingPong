namespace PingPong.Connection.Socket.Abstraction
{
    public interface IConnection<T>
    {
        T CreateConnection(string ip, int port);
    }
}
