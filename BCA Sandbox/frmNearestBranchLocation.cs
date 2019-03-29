using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BCA_Sandbox
{
    public partial class frmNearestBranchLocation : Form
    {
        public frmNearestBranchLocation()
        {
            InitializeComponent();
            nudRadius.Maximum = decimal.MaxValue;
            nudCount.Maximum = decimal.MaxValue;

            tbLatitude.Text = "-6.137235";
            tbLongitude.Text = "106.824928";
            nudRadius.Value = 500;
            nudCount.Maximum = 20;
            nudCount.Value = 20;

            refreshURI();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string timestamp;
                string responseSignature = Main.CreateSignature(tbURI.Text, tbAccessToken.Text, "GET", out timestamp);
                string[] lines = responseSignature.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                string result = lines.SingleOrDefault(l => l.StartsWith("CalculatedHMAC"));
                string[] HMAC = result.Split(':');
                tbSignature.Text = HMAC[1].Replace(" ", "");

                var request = (HttpWebRequest)WebRequest.Create(Main.HOST + tbURI.Text);

                request.Method = "GET";
                request.Headers.Add("Authorization", "Bearer " + tbAccessToken.Text);
                request.Headers.Add("X-BCA-Key", Main.API_KEY);
                request.Headers.Add("X-BCA-Signature", tbSignature.Text);
                request.Headers.Add("X-BCA-Timestamp", timestamp);

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

        private void tbLatitude_TextChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void tbLongitude_TextChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void nudRadius_ValueChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void cbValue_TextChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void refreshURI()
        {
            tbURI.Text = "/general/info-bca/branch?" +
                "Latitude=" + tbLatitude.Text + "" +
                "&Longitude=" + tbLongitude.Text +
                "&Radius=" + nudRadius.Value +
                "&Count=" + nudCount.Value +
                "&SearchBy=" + cbSearchBy.Text +
                "&Value=" + cbValue.Text;
        }
    }
}
