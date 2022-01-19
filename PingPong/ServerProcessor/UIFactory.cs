using PingPong.UI;
using PingPong.UIImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProcessor
{
    public class UIFactory
    {
        public UIBase CreateUI()
        {
            UIBase ui = new ConsoleImplementation();
        }
    }
}
