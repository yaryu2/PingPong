using PingPong.UI;

namespace PingPong.Connection.Abstract
{
    public interface IHandleRequestSocket<T, K>
    {
        K HandleRequestSocket(T request, UIBase<T, K> ui);
    }
}
