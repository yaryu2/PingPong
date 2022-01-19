using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.UI
{
    public interface IWrite<T>
    {
        void Write(T value);
    }
}
