using PingPong.Connection.SocketBase;
using PingPong.Connection.SocketBase.Abstraction;
using System.Net;
using System.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Connection.Server.SocketBase.Abstraction;

namespace PingPong.Connection.Server.SocketBase
{
    public class SocketImplementation : SocketBase<Socket, string, string>
    {
        public SocketImplementation() : base(
                new Write(), 
                new Reader(), 
                new SocketConnection()
            ) { }
    }
}
