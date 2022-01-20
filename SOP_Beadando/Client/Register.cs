using RestSharp;
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
    public partial class Register : Form
    {
        String URL = "http://localhost:80/SOP_Beadando/Server/REST/";
        String ROUTE = "index.php";

        public Register()
        {
            InitializeComponent();
        }

        private void signInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ROUTE += "/?comm=register";
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new User
            {
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Text
            });
            IRestResponse response = client.Execute(request);
            MessageBox.Show(response.Content);
            if (response.Content.Contains("Success"))
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
