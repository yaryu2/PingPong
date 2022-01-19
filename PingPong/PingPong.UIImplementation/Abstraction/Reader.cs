using PingPong.UI.Abstraction;

namespace PingPong.UIImplementation.Abstraction
{
    public class Reader : IReader<string>
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
