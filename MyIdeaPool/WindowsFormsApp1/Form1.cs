using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static string url = "http://localhost:49875/";
        private static HttpClient client = new HttpClient();
        private static HttpResponseMessage response;

        public Form1()
        {
            InitializeComponent();
            UrlTextBox.Text = url;
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void UpdRsp()
        {
            ResponseTextBox.Text += await response.Content.ReadAsStringAsync();
        }
        private void Upd()
        {
            var t = response.Content.ReadAsStringAsync();
            ResponseTextBox.Text += t.Result + Environment.NewLine;
            LastResponseCodeLabel.Text = response.StatusCode.ToString();
        }
        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            var user = new
            {
                name = NameTextBox.Text,
                email = EmailTextBox.Text,
                password = PasswordTextBox.Text
            };
            response = await client.PostAsJsonAsync("users", user);
            Upd();
        }

        private void UrlTextBox_TextChanged(object sender, EventArgs e)
        {
            url = UrlTextBox.Text;
            client.BaseAddress = new Uri(url);
        }

        private async void GetTokenButton_Click(object sender, EventArgs e)
        {
            var token = await response.Content.ReadAsAsync<JwtToken>();
            JwtTextBox.Text = token.jwt;
            RefreshTextBox.Text = token.refresh_token;
        }

        private void ResponseLogClearButton_Click(object sender, EventArgs e)
        {
            var t = response.Content.ReadAsStringAsync();
            ResponseTextBox.Text = t.Result + Environment.NewLine;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var user = new
            {
                email = EmailTextBox.Text,
                password = PasswordTextBox.Text
            };
            response = await client.PostAsJsonAsync("access-tokens", user);
            Upd();
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            var refreshTokenBody = new
            {
                refresh_token = RefreshTextBox.Text
            };
            response = await client.PostAsJsonAsync("access-tokens/refresh", refreshTokenBody);
            Upd();
            JwtTextBox.Text = await response.Content.ReadAsStringAsync();
        }

        private async void LogoutButton_Click(object sender, EventArgs e)
        {
            var refreshTokenBody = new
            {
                refresh_token = RefreshTextBox.Text
            };
            var request = new HttpRequestMessage(HttpMethod.Delete, "access-tokens");
            request.Content = new StringContent(JsonConvert.SerializeObject(refreshTokenBody), Encoding.UTF8, "application/json");
            response = await client.SendAsync(request);
            Upd();
        }

        private async void MeButton_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "me");
            request.Headers.Add("X-Access-Token", JwtTextBox.Text);
            response = await client.SendAsync(request);
            Upd();
        }

        private async void CreateIdeaButton_Click(object sender, EventArgs e)
        {
            var idea = new
            {
                content = NewIdeaContentTextBox.Text,
                impact = int.Parse(NewIdeaImpactTextBox.Text),
                ease = int.Parse(NewIdeaEaseTextBox.Text),
                confidence = int.Parse(NewIdeaConfidenceTextBox.Text)
            };
            var request = new HttpRequestMessage(HttpMethod.Post, "ideas");
            request.Headers.Add("X-Access-Token", JwtTextBox.Text);
            request.Content = new StringContent(JsonConvert.SerializeObject(idea), Encoding.UTF8, "application/json");
            response = await client.SendAsync(request);
            Upd();
        }

        private async void GetIdeaButton_Click(object sender, EventArgs e)
        {
            var idea = await response.Content.ReadAsAsync<Idea>();
            IdeaIdTextBox.Text = idea.id;
            IdeaContentTextBox.Text = idea.content;
            IdeaImpactTextBox.Text = idea.impact.ToString();
            IdeaEaseTextBox.Text = idea.ease.ToString();
            IdeaConfidenceTextBox.Text = idea.confidence.ToString();
            IdeaAvgTextBox.Text = idea.average_score.ToString();
            IdeaCreatedAtTextBox.Text = idea.created_at.ToString();
        }

        private async void DeleteIdeaButton_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, @"ideas/" + IdeaIdTextBox.Text);
            request.Headers.Add("X-Access-Token", JwtTextBox.Text);
            response = await client.SendAsync(request);
            Upd();
        }

        private async void UpdateIdeaButton_Click(object sender, EventArgs e)
        {
            var idea = new
            {
                content = NewIdeaContentTextBox.Text,
                impact = int.Parse(NewIdeaImpactTextBox.Text),
                ease = int.Parse(NewIdeaEaseTextBox.Text),
                confidence = int.Parse(NewIdeaConfidenceTextBox.Text)
            };
            var request = new HttpRequestMessage(HttpMethod.Put, @"ideas/" + IdeaIdTextBox.Text);
            request.Headers.Add("X-Access-Token", JwtTextBox.Text);
            request.Content = new StringContent(JsonConvert.SerializeObject(idea), Encoding.UTF8, "application/json");
            response = await client.SendAsync(request);
            Upd();
        }

        private async void GetIdeasButton_Click(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, @"ideas");
            request.Headers.Add("X-Access-Token", JwtTextBox.Text);
            response = await client.SendAsync(request);
            Upd();
        }
    }
}
