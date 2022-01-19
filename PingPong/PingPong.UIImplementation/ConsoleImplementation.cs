using PingPong.UI;
using PingPong.UIImplementation.Abstraction;

namespace PingPong.UIImplementation
{
    public class ConsoleImplementation : UIBase<string>
    {
        public ConsoleImplementation()
        {
            _reader = new Reader();
            _writer = new Writer();
        }

        public string Read()
        {
            return _reader.Read();
        }

        public void Write(string value)
        {
            _writer.Write(value);
        }
    }
}
