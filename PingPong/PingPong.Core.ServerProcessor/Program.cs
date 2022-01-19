using PingPong.Core.Factories;

namespace PingPong.Core.ServerProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var socket = new SocketFactory().GenerateSocket();
            var ui = new UIFactory().GenerateUI();

            socket.Run("0.0.0.0", int.Parse(args[1]), ui);
        }
    }
}