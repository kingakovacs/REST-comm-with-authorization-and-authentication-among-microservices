using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string username;
        private Dictionary<string, string> user_token;

        public Form1()
        {
            InitializeComponent();
            user_token = new Dictionary<string, string>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setVisibility(false, true, false, false, false, true, false);
        }

        public void setVisibility(bool pSignup, bool plogin, bool bListUsers, bool bSignUp, bool bNewuser, bool bLogin, bool lvusers)
        {
            pSignUp.Visible = pSignup;
            pLogin.Visible = plogin;
            btnListUsers.Visible = bListUsers;
            btnSignUp.Visible = bSignUp;
            btnNewUser.Visible = bNewuser;
            btnLogin.Visible = bLogin;
            lvUsers.Visible = lvusers;
        }

        public void sendGet()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:3030?access_token=" + user_token[username] + "&token_type=bearer&expires_in=21600");

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            string[] resp = responseString.Split('"');

            lvUsers.Columns.Clear();
            lvUsers.Items.Clear();

            lvUsers.Columns.Add("Username", "Username", 100);
            lvUsers.Columns.Add("Is admin", "Is admin", 80);
            lvUsers.Columns.Add("Fullname", "Fullname", 100);
            lvUsers.Columns.Add("Email address", "Email address", 200);

            int i = 7;
            while(resp.Length > i)
            {
                ListViewItem list = new ListViewItem(resp[i]); i += 11;
                var result = resp[i].Substring(1, resp[i].Length-2);
                list.SubItems.Add(result); i += 3;
                list.SubItems.Add(resp[i]); i += 4;
                list.SubItems.Add(resp[i]); i += 10;
                lvUsers.Items.Add(list);
            }

            setVisibility(false, false, true, false, true, false, true);
        }

        public void sendPost(string postData, string contentType)
        {
            var data = Encoding.ASCII.GetBytes(postData);
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtUsername.Text + ":" + txtPassword.Text));
            HttpWebRequest request;

            if (contentType.Equals("application/x-www-form-urlencoded"))
            {
                request = (HttpWebRequest)WebRequest.Create("http://localhost:3030/token/auth");
                request.Headers.Add("Authorization", "Basic " + svcCredentials);
            }
            else
            {
                request = (HttpWebRequest)WebRequest.Create("http://localhost:3030/");
                request.Headers.Add("Authorization", "Bearer " + user_token[username]);
            }

            request.Method = "POST";
            request.ContentType = contentType;
            request.ContentLength = data.Length;

            using (var dstream = request.GetRequestStream())
            {
                dstream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(stream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            if (contentType.Equals("application/x-www-form-urlencoded")) {
                string[] resp = responseFromServer.Split('"');
                user_token.Add(username, resp[7]);      //get the token from server's response
            }
            // Clean up the streams.
            reader.Close();
            stream.Close();
            response.Close();

            setVisibility(false, false, true, false, true, false, false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            string contentType = "application/x-www-form-urlencoded";
            var postData = "grant_type=password";
            postData += "&username=" + txtUsername.Text;
            postData += "&password=" + txtPassword.Text;
            sendPost(postData, contentType);
            setVisibility(false, false, true, false, true, false, false);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string contentType = "application/json";
            var postData = "{\"username\":\"" + txtUsername.Text + "\",";
            postData += "\"password\":\"" + txtPassword.Text + "\",";
            if (chkAdmin.Checked)
            {
                postData += "\"admin\":true,";
            }
            else
            {
                postData += "\"admin\":false,";
            }
            postData += "\"fullname\":\"" + txtFullName.Text + "\",";
            postData += "\"emailaddress\":\"" + txtEmail.Text + "\"}";
            sendPost(postData, contentType);
            setVisibility(false, false, true, false, true, false, false);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            setVisibility(true, true, false, true, false, false, false);
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            setVisibility(false, false, true, false, true, false, true);
            sendGet();
        }
    }
}
