using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            int portNumber = 1234;
            bool securityEnabled = false;
            string objectUri = "ShowCapital";
            string startTime = DateTime.Now.ToString();
            Type type = typeof(NewClassLibrary.ShowCapital);

            TcpServerChannel tcpServerChannel = new TcpServerChannel(portNumber);
            ChannelServices.RegisterChannel(tcpServerChannel, securityEnabled);
            RemotingConfiguration.RegisterWellKnownServiceType(
                type, 
                objectUri, 
                WellKnownObjectMode.SingleCall
            );
            Console.WriteLine("Server started: {0}", startTime);
            Console.ReadKey();
        }
    }
}

/*
 * references:
 *  https://www.youtube.com/watch?v=lJph_kKQTQA
 *  
 */
