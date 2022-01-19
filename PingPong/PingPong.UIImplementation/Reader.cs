using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.UI.Abstraction;

namespace PingPong.UIImplementation
{
    public class Reader : IReader<string>
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
