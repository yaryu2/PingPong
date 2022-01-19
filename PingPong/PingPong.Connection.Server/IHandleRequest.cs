using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Connection.Server
{
    public interface IHandleRequest<T, K>
    {
        K HandleRequest(T request);
    }
}
