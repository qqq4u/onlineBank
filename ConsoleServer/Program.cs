using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServerLibrary;
using CommunicationEntities;
using ConsoleServer.Tools;
using ExceptionEntities;
using ConsoleServer.Tools;

namespace ConsoleServer
{
    class Program
    {
        static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now}: {msg}");
        }

        static void SendResponse(HttpListenerContext clientContext, Response response)
        {
            try
            {
                Log($"RESPONSE:\n Command: {response.Status}\n Params: {response.Data}");

                Server.SendResponseToClient(clientContext, response);

            }
            catch (Exception e)
            {
                Log($"RESPONSE ERROR\n Error:{e.Message}");
            }
        }

        static void ProcessClient(HttpListenerContext clientContext)
        {
            Log("Client Entered");

            Request request = null;
            Response response = null;

            try
            {
                request = Server.RecieveRequestFromClient(clientContext);

                Log($"REQUEST:\n Command: {request.Command}\n Params: {request.Parameters}");
            }
            catch (Exception e)
            {
                response = new Response()
                {
                    Status = Response.StatusList.ERROR,
                    Data = e.Message
                };

                Log($"REQUEST ERROR\n Error:{e.Message}");

                SendResponse(clientContext,response);

                return;
            }

            try
            {
                if (request.APIKey != "JDI89U283UDj892uj389du2389U**(U&&*Y*#WU*DJ#*(UJ*@JHDUJ*(U*)(UD")
                {
                    throw new WrongAPIKeyException();
                }

                response = Router.ProcessCommand(request);

                SendResponse(clientContext, response);


            }
            catch (Exception e)
            {
                response = new Response()
                {
                    Status = Response.StatusList.ERROR,
                    Data = e.Message
                };

                Log($"REQUEST ERROR\n Error:{e.Message}");

                SendResponse(clientContext, response);

                return;
            }

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
