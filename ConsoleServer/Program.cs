using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServerLibrary;

namespace ConsoleServer
{
    class Program
    {
        static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now}: {msg}");
        }

        static void ProcessClient(HttpListenerContext clientContext)
        {

        }

        static void Main(string[] args)
        {
            Server server = null;

            try
            {
                server = new Server();
                server.Start();
                Log("Server started");
            }
            catch (Exception e)
            {
                Log($"CRITICAL ERROR: {e.Message}\n Programm will be aborted");
                Console.ReadKey();
                Environment.Exit(0);
            }

            while (true)
            {
                try
                {
                    HttpListenerContext clientContext = server.GetClientContext();

                    Task.Run(() => { ProcessClient(clientContext); });
                }
                catch (Exception e)
                {
                    Log($"Client connection exceprion: {e.Message}");
                }
            }
        }
    }
}
