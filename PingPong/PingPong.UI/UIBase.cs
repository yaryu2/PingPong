using PingPong.UI.Abstraction;

namespace PingPong.UI
{
    public abstract class UIBase<T> : IWrite<T>, IReader<T>
    {
        public abstract T Read();

        public abstract void Write(T value);
    }
}
