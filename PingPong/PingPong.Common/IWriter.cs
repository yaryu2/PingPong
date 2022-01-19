namespace PingPong.Common
{
    public interface IWriter<T>
    {
        void Writer(T message);
    }
}
