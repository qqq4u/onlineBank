using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientLibrary;
using CommunicationEntities;
using Newtonsoft.Json;

namespace WFClient.Model
{
    class APIWorker
    {
        private static APIWorker instance = null;

        private Client client;
        private string apiKey;
        private APIWorker()
        {
            client = new Client();
            apiKey = "JDI89U283UDj892uj389du2389U**(U&&*Y*#WU*DJ#*(UJ*@JHDUJ*(U*)(UD";
        }

        public static APIWorker GetInstance()
        {
            if (instance == null)
            {
                instance = new APIWorker();
            }

            return instance;
        }

        public Task<Response> UsersGetUserByLoginPassword(string login, string password)
        {
            Dictionary<string, string> userParameters = new Dictionary<string, string>();
            userParameters["login"] = login;
            userParameters["password"] = password;

            Request request = new Request()
            {
                Command = "Users.GetUserByLoginPassword",
                Parameters = JsonConvert.SerializeObject(userParameters),
                APIKey = apiKey
            };

            return client.RetrieveServerResponseAsync(request);

        }
    }
}
