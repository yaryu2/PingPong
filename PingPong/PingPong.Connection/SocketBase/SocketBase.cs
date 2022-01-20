using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using PingPong.Connection.SocketBase.Abstraction;
using PingPong.UI;

namespace PingPong.Connection.SocketBase
{
    public abstract class SocketBase<TType, TWrite, TRead, TArg> : 
        IWrite<TWrite, TType>, 
        IReader<TRead, TArg>, 
        IConnection<TType, TArg>,
        IHandleRequestSocket<TRead, TWrite>
    {
        public abstract TType CreateConnection(TArg arg);

        public abstract TWrite HandleRequestSocket(TRead request, UIBase<TRead, TWrite> ui);

        public abstract TRead Read(TArg arg);

        public abstract void Write(TWrite value, TType handler);
    }
}
