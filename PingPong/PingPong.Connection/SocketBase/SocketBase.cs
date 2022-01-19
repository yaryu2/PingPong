using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using PingPong.Connection.SocketBase.Abstraction;

namespace PingPong.Connection.SocketBase
{
    public abstract class SocketBase<TType, TWrite, TRead>
    {
        protected IWrite<TWrite> _write;
        protected IReader<TRead> _reader;
        protected IConnection<TType> _connection;

        public SocketBase(IWrite<TWrite> write, IReader<TRead> read, IConnection<TType> connection)
        {
            _write = write;
            _reader = read;
            _connection = connection;
        }

        public virtual TType CreateConnection(string ip, int port)
        {
            return _connection.CreateConnection(ip, port);
        }
        public virtual TRead Read(Socket handler)
        {
            return _reader.Read(handler);
        }
        public virtual void Write(TWrite value, Socket handler)
        {
            _write.Write(value, handler);
        }
    }
}
