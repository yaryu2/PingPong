using PingPong.UI;
using PingPong.UIImplementation.Abstraction;

namespace PingPong.UIImplementation
{
    public class ConsoleImplementation : UIBase<string, string>
    {
        public ConsoleImplementation() : base(new Reader(), new Writer()) { }
    }
}
