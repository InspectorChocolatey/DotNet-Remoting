using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using NewClassLibrary;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.CliMenu cliMenu = new Classes.CliMenu();
            List<string> listItems = cliMenu.GetLibraryClassList();
            cliMenu.DisplayListItems(listItems);

            ConnectToServer();

            ShowCapital showCapital = new ShowCapital();
            string country = "England";
            string response = showCapital.Show(country);
            Console.WriteLine();
            Console.WriteLine(response);

            MemberManager memberManager = new MemberManager();
            MethodInfo[] methodInfos = memberManager.GetMethods(memberManager);
            Console.WriteLine();
            memberManager.ShowInfos(memberManager);

            Console.ReadKey();
        }

        public static void ConnectToServer()
        {
            bool ensureSecurity = false;
            string objectUri = "tcp://localhost:1234/ShowCapital";
            Type type = typeof(NewClassLibrary.ShowCapital);

            TcpClientChannel tcpClientChannel = new TcpClientChannel();
            ChannelServices.RegisterChannel(tcpClientChannel, ensureSecurity);

            RemotingConfiguration.RegisterWellKnownClientType(
                type, objectUri
            );
        }
    }
}
