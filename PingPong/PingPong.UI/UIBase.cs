using PingPong.UI.Abstraction;

namespace PingPong.UI
{
    public abstract class UIBase<T, K>
    {
        protected IReader<K> _reader;
        protected IWrite<T> _writer;

        public UIBase(IReader<K> reader, IWrite<T> writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public virtual K Read()
        {
            return _reader.Read();
        }

        public virtual void Write(T value)
        {
            _writer.Write(value);
        }
    }
}
