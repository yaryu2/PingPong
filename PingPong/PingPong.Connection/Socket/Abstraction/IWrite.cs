namespace PingPong.Connection.Socket.Abstraction
{
    public interface IWrite<T>
    {
        void Write(T value);
    }
}
