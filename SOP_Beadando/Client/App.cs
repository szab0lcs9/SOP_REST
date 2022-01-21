using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class App : Form
    {
        static String URL = "http://localhost:80/SOP_Beadando/Server/REST/";
        static String ROUTE = "index.php";

        static Random rnd = new Random();

        private static string token;

        public App()
        {
            InitializeComponent();
        }

        private void CornyJokes_Load(object sender, EventArgs e)
        {

        }


        private void getButton_Click(object sender, EventArgs e)
        {
            idErrorNote.Visible = false;
            contentErrorNote.Visible = false;
            authorErrorNote.Visible = false;
            contentListBox.Items.Clear();
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);

            IRestResponse<List<Joke>> response = client.Execute<List<Joke>>(request);
            int x = rnd.Next(getMin(response.Data), getMax(response.Data));
            foreach (Joke joke in response.Data)
            {
                if (x == int.Parse(joke.Id))
                {
                    contentListBox.Items.Add(joke.Content);
                }
            }
            idTextBox.Clear();
            contentTextBox.Clear();
            authorTextBox.Clear();
        }

        private int getMax(List<Joke> data)
        {
            int max = int.Parse(data[data.Count - 1].Id);
            for (int i = data.Count - 2; i >= 0; i--)
            {
                if (int.Parse(data[i].Id) > int.Parse(data[i + 1].Id))
                {
                    max = int.Parse(data[i].Id);
                }
            }
            return max;
        }

        private int getMin(List<Joke> data)
        {
            int min = int.Parse(data[0].Id);
            for (int i = 1; i < data.Count; i++)
            {
                if (int.Parse(data[i].Id) < int.Parse(data[i-1].Id))
                {
                    min = int.Parse(data[i].Id);
                }
            }
            return min;
        }


        private void postButton_Click(object sender, EventArgs e)
        {
            idErrorNote.Visible = false;
            contentErrorNote.Visible = false;
            authorErrorNote.Visible = false;
            if (contentTextBox.Text.Length != 0)
            {
                contentErrorNote.Visible = false;
                //if (authorTextBox.Text.Length != 0)
                //{
                    authorErrorNote.Visible = false;
                    var client = new RestClient(URL);
                    string ROUTE = "/?jwt=" + token;
                    var request = new RestRequest(ROUTE, Method.POST);
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new Joke
                    {
                        Content = contentTextBox.Text,
                        //Author = authorTextBox.Text
                    });
                    IRestResponse response = client.Execute(request);
                    MessageBox.Show(response.Content);
                    idTextBox.Clear();
                    contentTextBox.Clear();
                    authorTextBox.Clear();
                //}
                //else authorErrorNote.Visible = true;
            }
            else contentErrorNote.Visible = true;
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            idErrorNote.Visible = false;
            contentErrorNote.Visible = false;
            authorErrorNote.Visible = false;
            if (idTextBox.Text.Length != 0)
            {
                idErrorNote.Visible = false;
                if (contentTextBox.Text.Length != 0)
                {
                    contentErrorNote.Visible = false;
                    var client = new RestClient(URL);
                    string ROUTE = "/?id=" + idTextBox.Text + "&jwt=" + token;
                    var request = new RestRequest(ROUTE, Method.PUT);
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new Joke
                    {
                        Content = contentTextBox.Text,
                    });
                    IRestResponse response = client.Execute(request);
                    MessageBox.Show(response.Content);
                    idTextBox.Clear();
                    contentTextBox.Clear();
                    authorTextBox.Clear();
                }
                else contentErrorNote.Visible = true;
            }
            else idErrorNote.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            idErrorNote.Visible = false;
            contentErrorNote.Visible = false;
            authorErrorNote.Visible = false;
            if (idTextBox.Text.Length != 0)
            {
                idErrorNote.Visible = false;
                var client = new RestClient(URL);
                string ROUTE = "/?id=" + idTextBox.Text + "&jwt=" + token;
                var request = new RestRequest(ROUTE, Method.DELETE);
                IRestResponse response = client.Execute(request);
                MessageBox.Show(response.Content);
                idTextBox.Clear();
                contentTextBox.Clear();
                authorTextBox.Clear();
            }
            else idErrorNote.Visible = true;
        }

        private void getWithId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            idErrorNote.Visible = false;
            contentErrorNote.Visible = false;
            authorErrorNote.Visible = false;
            if (idTextBox.Text.Length != 0)
            {
                try
                {
                    contentListBox.Items.Clear();
                    idErrorNote.Visible = false;

                    string ROUTE = "/?id=" + idTextBox.Text;
                    var client = new RestClient(URL);
                    var request = new RestRequest(ROUTE, Method.GET);

                    IRestResponse<List<Joke>> response = client.Execute<List<Joke>>(request);
                    contentListBox.Items.Add(response.Data[0].Id + "\t" + response.Data[0].Content + "\t" + response.Data[0].Author);
                    idTextBox.Clear();
                    contentTextBox.Clear();
                    authorTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The given Id was incorrect. Please add another one!\n\nError message:\n" + ex.Message);
                }
            }
            else idErrorNote.Visible = true;
        }

        private void getAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            idErrorNote.Visible = false;
            contentErrorNote.Visible = false;
            authorErrorNote.Visible = false;
            idTextBox.Text = null;
            contentListBox.Items.Clear();
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);
            
            IRestResponse<List<Joke>> response = client.Execute<List<Joke>>(request);
            foreach (Joke joke in response.Data)
            {
                contentListBox.Items.Add(joke.Id + "\t" + joke.Content + "\t" + joke.Author);
            }
            idTextBox.Clear();
            contentTextBox.Clear();
            authorTextBox.Clear();
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
        }
        
        public bool getLoginData(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            string[] content = response.Content.Trim().Split(',');
            if (content[0] == "")
            {
                if (content[0].Contains("failed"))
                {
                    MessageBox.Show("Invalid username or password!");
                    return false;
                }
                return false;
            }
            else
            {
                MessageBox.Show(content[0]);
                string[] jwt = content[1].Split(':');
                token = jwt[1];
                token = token.Remove(token.Length - 1);
                token = token.Trim('"');
                return true;
            }
        }

        private void resetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ROUTE += "/?comm=reset";
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);
            IRestResponse response = client.Execute(request);
            MessageBox.Show(response.Content);
        }
    }
}
