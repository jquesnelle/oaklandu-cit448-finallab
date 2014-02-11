using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace cit448_finallab_client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int titleHeight;

        private enum UI_STATE
        {
            Login,
            User,
            Admin
        };

        private void SetState(UI_STATE state)
        {
            switch (state)
            {
                case UI_STATE.Login:
                    Height = panLogin.Height + panLogin.Top + titleHeight + 12;
                    break;
                case UI_STATE.User:
                    Height = panRegular.Height + panRegular.Top + titleHeight + 12;
                    panRegular.Visible = true;
                    panAdmin.Visible = false;
                    break;
                case UI_STATE.Admin:
                    panAdmin.Top = panRegular.Top;
                    Height = panAdmin.Height + panAdmin.Top + titleHeight + 12;
                    panRegular.Visible = false;
                    panAdmin.Visible = true;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            titleHeight = screenRectangle.Top - this.Top;

            SetState(UI_STATE.Login);
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        [DataContract]
        private class UserInfo
        {
            [DataMember]
            public string name;

            [DataMember]
            public float grade;

            [DataMember]
            public string user_pass;

            [DataMember]
            public string admin_pass;
        }

        public static T Deserialize<T>(string jsonString)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }

        public static string Serialize<T>(T data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                serializer.WriteObject(ms, data);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            UserInfo info = null;
            using (WebClient client = new WebClient())
            {
                try
                {
                    String url = "http://" + txtServer.Text + "/user-info?name=" + txtUsername.Text;
                    String result = client.DownloadString(url);
                    info = Deserialize<UserInfo>(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to log in! Error: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetState(UI_STATE.Login);
                    return;
                }
            }
            if (info.user_pass.Equals(txtPassword.Text))
            {
                SetState(UI_STATE.User);
                lblGrade.Text = String.Format("{0:0.0}", info.grade);
            }
            else if (info.admin_pass.Equals(txtPassword.Text))
            {
                SetState(UI_STATE.Admin);
                txtGrade.Text = String.Format("{0:0.0}", info.grade);
            }
            else
            {
                MessageBox.Show("Incorrect password!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetState(UI_STATE.Login);
                return;
            }
        }

        private void panRegular_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            double grade = 0;
            string result = null;
            if (!Double.TryParse(txtGrade.Text, out grade) || grade < 0 || grade > 4 )
            {
                MessageBox.Show("Please enter a valid grade between 0.0-4.0", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    String url = "http://" + txtServer.Text + "/update-grade";
                    NameValueCollection reqparm = new NameValueCollection();
                    reqparm.Add("name", txtUsername.Text);
                    reqparm.Add("grade", txtGrade.Text);
                    result = Encoding.UTF8.GetString(client.UploadValues(url, "POST", reqparm));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to submit grade! Error: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            bool ok = result.Equals("OK");
            MessageBox.Show(ok ? "Grade change submitted successfully!" : "Grade change not accepted", Text, MessageBoxButtons.OK, ok ? MessageBoxIcon.None : MessageBoxIcon.Error);
        }
    }
}
