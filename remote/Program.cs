using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using common;
namespace remote
{
    public class MyServer
    {
        public static void Main()
        {
            ChannelServices.RegisterChannel(new TcpChannel(8082));
            RemotingConfiguration.RegisterActivatedServiceType(typeof(HelloServer));
            Console.WriteLine("Press enter to stop this process");
            Console.ReadLine();
        }
    }
}
