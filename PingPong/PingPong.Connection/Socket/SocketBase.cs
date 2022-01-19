using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Connection.Socket.Abstraction;

namespace PingPong.Connection.Socket
{
    public abstract class SocketBase<TType, TWrite, TRead>
    {
        protected IWrite<TWrite> _write;
        protected IReader<TRead> _reader;
        protected IConnection<TType> _connection;

        public virtual TType CreateConnection(string ip, int port)
        {
            return _connection.CreateConnection(ip, port);
        }
        public virtual TRead Read()
        {
            return _reader.Read();
        }
        public virtual void Write(TWrite value)
        {
            _write.Write(value);
        }
    }
}
