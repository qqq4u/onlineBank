using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationEntities;
using DBEntities;
using Newtonsoft.Json;
using DbWorker;

namespace ConsoleServer.Controllers
{
    public class UsersController
    {
        public static Response GetUserByLoginPassword(string parameters)
        {
            Dictionary<string, string> userParameters =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(parameters);

            string login = userParameters["login"];
            string password = userParameters["password"];

            User user = DbManager.GetInstance().TableUsers.GetUserByLoginPassword(login, password);

            return new Response()
            {
                Status = Response.StatusList.OK,
                Data = JsonConvert.SerializeObject(user)
            };
        }

        public static Response RegisterNewUser(string parameters)
        {
            Dictionary<string, string> registerParameters =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(parameters);

            string name = registerParameters["name"];
            string login = registerParameters["login"];
            string password = registerParameters["password"];

            User user = DbManager.GetInstance().TableUsers.RegisterNewUser(name, login, password);

            return new Response()
            {
                Status = Response.StatusList.OK,
                Data = JsonConvert.SerializeObject(user)
            };

        }
    }
}
