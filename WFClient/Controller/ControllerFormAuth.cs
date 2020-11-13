using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunicationEntities;
using DBEntities;
using HashLib;
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
            form.buttonAuth.Enabled = false;

            string login = form.textBoxLogin.Text;
            string password = form.textBoxPassword.Text;


            IHash hash = HashFactory.Crypto.CreateSHA512();
            HashResult passwordHashed = hash.ComputeString(password, Encoding.Unicode);


            Response response = await API.UsersGetUserByLoginPassword(login, passwordHashed.ToString());

            if (response.Status == Response.StatusList.OK)
            {
                User user = JsonConvert.DeserializeObject<User>(response.Data);

                MessageBox.Show("success");

                DataStorage.Add("user", user);

                form.Hide();
                new FormMain().ShowDialog();
            }
            else if (response.Status == Response.StatusList.ERROR)
            {
                form.buttonAuth.Enabled = true;
                MessageBox.Show(response.Data);
            }


        }
    }
}
