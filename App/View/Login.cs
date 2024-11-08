using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_1057_UTS_PBO.App.View
{
    public partial class Login : Form
    {
        private readonly object txtUsername;
        private object lblResult;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (Login(username, password))
            {
                lblResult.Text = "Login Successful!";
            }
            else
            {
                lblResult.Text = "Login Failed!";
            }

    }
}

