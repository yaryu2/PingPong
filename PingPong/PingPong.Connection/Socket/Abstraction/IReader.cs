namespace PingPong.Connection.Socket.Abstraction
{
    public interface IReader<T>
    {
        T Read();
    }
}
