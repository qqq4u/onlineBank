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
    class ControllerFormMain
    {
        private FormMain form = null;
        private APIWorker API = null;
        private User user;

        public ControllerFormMain(FormMain form)
        {
            this.form = form;

            API = APIWorker.GetInstance();
            user = (User)DataStorage.Get("user");
        }

        public void UpdateLabelUsername()
        {
            form.labelUsername.Text = user.Name;
        }

        public void CloseApp()
        {
            Application.Exit();
        }

        public async Task CreateNewUniqueCard()
        {
            Response response = await API.CardCreateNewCardWithUniqueNumber(user.Id);

            if (response.Status == Response.StatusList.OK)
            {
                MessageBox.Show("Карта успешно добавлена!");
                CardsGetCardsByUserId();
            }
            else
            {
                MessageBox.Show("Ошибка при создании карты");
            }
        }

        public async Task CardsGetCardsByUserId()
        {
            form.buttonGetCards.Enabled = false;
            List<Card> cards = null;

            Response response = await API.CardsGetCardsByUserId(user.Id);

            if (response.Status == Response.StatusList.OK)
            {
                cards = JsonConvert.DeserializeObject<List<Card>>(response.Data);
                form.dataGridViewCardsList.DataSource = null;
                form.dataGridViewCardsList.DataSource = cards;

            }
            else if (response.Status == Response.StatusList.ERROR)
            {
                MessageBox.Show("error " + response.Data);
            }

            form.comboBoxNumberCardFrom.DataSource = null;

            form.comboBoxNumberCardFrom.DataSource = cards;
            form.comboBoxNumberCardFrom.DisplayMember = "Number";
            form.comboBoxNumberCardFrom.ValueMember = "Number";

            form.comboBoxNumberCardFrom.Enabled = true;
            form.buttonSendMoney.Enabled = true;

            form.buttonGetCards.Enabled = true;

        }

        public async Task SendMoney()
        {
            form.buttonSendMoney.Enabled = false;

            Response response = await API.SendMoney(int.Parse(form.comboBoxNumberCardFrom.Text),
                int.Parse(form.textBoxNumberCardTo.Text), int.Parse(form.textBoxMoneyCount.Text));

            if (response.Status == Response.StatusList.OK)
            {
                MessageBox.Show("Перевод совершён успешно!");
                CardsGetCardsByUserId();
            }
            else
            {// todo сделать проверку конкретной ошибки
                MessageBox.Show("Ошибка");
            }

            form.buttonSendMoney.Enabled = true;
        }


        public async Task CardsAddingCardBalanceByNumber()
        {
            form.buttonAddBalance.Enabled = false;

            Response response = await API.AddingCardBalanceByNumber(int.Parse(form.textBoxNumberCardAddingBalance.Text),
                int.Parse(form.textBoxMoneyCountAddingBalance.Text));
            if (response.Status == Response.StatusList.OK)
            {
                MessageBox.Show("Баланс карты успешно пополнен!");
                CardsGetCardsByUserId();
            }
            else
            {// todo сделать проверку конкретной ошибки
                MessageBox.Show("Ошибка");
            }

            form.buttonAddBalance.Enabled = true;
        }
    }
}
