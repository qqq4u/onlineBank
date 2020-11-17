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
    public partial class FormAuth : Form
    {
        private ControllerFormAuth controller;
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            controller = new ControllerFormAuth(this);
        }

        private async void buttonAuth_Click(object sender, EventArgs e)
        {
            await controller.UserGetUserByLoginPassword();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            controller.OpenNewRegistrationForm();
        }
    }
}
