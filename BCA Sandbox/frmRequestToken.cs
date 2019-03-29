using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BCA_Sandbox
{
    public partial class frmRequestToken : Form
    {
        public frmRequestToken()
        {
            InitializeComponent();
            tbAuthorization.Text = "Basic " + System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Main.CLIENT_ID + ":" + Main.CLIENT_ID_SECRET));
            cbContentType.SelectedIndex = 0;
            tbGrantType.Text = "client_credentials";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var request = (HttpWebRequest)WebRequest.Create(Main.HOST + "/api/oauth/token");

                var postData = "grant_type=" + tbGrantType.Text;
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.Headers.Add("Authorization", tbAuthorization.Text);
                request.ContentType = cbContentType.Text;
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic jsonParsed = JsonConvert.DeserializeObject(responseString);
                rtbResult.Text = JsonConvert.SerializeObject(jsonParsed, Formatting.Indented);
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string error = reader.ReadToEnd();
                            JObject jObject = JObject.Parse(error);
                            string message = (string)jObject.SelectToken("ErrorMessage.Indonesian");
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
