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
    public partial class frmForeignExchangeRate : Form
    {
        public frmForeignExchangeRate()
        {
            InitializeComponent();
            InitializeCBCurrencyCode();
            InitializeCBRateType();
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

        private void InitializeCBCurrencyCode()
        {
            cbCurrencyCode.DisplayMember = "Text";
            cbCurrencyCode.ValueMember = "Value";
            var items = new[] {
                new { Text = "Australia Dollar", Value = "AUD" },
                new { Text = "Bruneian Dollar", Value = "BND" },
                new { Text = "Canadian Dollar", Value = "CAD" },
                new { Text = "China Yuan", Value = "CNY" },
                new { Text = "Danish Krone", Value = "DKK" },
                new { Text = "Euro", Value = "EUR" },
                new { Text = "Francs", Value = "CHF" },
                new { Text = "Great Britain Poundsterling", Value = "GBP" },
                new { Text = "Hongkong Dollar", Value = "HKD" },
                new { Text = "Japan Yen", Value = "JPY" },
                new { Text = "Korea Won", Value = "KRW" },
                new { Text = "New Zealand Dollar", Value = "NZD" },
                new { Text = "Norwegian Krone", Value = "NOK" },
                new { Text = "Phillipine Peso", Value = "PHP" },
                new { Text = "Saudi Riyal", Value = "SAR" },
                new { Text = "Singapore Dollar", Value = "SGD" },
                new { Text = "Swedish Krona", Value = "SEK" },
                new { Text = "Taiwan Dollar", Value = "TWD" },
                new { Text = "Thailand Baht", Value = "THB" },
                new { Text = "US Dollar", Value = "USD" }
            };
            cbCurrencyCode.DataSource = items;
        }

        private void InitializeCBRateType()
        {
            cbRateType.DisplayMember = "Text";
            cbRateType.ValueMember = "Value";
            var items = new[] {
                new { Text = "Electronic Rate", Value = "eRate" },
                new { Text = "Telegrafic Transfer", Value = "TT" },
                new { Text = "Travellers Cheque", Value = "TC" },
                new { Text = "Bank Notes", Value = "BN" }
            };
            cbRateType.DataSource = items;
        }

        private void cbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void cbRateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void refreshURI()
        {
            tbURI.Text = "/general/rate/forex?CurrencyCode=" + cbCurrencyCode.SelectedValue + "&RateType=" + cbRateType.SelectedValue;
        }
    }
}
