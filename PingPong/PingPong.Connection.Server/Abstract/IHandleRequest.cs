namespace PingPong.Connection.Server.Abstract
{
    public interface IHandleRequest<T, K>
    {
        K HandleRequest(T request);
    }
}
