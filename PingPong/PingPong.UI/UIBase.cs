using PingPong.UI.Abstraction;

namespace PingPong.UI
{
    public abstract class UIBase<T>
    {
        protected IReader<T> _reader;
        protected IWrite<T> _writer;
    }
}
