using PingPong.UI;

namespace PingPong.Connection.SocketBase.Abstraction
{
    public interface IHandleRequestSocket<T, K>
    {
        K HandleRequestSocket(T request, UIBase<T, K> ui);
    }
}
