using PingPong.UI;
using PingPong.UIImplementation;

namespace PingPong.Core.Factories
{
    public class UIFactory
    {
        public UIBase<string, string> GenerateUI()
        {
            return new ConsoleImplementation();
        }
    }
}
