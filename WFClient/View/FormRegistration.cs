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
    public partial class FormRegistration : Form
    {
        private ControllerFormRegistration controller;
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            controller.RegisterNewUser();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            controller = new ControllerFormRegistration(this);
        }
    }
}
