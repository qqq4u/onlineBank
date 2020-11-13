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

        public Task<Response> SendMoney(int numberCardFrom, int numberCardTo, int moneyCount)
        {
            Dictionary<string, int> sendMoneyParameters = new Dictionary<string, int>();

            sendMoneyParameters["numberCardFrom"] = numberCardFrom;
            sendMoneyParameters["numberCardTo"] = numberCardTo;
            sendMoneyParameters["moneyCount"] = moneyCount;

            Request request = new Request()
            {
                Command = "Cards.SendMoney",
                Parameters = JsonConvert.SerializeObject(sendMoneyParameters),
                APIKey = apiKey
            };

            return client.RetrieveServerResponseAsync(request);
        }

        public Task<Response> AddingCardBalanceByNumber(int cardNumber, int moneyCount)
        {
            Dictionary<string, int> addingBalanceParameters = new Dictionary<string, int>();
            addingBalanceParameters["cardNumber"] = cardNumber;
            addingBalanceParameters["moneyCount"] = moneyCount;
            Request request = new Request()
            {
                Command = "Cards.AddingCardBalanceByNumber",
                Parameters = JsonConvert.SerializeObject(addingBalanceParameters),
                APIKey = apiKey
            };
            return client.RetrieveServerResponseAsync(request);
        }


        public Task<Response> CardsGetCardsByUserId(int userID)
        {

            Request request = new Request()
            {
                Command = "Cards.GetCardsByUserId",
                Parameters = userID.ToString(),
                APIKey = apiKey
            };

            return client.RetrieveServerResponseAsync(request);

        }

        public Task<Response> CardCreateNewCardWithUniqueNumber(int userID)
        {
            Request request = new Request()
            {
                Command = "Cards.CreateNewCardWithUniqueNumber",
                Parameters = userID.ToString(),
                APIKey = apiKey
            };

            return client.RetrieveServerResponseAsync(request);
        }
    }
}
