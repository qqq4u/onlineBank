using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunicationEntities;
using DBEntities;
using Newtonsoft.Json;
using WFClient.Model;
using WFClient.View;

namespace WFClient.Controller
{
    class ControllerFormAuth
    {
        private FormAuth form;
        private APIWorker API;

        public ControllerFormAuth(FormAuth form)
        {
            this.form = form;

            API = APIWorker.GetInstance();
        }

        public async Task UserGetUserByLoginPassword()
        {
            string login = form.textBoxLogin.Text;
            string password = form.textBoxPassword.Text;

            Response response = await API.UsersGetUserByLoginPassword(login, password);

            if (response.Status == Response.StatusList.OK)
            {
                User user = JsonConvert.DeserializeObject<User>(response.Data);
            }
            else if (response.Status == Response.StatusList.ERROR)
            {
                MessageBox.Show(response.Data);
            }
            

        }
    }
}
