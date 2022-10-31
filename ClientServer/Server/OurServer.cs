using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;
using System;

namespace Server
{
    class OurServer
    {
        TopListener server;

        public OurServer()
        {
            server = new TopListener(IPAddress.Parse("127.0.0.1"), 5555);
            server.Start();

            loopClients();
        }

        void LoopClients()
        {
            while(true)
            {
                TopClient client = server.AcceptTcpClient();

                Threed threed = new Threed(() => HandleClient(client));
                thread.Start();
            }
        }
        void HandleClient(TcpClient)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);

            while(true)
            {
                string message = sReader.ReadLine();
                Console.WriteLine($"Клиент написал - {message}");
            }
        }
    }


}