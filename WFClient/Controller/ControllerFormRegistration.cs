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
    class ControllerFormRegistration
    {
        private FormRegistration form = null;
        private APIWorker API = null;
        private User user;

        public ControllerFormRegistration(FormRegistration form)
        {
            this.form = form;

            API = APIWorker.GetInstance();
        }

        private bool IsTextBoxEmpty(TextBox textBox)
        {
            return textBox.Text == string.Empty;
        }
        private bool IsAllFieldsFilled()
        {
            //return (IsTextBoxEmpty(form.textBoxLogin) && IsTextBoxEmpty(form.textBoxName) && IsTextBoxEmpty(form.textBoxPassword) && IsTextBoxEmpty(form.textBoxRepeatedPassword));
            if (!(IsTextBoxEmpty(form.textBoxLogin) && IsTextBoxEmpty(form.textBoxName) && IsTextBoxEmpty(form.textBoxPassword) && IsTextBoxEmpty(form.textBoxRepeatedPassword)))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
                return false;
            }
        }

        private bool IsPasswordsMatch()
        {
            if (form.textBoxPassword.Text == form.textBoxRepeatedPassword.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
        }

        public async void RegisterNewUser()
        {
            if (IsAllFieldsFilled())
            {
                if (IsPasswordsMatch())
                {
                    IHash hash = HashFactory.Crypto.CreateSHA512();
                    HashResult passwordHashed = hash.ComputeString(form.textBoxPassword.Text, Encoding.Unicode);


                    Response response = await API.RegisterNewUser(form.textBoxName.Text, form.textBoxLogin.Text,
                        passwordHashed.ToString());

                    if (response.Status == Response.StatusList.OK)
                    {
                        User user = JsonConvert.DeserializeObject<User>(response.Data);

                        MessageBox.Show($"Новый пользователь успешно зарегестрирован!\nИмя:{user.Name}\nЛогин:{user.Login}");

                        DataStorage.Add("user", user);

                        form.Hide();
                    }
                    else if (response.Status == Response.StatusList.ERROR)
                    {
                        MessageBox.Show(response.Data);
                    }
                }
            }
        }

    }
}
