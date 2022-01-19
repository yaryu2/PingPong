using PingPong.Connection.Abstract;
using PingPong.UI;

namespace PingPong.Connection.Server.Abstract
{
    public class HandleRequest : IHandleRequestSocket<string, string>
    {
        public string HandleRequestSocket(string request, UIBase<string, string> ui)
        {
            ui.Write(request);
            return request;
        }
    }
}
