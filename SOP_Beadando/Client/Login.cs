using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        static String URL = "http://localhost:80/SOP_Beadando/Server/REST/";
        static String ROUTE = "index.php";
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new User
            {
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Text
            });
            App app = new App();
            app.getLoginData(client, request);
            this.Close();
        }
    }
}
