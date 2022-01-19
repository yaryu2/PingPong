using log4net;
using log4net.Config;
using System.Configuration;
using System.Reflection;


namespace PingPong.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Check the path of FileInfo
            XmlConfigurator.Configure(new FileInfo(@"..\..\..\PingPong.UI.pdb"));
            ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            var value = ConfigurationManager.AppSettings[""];
        }
    }
}