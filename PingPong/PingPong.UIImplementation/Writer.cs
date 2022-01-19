using PingPong.UI.Abstraction;

namespace PingPong.UIImplementation
{
    public class Writer : IWrite<string>
    {
        public void Write(string value)
        {
            Console.WriteLine(value);
        }
    }
}
