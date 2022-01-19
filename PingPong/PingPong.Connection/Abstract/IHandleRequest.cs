namespace PingPong.Connection.Abstract
{
    public interface IHandleRequest<T, K>
    {
        K HandleRequest(T request);
    }
}
