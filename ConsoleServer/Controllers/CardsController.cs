using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationEntities;
using DBEntities;
using DbWorker;
using Newtonsoft.Json;

namespace ConsoleServer.Controllers
{
    class CardsController
    {
        public static Response GetCardsByUserId(string parameters)
        {
            int userID = int.Parse(parameters);

            List<Card> cards = DbManager.GetInstance().TableCards.GetCardsByUserId(userID);

            return new Response()
            {
                Status = Response.StatusList.OK,
                Data = JsonConvert.SerializeObject(cards)
            };
        }

        public static Response CreateNewCardWithUniqueNumber(string parameters)
        {
            int userID = int.Parse(parameters);

            Card card = DbManager.GetInstance().TableCards.CreateNewCardWithUniqueNumber(userID);

            return new Response()
            {
                Status = Response.StatusList.OK,
                Data = JsonConvert.SerializeObject(card)
            };

        }

        public static Response AddingCardBalanceByNumber(string parameters)
        {
            Dictionary<string, int> addinBalanceParameters =
                JsonConvert.DeserializeObject<Dictionary<string, int>>(parameters);

            int cardNumber = addinBalanceParameters["cardNumber"];
            int moneyCount = addinBalanceParameters["moneyCount"];

            DbManager.GetInstance().TableCards.AddingCardBalanceByNumber(cardNumber, moneyCount);

            return new Response()
            {
                Status = Response.StatusList.OK,
                Data = ""
            };
        }


        public static Response SendMoney(string parameters)
        {
            Dictionary<string, int> sendMoneyParameters =
                JsonConvert.DeserializeObject<Dictionary<string, int>>(parameters);
            int numberCardFrom = sendMoneyParameters["numberCardFrom"];
            int numberCardTo = sendMoneyParameters["numberCardTo"];
            int moneyCount = sendMoneyParameters["moneyCount"];

            DbManager.GetInstance().TableCards.SendMoney(numberCardFrom, numberCardTo, moneyCount);

            return new Response()
            {
                Status = Response.StatusList.OK,
                Data = ""
            };
        }


    }
}
