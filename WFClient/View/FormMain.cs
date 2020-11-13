using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFClient.Controller;

namespace WFClient.View
{
    public partial class FormMain : Form
    {
        private ControllerFormMain controller;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            controller = new ControllerFormMain(this);
            controller.UpdateLabelUsername();
            comboBoxNumberCardFrom.Enabled = false;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.CloseApp();
        }

        private async void buttonGetCards_Click(object sender, EventArgs e)
        {
            await controller.CardsGetCardsByUserId();
        }

        private async void buttonCreateNewCard_Click(object sender, EventArgs e)
        {
            await controller.CreateNewUniqueCard();
        }

        private async void buttonAddBalance_Click(object sender, EventArgs e)
        {

            try
            {
                int.Parse(textBoxMoneyCountAddingBalance.Text);
                int.Parse(textBoxNumberCardAddingBalance.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Вводите только цифры в поля для ввода!");
            }

            if (int.Parse(textBoxMoneyCountAddingBalance.Text) < 0 || int.Parse(textBoxNumberCardAddingBalance.Text) < 0)
            {
                MessageBox.Show("Нельзя вводить отрицательные значения");
            }
            else
            {
                await controller.CardsAddingCardBalanceByNumber();
            }


        }

        private async void buttonSendMoney_Click(object sender, EventArgs e)
        {
            await controller.SendMoney();
        }
    }
}
